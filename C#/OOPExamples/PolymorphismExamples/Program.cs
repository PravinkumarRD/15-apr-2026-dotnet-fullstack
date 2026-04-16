namespace PolymorphismExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism Examples!");
            //BajajSales sales = new BajajSales();
            //Overloading Examples
            BajajForeignSales sales = new BajajForeignSales();
            Console.WriteLine($"Bajaj Sales Net Profit without GST is INR {sales.SalesNetProfit(12000, 13000, 150000)}");
            Console.WriteLine($"Bajaj Sales Net Profit with 18% GST is INR {sales.SalesNetProfit(12000, 13000, 150000, 18)}");
            Console.WriteLine($"Bajaj Foreign Sales Net Profit with 18% GST is INR {sales.SalesNetProfit(12000, 13000, 150000, 18, 4000)}");

            //Overriding Example
            BajajSales bajajSales = new BajajForeignSales();
            Console.WriteLine($"GST percent is {bajajSales.GstPercent()}");

            //Shadowing
            //BajajSales shadowMethod=new BajajSales();
            //BajajForeignSales shadowMethod = new BajajForeignSales();
            BajajSales shadowMethod = new BajajForeignSales();
            Console.WriteLine($"Shipping amount is  - {shadowMethod.ShippingAmount()}");
        }
    }
}
