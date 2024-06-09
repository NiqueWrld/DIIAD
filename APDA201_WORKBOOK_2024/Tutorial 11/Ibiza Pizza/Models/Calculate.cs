using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Ibiza_Pizza.Models
{
    public class Calculate
    {
        [Required]
        public double cashTendered { get; set; }
        [Required]
        public string pizzaType { get; set; }
        [Required]
        [Range(1 , 5)]
        public int pizzaQuantity { get; set; }
        public double amountSpent { get; set; }
        public double change { get; set; }

        public double calcAmountSpent()
        {
            double total = 0;
            if(pizzaType == "Veg")
            {
                total = pizzaQuantity * 11.99;
            }
            else if(pizzaType == "Chicken")
            {
                total = pizzaQuantity * 14.99;
            }
            return total;
        }

        public double calcChange()
        {
            double total = 0;

            if(cashTendered > calcAmountSpent())
            {
                total = cashTendered - calcAmountSpent();
            }

            return total;
        }

    }
}