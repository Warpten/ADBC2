/*
 * Created by SharpDevelop.
 * User: Warpten
 * Date: 15/09/2014
 * Time: 20:02
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ADBC2
{
    /// <summary>
    /// Description of DbcNotFoundException.
    /// </summary>
    public class DbcNotFoundException : Exception
    {
        public DbcNotFoundException()
        {
        }

        public override string ToString()
        {
            return "Could not locate /dbc/ directory.";
        }
    }

    public class UnsupportedClientBuildException : Exception
    {
        protected uint Build;

        public UnsupportedClientBuildException(uint build)
        {
            Build = build;
        }

        public override string ToString()
        {
            return string.Format("Unsupported client build {0}", Build);
        }
    }

    public class DbcFileNameNotFoundException : Exception
    {
        protected string FileName;

        public DbcFileNameNotFoundException(string fileName)
        {
            FileName = fileName;
        }

        public override string ToString()
        {
            return string.Format("Structure defined for file {0}, which does not exist.", FileName);
        }
    }

    public class InvalidCoreStructure : Exception
    {
        protected string Message;

        public InvalidCoreStructure(string message, params object[] args)
        {
            this.Message = String.Format(message, args);
        }

        public override string ToString()
        {
            return Message;
        }
    }
}
