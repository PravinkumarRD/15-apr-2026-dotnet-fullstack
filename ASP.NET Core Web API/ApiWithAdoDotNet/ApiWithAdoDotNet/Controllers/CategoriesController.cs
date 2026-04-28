using ApiWithAdoDotNet.Dal;
using ApiWithAdoDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithAdoDotNet.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly CategoryDal _catDal;

    public CategoriesController(CategoryDal catDal)
    {
        _catDal = catDal;
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [HttpGet]
    public ActionResult<List<Category>> Get()
    {
        var categories = _catDal.GetAllCategories();
        if (categories == null || categories.Count == 0)
        {
            return NoContent();
        }
        return Ok(categories);
    }
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [HttpGet("{id:int}")]
    public ActionResult<Category> Get(int id)
    {
        var category = _catDal.GetCategoryDetails(id);
        if (category == null)
        {
            return NoContent();
        }
        return Ok(category);
    }
}
