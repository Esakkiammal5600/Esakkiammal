using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZOI.APP.Models;

namespace ZOI.APP.Controllers
{
    public class CourseRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CoursePhase1()
        {
            return View();
        }

        public IActionResult AddMultipleCourse()
        {
            return PartialView("_addMultipleCourseBlock");
        }

        [HttpGet]
        public JsonResult GetDetails(CoursePhase1 coursePhase)
        {
 
               if(ModelState.IsValid)
            {
                return Json("");

            }
            else
            {
                return Json(coursePhase);

            }
          
        }
    }
}