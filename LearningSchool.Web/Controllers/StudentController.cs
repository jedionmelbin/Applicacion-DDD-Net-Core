using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningSchool.Service;
using LearningSchool.Transport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningSchool.Web.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService studentService;

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ListStudent()
        {
            try
            {
                IEnumerable<StudentDTO> sudents = studentService.GetAll();
                var jsonData = new
                {
                    draw = 1,
                    recordsTotal = 10,
                    recordsFiltered = 50,
                    data = from f in sudents.AsEnumerable()
                           select new
                           {
                               f.ID,
                               f.FirstMidName,
                               f.LastName
                           }

                };
                return Json(jsonData);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(StudentDTO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   await studentService.Insert(collection);
                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}