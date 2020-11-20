using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Skillz.Models;

namespace Project.Skillz.Controllers
{
    public class InterviewController : Controller
    {
        public static List<Interview> interviews = new List<Interview>();
        // GET: Interview
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Table()
        {
            
            return View(interviews);
        }
        
        public ActionResult Create()
        {
            Interview temp1 = new Interview();
            return View(temp1);

        }
        [HttpPost]
        public ActionResult Create(Interview interview)
        {
            if (ModelState.IsValid)
            {
                interview.id = interviews.Count() + 1;
                interviews.Add(interview);
                return RedirectToAction("Table");
            }
            return RedirectToAction("Table");
        }
    }
}