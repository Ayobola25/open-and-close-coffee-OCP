using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_and_close_coffee
{
    /// <summary>
    /// this is the base class that other classes will inherit from
    /// </summary>
    public abstract class Coffee
        {
        public double Quantity { get; set; } 
        public double Amount { get; set; }
         public abstract double ServeCoffee(double quantity, double amount);
        }
    
   
    
    /// <summary>
    /// this is the main class that is not open to modification
    /// </summary>
    public class TotalCoffeePrice
    {
        /// <summary>
        /// this method sums up all of the coffee prices
        /// </summary>
        /// <param name="coffeePrice"></param>
        /// <returns></returns>
        public double CalPrice(List<double> coffeePrice)
        {
            double total = 0;
            foreach(var coffee in coffeePrice)
            {
                total = total + coffee;
            }
            return total;
        }
    }

    /// <summary>
    /// this is a derived class that extend the base class
    /// it serves filterd coffee
    /// </summary>
    public class FilteredCoffee : Coffee
        {
       public override double ServeCoffee(double quantity, double amount)
        {   
            this.Quantity = quantity;
            this.Amount = amount;
            return quantity * amount;
        }
        }


    /// <summary>
    /// this is a derived class that extend the base class
    /// it serves unfiltered coffee
    /// </summary>
    public class Unfilteredcoffee : Coffee
        {
        public override double ServeCoffee(double quantity, double amount)
        {

            this.Quantity = quantity;
            this.Amount = amount;
            return quantity * amount;
        }
    }
}
   