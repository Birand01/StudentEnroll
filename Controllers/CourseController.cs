using Microsoft.AspNetCore.Mvc;
using StudentEnroll.Models;

namespace StudentEnroll.Controllers
{
    public class CourseController:Controller
    {
        public IActionResult Index()
        {
            var model=Repository.Applications;
            return View(model);
            
        }
        public IActionResult Apply()
        {
            return View();
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm]Candidate model)
        {
            if(Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError(model.Email,"APPLICATION HAS ALREADY REGISTERED FOR THIS EMAIL");
            }
            if(ModelState.IsValid)
            {
                 Repository.Add(model);
                 return View("FeedBack",model);
            }
           
            return View();
        }
    }








}