using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management.Data;
using Student_Management.Model;

namespace Student_Management.Pages
{
    public class IndexModel : PageModel
    {
        AddDbContext db;
        public List<Student> student { get; set; }
        public IndexModel(AddDbContext _db)
        {
            db = _db;
        }
           

        public void OnGet()
        {
            student = db.tbl_addstudent.ToList();

        }
        public IActionResult OnGetDelete(int id)
        {
            var itemtodel = db.tbl_addstudent.Find(id);
            db.tbl_addstudent.Remove(itemtodel);
            db.SaveChanges();
            return RedirectToPage("Index");

        }
    }
}