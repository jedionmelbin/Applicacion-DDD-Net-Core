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
    public class CourseController : Controller
    {
        private ICourseService courseService;
        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        // GET: Course
        public ActionResult Index()
        {
            IEnumerable<CourseDTO> list = courseService.GetAll();

            return View(list);
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Course/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Course/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CourseDTO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   await courseService.Insert(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }

        // GET: Course/Edit/5
        public ActionResult Edit(int id)
        {
            CourseDTO courseDTO = courseService.GetById(id);

            return View(courseDTO);
        }

        // POST: Course/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, CourseDTO collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                  await  courseService.Update(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Course/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Course/Delete/5
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