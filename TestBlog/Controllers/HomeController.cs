using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using TestBlog.Data;
using TestBlog.Models;
using TestBlog.ViewModels;

namespace TestBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogRepo _blogRepository;

        private readonly IHostingEnvironment hostingEnvironment;

        public HomeController(IBlogRepo blogRepository, IHostingEnvironment hostingEnvironment)
        {
            _blogRepository = blogRepository;

            this.hostingEnvironment = hostingEnvironment;
        }
        // GET: HomeController
        [HttpGet("/")]
        public ViewResult Index()
        {
            var NewsUpdate = _blogRepository.GetALLpost();
            return View(NewsUpdate);
        }

        // GET: HomeController
        [HttpGet("/Home/Details/")]

        public IActionResult Details(int Id)
        {
            var YourNews = _blogRepository.GetPost(Id);
            return View(YourNews);
        }

        // GET: HomeController/Create
        public ViewResult Create()
        {
            postViewModel PostVM = new postViewModel();
            return View("~/Views/Admin/CreatePost.cshtml", PostVM);
        }

        // POST: HomeController/Create
       [HttpPost]
        public ActionResult CreatePost(postViewModel model)
        {
            Post newpost = new Post();
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;

                if (model.Photo != null)
                {
                    string upload = hostingEnvironment.ContentRootPath;
                    var uploadsFolder = Path.Combine(upload, "wwwroot/images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }

                newpost.Headline = model.Headline;
                newpost.Date = DateTime.Now;
                newpost.Discription = model.Description;
                newpost.postWriteUp = model.postWriteUp;
                newpost.Photopath = uniqueFileName;
                var postToServe = _blogRepository.savePost(newpost);
                newpost = postToServe;
                newpost.PostId = postToServe.PostId;

                return RedirectToAction("Details", new { Id = "/" + (newpost.PostId) });
            }
            return View("~/Views/Admin/CreatePost.cshtml");
        }

        // GET: HomeController/Edit/5
        [HttpGet("/home/GetPostByDiscription/{description}")]
        public IActionResult GetPostByDiscription(int description)
        {
            var posts = _blogRepository.GetByDiscription((Category)description);
            return View("Index",posts);
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int Id)
        {
            _blogRepository.Deletepost(Id);
            return View();
        }
        [HttpPost]
        public IActionResult GetPostByHeadline(string HeadLine)
        {

             var TrimedHeadline = HeadLine.Trim();
            IEnumerable<Post> post = _blogRepository.GetPostByHeadline(TrimedHeadline);
            
            return View("Index", post);  
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
