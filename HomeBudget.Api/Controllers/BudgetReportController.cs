using HomeBudget.Calculator.Models;
using HomeBudget.Calculator.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudget.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    public class BudgetReportController : Controller
    {
        private readonly CalculatorService calc_svc;
        public BudgetReportController()
        {
            this.calc_svc = new CalculatorService();
        }

        [HttpPost]
        public async Task<JsonResult> BuildReport([FromBody] double income = 10000, [FromBody] params Item[] items)
        {
            var report = this.calc_svc.GenerateBudgetToJson(income, items);
            var res = new ReportResponse<BudgetReport>() {
            Id = "1",
            StatusCode = 200,
            StatusMessage = "OK",
            report = report
            };
            
           
            return Json(res);


        }
    }
}
