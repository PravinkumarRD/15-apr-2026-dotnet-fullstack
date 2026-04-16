namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bajaj Customers List!");
            //Customer customer = new Customer() { CustomerId = 1, ContactName = "Test", City = "Test" };
            /*foreach (Customer customer in GetAllCustomers())
            {
                Console.WriteLine($"Customer Id {customer.CustomerId} with name {customer.ContactName} lives in city {customer.City}!");
            }
            Console.WriteLine($"\n Bajaj Orders List!");
            foreach (Order order in GetAllOrders())
            {
                Console.WriteLine($"Order Id {order.OrderId}, Order Date {order.OrderDate}, Quantity {order.Quantity} and customer Id {order.CustomerId}!");
            }*/
            //List<CityWiseCustomers> cityWiseCustomers = new List<CityWiseCustomers>();
            //foreach (Customer customer in GetAllCustomers())
            //{
            //    CityWiseCustomers existingCity=cityWiseCustomers.Find(delegate (CityWiseCustomers c) { return c.City == customer.City; });
            //    if (existingCity != null) {
            //        existingCity.Count++;
            //    }
            //    else
            //    {
            //        CityWiseCustomers cwc = new CityWiseCustomers();
            //        cwc.City = customer.City;
            //        cwc.Count = 1;
            //        cityWiseCustomers.Add(cwc);
            //    }
            //}
            //Lambda Expressions
            //LINQ
            //var cityWiseCustomers = from customer in GetAllCustomers()
            //                        group customer by customer.City into result
            //                        select new { City = result.Key, Count = result.Count() };
            //foreach (var finalResult in cityWiseCustomers)
            //{
            //    Console.WriteLine($"In city {finalResult.City}, there is/are {finalResult.Count} number of customers!");
            //}
            //var CustomerOrders = from customer in GetAllCustomers()
            //                     join
            //                     order in GetAllOrders()
            //                     on customer.CustomerId equals order.CustomerId
            //                     //where customer.City=="Mumbai"
            //                     select new { CustomerName=customer.ContactName, City=customer.City, Oid=order.OrderId, Qty=order.Quantity };
            //foreach (var co in CustomerOrders)
            //{
            //    Console.WriteLine($"Customer {co.CustomerName} from city {co.City} has order number {co.Oid} with quantity {co.Qty}!");
            //}
            var Customers = GetAllCustomers().Where(c => c.City.Contains("u")).OrderByDescending(c=>c.ContactName);
            var CityWiseCustomers=GetAllCustomers().GroupBy(key=>key.City).ToList();
            Console.WriteLine(CityWiseCustomers.Count);
            foreach (var customer in Customers)
            {
                Console.WriteLine($"Customer Id {customer.CustomerId} with name {customer.ContactName} lives in city {customer.City}!");
            }
        }
        private static List<Customer> GetAllCustomers()
        {
            //Collection Initializer
            return new List<Customer>()
            {
                new Customer(){ CustomerId = 1000, ContactName = "Pravinkumar R. D.", City = "Pune"},
                new Customer(){ CustomerId = 1001, ContactName = "Alisha C.", City = "Mumbai"},
                new Customer(){ CustomerId = 1002, ContactName = "Manish Sharma", City = "Mumbai"},
                new Customer(){ CustomerId = 1003, ContactName = "Pratap Sing", City = "Bangalore"},
                new Customer(){ CustomerId = 1004, ContactName = "Manish Kaushik", City = "Bangalore"},
            };
        }
        private static List<Order> GetAllOrders()
        {
            return new List<Order>()
            {
                new Order(){OrderId=1,CustomerId=1000,OrderDate=DateTime.Now,Quantity=10},
                new Order(){OrderId=2,CustomerId=1000,OrderDate=DateTime.Now,Quantity=20},
                new Order(){OrderId=3,CustomerId=1002,OrderDate=DateTime.Now,Quantity=22},
                new Order(){OrderId=4,CustomerId=1002,OrderDate=DateTime.Now,Quantity=12},
                new Order(){OrderId=5,CustomerId=1004,OrderDate=DateTime.Now,Quantity=78}
            };
        }
    }
}
