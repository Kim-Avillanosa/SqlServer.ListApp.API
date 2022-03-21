using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Logging
{
    public interface ILoggingManager
    {
        public void WriteSuccess(LogDetail detail);
        public void WriteError(LogDetail detail);
        public void WriteInfo(LogDetail detail);
        public void WriteWarning(LogDetail detail);
    }
}
