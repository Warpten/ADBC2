using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

using BrightIdeasSoftware;

namespace ADBC2
{
    /// <summary>
    /// Description of ListDataSource.
    /// </summary>
    public class ListDataSource : FastObjectListDataSource
    {
        public ListDataSource(FastObjectListView listView) : base(listView)
        {
        }

        private Dictionary<OLVColumn, SortOrder> sorters = new Dictionary<OLVColumn, SortOrder>();

        public override void Sort(OLVColumn column, SortOrder sortOrder)
        {
            if (sortOrder != SortOrder.None && !sorters.ContainsKey(column))
                sorters.Add(column, sortOrder);
            else if (sortOrder == SortOrder.None && sorters.ContainsKey(column))
                sorters.Remove(column);

            ArrayList objects = (ArrayList)this.listView.Objects;
            objects.Sort(new FancyModelObjectComparer(sorters));

            this.RebuildIndexMap();
        }
    }

    /// <summary>
    /// This comparer can be used to sort a collection of model objects by a given set of columns and orders
    /// </summary>
    public class FancyModelObjectComparer : IComparer, IComparer<object>
    {
        private OLVColumn[] Columns;
        private SortOrder[] Orders;

        public FancyModelObjectComparer(Dictionary<OLVColumn, SortOrder> pairs)
        {
            this.Columns = pairs.Keys.ToArray();
            this.Orders  = pairs.Values.ToArray();
        }

        public int Compare(object x, object y)
        {
            var sortsCount = this.Columns.Length;
            var result = 0;
            for (var i = 0; i < sortsCount; ++i)
            {
                // Don't bother sorting (Should NOT happen)
                if (this.Orders[i] == SortOrder.None)
                    continue;

                object x1 = this.Columns[i].GetValue(x);
                object y1 = this.Columns[i].GetValue(y);

                // Handle nulls. They come last.
                bool xIsNull = (x1 == null || x1 == System.DBNull.Value);
                bool yIsNull = (y1 == null || y1 == System.DBNull.Value);
                if (xIsNull || yIsNull)
                {
                    if (xIsNull && yIsNull)
                        result = 0;
                    else
                        result = (xIsNull ? -1 : 1);
                }
                else
                    result = this.CompareValues(x1, y1);

                if (this.Orders[i] == SortOrder.Descending)
                    result = -result;
            }

            return result;
        }

        public int CompareValues(object x, object y)
        {
            // Force case insensitive compares on strings
            String xStr = x as String;
            if (xStr != null)
                return String.Compare(xStr, (String)y, StringComparison.CurrentCultureIgnoreCase);

            IComparable comparable = x as IComparable;
            if (comparable != null)
                return comparable.CompareTo(y);
            return 0;
        }
    }
}
