using HomeBudget.Calculator.Models;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudget.Calculator.Services
{
    public class CalculatorService
    {



        public BudgetReport GenerateBudgetToJson(double income, params Item[] items)
        {
            BudgetReport report = new BudgetReport();

            foreach (var item in items)
            {
                if (item.IsEnabled)
                    report.TotalCost += item.Cost;
            }

            report.Items = items.ToList();
            report.Income = income;
           // var jsonResult = JsonConvert.SerializeObject(report);

            return report;

        }

    }
}
