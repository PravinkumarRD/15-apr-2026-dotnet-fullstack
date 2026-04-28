using FirstWebAPIApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPIApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly List<Supplier> _suppliers;
    public SuppliersController()
    {
        _suppliers = new List<Supplier>()
        {
            //new Supplier(){SupplierId=1, Owner="John Doe", CompanyName="Doe Supplies", City="New York", Zipcode=10001},
            //new Supplier(){SupplierId=2, Owner="Jane Smith", CompanyName="Smith Goods", City="New York", Zipcode=90001},
            //new Supplier(){SupplierId=3, Owner="Bob Johnson", CompanyName="Johnson Products", City="Chicago", Zipcode=60601},
            //new Supplier(){SupplierId=4, Owner="Alice Brown", CompanyName="Brown Enterprises", City="Houston", Zipcode=77001},
            //new Supplier(){SupplierId=5, Owner="Charlie Davis", CompanyName="Davis Wholesale", City="Chicago", Zipcode=85001}
        };
    }

    //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Supplier>))]
    //[ProducesResponseType(StatusCodes.Status204NoContent)]
    //[HttpGet]
    //public IActionResult GetAllSuppliers()
    //{
    //    if (_suppliers.Count > 0)
    //    {
    //        return Ok(_suppliers);
    //    }
    //    else
    //    {
    //        return NoContent();
    //    }
    //}
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [HttpGet]
    public ActionResult<IEnumerable<Supplier>> GetAllSuppliers()
    {
        try
        {
            if (_suppliers.Count > 0)
            {
                return Ok(_suppliers);
            }
            else
            {
                return NoContent();
            }
        }
        catch (Exception)
        {
            return new ObjectResult(new { error = "Internal server error" })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
