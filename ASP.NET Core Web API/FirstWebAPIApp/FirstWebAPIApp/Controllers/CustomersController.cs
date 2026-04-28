using FirstWebAPIApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPIApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly List<Customer> _customers;
        public CustomersController()
        {
            _customers = new List<Customer>()
            {
                //new Customer() { CustomerId=1,ContactName="John Doe",City="New York" },
                //new Customer() { CustomerId=2,ContactName="Jane Smith",City="New York" },
                //new Customer() { CustomerId=3,ContactName="Michael Johnson",City="Chicago" },
                //new Customer() { CustomerId=4,ContactName="Emily Davis",City="Houston" },
                //new Customer() { CustomerId=5,ContactName="William Brown",City="Chicago" }
            };
        }
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "Customer1", "Customer2", "Customer3", "Customer4", "Customer5" };
        //}
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }
        [HttpGet("{city:alpha}")]
        public IEnumerable<Customer> Get(string city)
        {
            return _customers.Where(c => c.City == city);
        }
        [HttpGet("{id:int}/{city:alpha}")]
        public IEnumerable<Customer> Get(int id, string city)
        {
            return _customers.Where(c => c.CustomerId == id && c.City == city);
        }
    }
}
