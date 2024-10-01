using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDemo.Data;
using RazorDemo.Models;

namespace RazorDemo.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Category Category { get; set; }

        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet(int? id)
        {
            if(id!= null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
        }

        public IActionResult OnPost()
        {
            Category? obj = _db.Categories.Find(Category.Id);
            if(obj == null)
            {
                return NotFound();      
            } 

            _db.Categories.Remove(obj);

            TempData["success"] = "Category deleted successfully";

            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
