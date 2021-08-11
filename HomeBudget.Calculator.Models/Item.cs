using System;

namespace HomeBudget.Calculator.Models
{

    public class Item
    {
        public string Name { set; get; }
        public int Cost { set; get; }
        public CategoryEnum Category { set; get; }
        public bool IsEnabled { set; get; } = true;

    }








}
