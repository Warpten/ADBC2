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
    /// Description of ExportWorkerParameters.
    /// </summary>
    public class ExportWorkerParameters
    {
        public const int EXPORT_SQL = 0;
        public const int EXPORT_IDA = 1;
        
        public int ExportType;
        
        public ExportWorkerParameters(int ExportType)
        {
            this.ExportType = ExportType;
        }
    }
}
