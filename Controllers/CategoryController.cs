using testMvcApp.Data;
using testMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
namespace testMvcApp.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _db;

    public CategoryController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        IEnumerable<Category> objCategoryList = _db.Categories;
        return View(objCategoryList);
    }

    public IActionResult CreateCategory()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateCategory(Category obj)
    {
        if (obj.username == obj.DisplayOrder.ToString())
        {
            ModelState.AddModelError("CustomError", "Username cannot be the same as DisplayOrder");
        }
        if (ModelState.IsValid)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }


}