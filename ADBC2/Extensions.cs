/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 19:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ADBC2
{
    /// <summary>
    /// Description of Extensions.
    /// </summary>
    public static class Extensions
    {   
        public static string Join(this int[] data)
        {
            string returnValue = "[";
            for (var i = 0; i < data.Length - 1; ++i)
                returnValue += String.Format(" {0},", data[i]);
            return returnValue + String.Format(" {0} ]", data[data.Length - 1]);
        }
        
        public static string Join(this uint[] data)
        {
            string returnValue = "[";
            for (var i = 0; i < data.Length - 1; ++i)
                returnValue += String.Format(" {0},", data[i]);
            return returnValue + String.Format(" {0} ]", data[data.Length - 1]);
        }
    }
}
