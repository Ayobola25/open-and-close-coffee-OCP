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
         public abstract string ServeCoffee();
        }
    
   
    /// <summary>
    /// this is a derived class that extend the base class
    /// it serves filterd coffee
    /// </summary>
    public class FilteredCoffee : Coffee
        {
       public override string ServeCoffee()
        {
            return "Serving Filtered Coffee";
        }
        }


    /// <summary>
    /// this is a derived class that extend the base class
    /// it serves unfiltered coffee
    /// </summary>
    public class Unfilteredcoffee : Coffee
        {
        public override string ServeCoffee()
        {
            return "Serving Unfiltered Coffee";
        }
    }
}
   