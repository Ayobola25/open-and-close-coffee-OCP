namespace open_and_close_coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ayobola Coffee World\n");
            Console.WriteLine("What type of coffee do you want\n");
            Console.WriteLine("Enter 1 for Filtered Coffee\n");
            Console.WriteLine("Enter 2 for Unfiltered Coffee\n");
            //it catches all extensions
            try
            {
                int coffeeType = int.Parse(Console.ReadLine());
                //instantiation of classes
                var filtered = new FilteredCoffee();
                var unfiltered = new Unfilteredcoffee();

                if(coffeeType == 1)
                {
                    Console.WriteLine(filtered.ServeCoffee()); 
                }
                else if(coffeeType == 2)
                {
                    Console.WriteLine(unfiltered.ServeCoffee()); 
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine(ex.Message);
            }
        }
    }
}