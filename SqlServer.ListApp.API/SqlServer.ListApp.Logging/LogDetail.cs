using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServer.ListApp.Logging
{
    public class LogDetail
    {

        public string Title { get; set; }
        public string Detail { get; set; }
        public string TraceId { get; set; }
        public Exception Exception { get; set; }


        public LogDetail(string title, string detail, string traceId, Exception exception)
        {
            Title = title;
            Detail = detail;
            TraceId = traceId;
            Exception = exception;
        }
    }
}
