namespace ClassTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Examples!");
            PrimeCustomer primeCustomer = new PrimeCustomer();
            primeCustomer.CustomerId = 100;
            primeCustomer.ContactName = "Test";
            primeCustomer.City = "Test";
            primeCustomer.Country = "Test";
            primeCustomer.Address = "My Old Address";
            primeCustomer.SocialId = 283923;
            primeCustomer.ChangeAddress(primeCustomer.SocialId, "My New Address");
            
            //Object Initializer
            Order order = new Order() { OrderId=1,CustomerId=primeCustomer.CustomerId,OrderDate=DateTime.Now,Subscription="Prime and Loinsgate"};

            //Anonymous Type
            //var type/keyword
            var CustomerOrder = new { CustomerName=primeCustomer.ContactName, LivingCity=primeCustomer.City, MySubscription=order.Subscription };
            
            
            BasicMath basicMath = new BasicMath();

            Console.WriteLine(Counter.IncrementCounter());
            Console.WriteLine(Counter.IncrementCounter());
            Console.WriteLine(Counter.IncrementCounter());

            //Type Inference - Upon initialization of var variable, C# compiler will decide the type and retain that type throughout the program
            //Var must be initialized and you can not use it as return value of a function and a parameter type of a function
            var i = 10F;
            

        }
    }
}
