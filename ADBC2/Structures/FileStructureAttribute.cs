/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 20:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ADBC2.Structures
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class FileStructureAttribute : Attribute
    {
        public string FileName;

        public FileStructureAttribute(string fileName)
        {
            FileName = fileName;
        }
    }
}
