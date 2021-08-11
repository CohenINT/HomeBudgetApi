using System;
using System.Collections.Generic;
using System.Text;

namespace HomeBudget.Calculator.Models
{
    /// <summary>
    /// This would be the model for the json result.
    /// </summary>
    public class BudgetReport
    {
        public List<Item> Items { set; get; }
        public double TotalCost { set; get; }
        public double Income { set; get; }


    }


}
