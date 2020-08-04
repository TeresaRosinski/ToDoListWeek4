using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoList.Controllers
{
public class ItemsController : Controller
{
//     private readonly ToDoListContext _db;

//     public ItemsController(ToDoListContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Item> model = _db.Items.Include(items => items.Category).ToList();
//       return View(model);
    

   public ActionResult Index()
    {
    return View(_db.Items.ToList());
    }
   public ActionResult Details(int id)
{
    var thisItem = _db.Items
        .Include(item => item.Categories)
        .ThenInclude(join => join.Category)
        .FirstOrDefault(item => item.ItemId == id);
    return View(thisItem);
} 
}
}