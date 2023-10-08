using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Student_Management.Data;
using Student_Management.Model;

namespace Student_Management.Pages
{
    public class ShowStudentModel : PageModel
    {
        AddDbContext db;
        public Student student { get; set; }
        public ShowStudentModel(AddDbContext _db)
        {
            db = _db;
        }
        public void OnGet()
        {
           
        }
        public IActionResult OnPost(Student student)
        {
            db.tbl_addstudent.Add(student);
            db.SaveChanges();
            return RedirectToPage("index");

        }
    }
}
