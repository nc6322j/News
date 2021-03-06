using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using News.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Claims;
using News.Entities;

namespace News.Controllers.Staff
{
    public class IdeaManagementController : Controller
    {
        private ApplicationDbContext _context;
        public IdeaManagementController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: StaffController
        [Route("ideamanagement")]
        public ActionResult Index()
        {
            var query = _context.Idea;
            return View(query);
        }

        // GET: StaffController/Details/5
        [Route("ideamanagement/details")]
        [HttpGet]
        public ActionResult Details(string id)
        {
            var query = _context.Idea.Find(id);
            return View(query);
        }
        public string Country { get; set; }
        // GET: StaffController/Create
        [Route("ideamanagement/create")]
        public ActionResult Create()
        {
            //Query Categories 
            var categoriesQuery = _context.Categories;

            List<SelectListItem> CategoryList = new List<SelectListItem>();
            foreach (var category in categoriesQuery)
            {
                var itemCategory = new SelectListItem { Value = category.category_Id, Text = category.category_Name };
                CategoryList.Add(itemCategory);
            }
            ViewBag.idea_CategoryId = CategoryList;

            //Query Academic Year 
            var academicYearQuery = _context.AcademicYear;

            List<SelectListItem> AcademicYearList = new List<SelectListItem>();
            foreach (var academic in academicYearQuery)
            {
                var itemAcademic = new SelectListItem { Value = academic.academicYear_Id, Text = academic.academicYear_Name };
                AcademicYearList.Add(itemAcademic);
            }
            ViewBag.idea_AcademicYearId = AcademicYearList;

            // Get Id and Name of User
            //var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //var userName = User.FindFirstValue(ClaimTypes.Name);

            //List<SelectListItem> UserList = new List<SelectListItem>();
            //var itemUser = new SelectListItem { Value = userId, Text = userName };
            //UserList.Add(itemUser);
            //ViewBag.idea_UserId = UserList;


            return View();
        }

        // POST: StaffController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Edit/5
        [Route("ideamanagement/edit")]
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var queryIdea = _context.Idea.Find(id);

            //Query Categories 
            var queryCategories = _context.Categories.Find(queryIdea.idea_CategoryId);
            List<SelectListItem> CategoriesList = new List<SelectListItem>();
            var itemCategories = new SelectListItem { Value = queryCategories.category_Id, Text = queryCategories.category_Name };
            CategoriesList.Add(itemCategories);

            ViewBag.idea_CategoryId = CategoriesList;

            //Query AcademicYear
            var queryAcademicYear = _context.AcademicYear.Find(queryIdea.idea_AcademicYearId);
            List<SelectListItem> AcademicYearList = new List<SelectListItem>();
            var itemAcademicYear = new SelectListItem { Value = queryAcademicYear.academicYear_Id, Text = queryAcademicYear.academicYear_Name };
            AcademicYearList.Add(itemAcademicYear);

            ViewBag.idea_AcademicYearId = AcademicYearList;


            // Get Id and Name of User
            var queryUser = _context.AppUser.Find(queryIdea.idea_UserId);

            List<SelectListItem> UserList = new List<SelectListItem>();
            var itemUser = new SelectListItem { Value = queryUser.Id, Text = queryUser.UserName };
            UserList.Add(itemUser);
            ViewBag.idea_UserId = UserList;

            return View(queryIdea);
        }

        // POST: StaffController/Edit/5
        [Route("ideamanagement/edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, Idea idea)
        {
            try
            {
                var query = _context.Idea.Find(id);
                query.idea_Title = idea.idea_Title;
                query.idea_Description = idea.idea_Description;
                query.idea_UpdateTime = idea.idea_UpdateTime;
                query.idea_CategoryId = idea.idea_CategoryId;
                query.idea_AcademicYearId = idea.idea_AcademicYearId;
                query.idea_UserId = idea.idea_UserId;

                _context.Idea.Add(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StaffController/Delete/5
        [Route("ideamanagement/delete")]
        [HttpGet]
        public ActionResult Delete(string id)
        {
            var query = _context.Idea.Find(id);
            return View(query);
        }

        // POST: StaffController/Delete/5
        [Route("ideamanagement/delete")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                var query = _context.Idea.Find(id);
                _context.Idea.Remove(query);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
