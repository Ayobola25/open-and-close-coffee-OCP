namespace open_and_close_coffee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Ayobola Coffee World\n");
           
            //it catches all extensions
            try
            {
                Console.WriteLine("What quantity of coffee do you want (ml)?");
                double quantity = Convert.ToDouble(Console.ReadLine());
                

                var priceList = new List<double>();
                //instantiation of classes
                var filtered = new FilteredCoffee();
                var unfiltered = new Unfilteredcoffee();
                var totalPrice = new TotalCoffeePrice();

                //initialization of amount
                double filteredAmount = 100d;
                double unfilteredAmount = 50d;
                

                

                priceList.Add(filtered.ServeCoffee(quantity, filteredAmount));
                priceList.Add(unfiltered.ServeCoffee(quantity, unfilteredAmount));

                Console.WriteLine("The price for the filtered coffee is "+ filtered.ServeCoffee( quantity,filteredAmount));
                Console.WriteLine("The price for the unfiltered coffee is " + unfiltered.ServeCoffee(quantity, unfilteredAmount));

                Console.WriteLine("The total price for the coffee is "+totalPrice.CalPrice(priceList)); 

               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine(ex.Message);
            }
        }
    }

}