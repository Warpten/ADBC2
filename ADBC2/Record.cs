/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 19:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ADBC2
{
    /// <summary>
    /// Description of Record.
    /// </summary>
    public class Record
    {
        private object RecordEntry;
        private Type RecordType;
        private Type StructureType;
        
        public Record(object record, Type recordType, Type structureType)
        {
            RecordEntry = record;
            RecordType = recordType;
            StructureType = structureType;
        }
        
        public override string ToString()
        {
            return "Foo";
        }
    }
}
