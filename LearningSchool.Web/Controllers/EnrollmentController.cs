using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningSchool.Service;
using LearningSchool.Transport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningSchool.Web.Controllers
{
    public class EnrollmentController : Controller
    {
        private IEnrollmentService enrollmentService;
        private IStudentService studentService;
        private ICourseService courseService;
        public EnrollmentController(IEnrollmentService enrollmentService,
            IStudentService studentService, ICourseService courseService)
        {
            this.enrollmentService = enrollmentService;
            this.studentService = studentService;
            this.courseService = courseService;
        }
        // GET: Enrollment
        public ActionResult Index()
        {
            IEnumerable<EnrollmentDTO> list = new List<EnrollmentDTO>();
            list = enrollmentService.ListEnrollment();
            return View(list);
        }

        // GET: Enrollment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Enrollment/Create
        public ActionResult Create()
        {
            EnrollmentDTO enrollment = new EnrollmentDTO();
            enrollment.listStudent = studentService.GetAll().Select(x => new SelectListItem()
            {
                Value = x.ID.ToString(),
                Text = x.FirstMidName
            }).ToList();

            enrollment.listCourse = courseService.GetAll().Select(x => new SelectListItem()
            {
                Value = x.CourseID.ToString(),
                Text = x.Title
            }).ToList();

            return View(enrollment);
        }

        // POST: Enrollment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EnrollmentDTO collection)
        {
            try
            {
                if (collection != null)
                {
                    await enrollmentService.Insert(collection);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // GET: Enrollment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enrollment/Edit/5
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

        // GET: Enrollment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enrollment/Delete/5
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