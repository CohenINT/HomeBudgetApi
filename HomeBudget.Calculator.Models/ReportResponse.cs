using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudget.Calculator.Models
{
    public class ReportResponse<T> where T : new()
    {
        public virtual string Id { set; get; }
        public virtual int StatusCode { set; get; }
        public virtual string StatusMessage { set; get; }
        public T report { set; get; }

        public ReportResponse(T _report)
        {
            this.report = _report;
        }
        public ReportResponse()
        {

        }

    }
}
