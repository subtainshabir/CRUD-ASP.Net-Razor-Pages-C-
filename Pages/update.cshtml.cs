using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Management.Data;
using Student_Management.Model;

namespace Student_Management.Pages
{
    public class updateModel : PageModel
    {
        public Student  student { get; set; }
        AddDbContext db;

        public updateModel(AddDbContext _db)
        {
            db = _db; 
        }

        public void OnGet(int id)
        {
            var myrecord = db.tbl_addstudent.Find(id);
            student = myrecord;
        }
        public IActionResult OnPost(Student student)
        {
            db.tbl_addstudent.Update(student);
            db.SaveChanges();
            return RedirectToPage("Index");
            
        }
    }
}
