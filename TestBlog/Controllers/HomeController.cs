using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
            var Post = GetAllpost();
            postDishOut Model = new postDishOut();
            Model.Allpost = Post;
            Model.Manypost = Post;
            var typcount = _blogRepository.TypeCount();
            Model.CatigoryTypeCount = typcount;
            return View(Model);
        }

        // GET: HomeController
        [HttpGet("/Home/Details/")]
        public IActionResult Details(int Id)
        {
            var post = _blogRepository.GetPost(Id);
            var postToUse = new RePost();
            postToUse.Date = post.Date;
            postToUse.Discription = post.Discription;
            postToUse.Headline = post.Headline;
            postToUse.Photopath = post.Photopath;
            postToUse.PostId = post.PostId;
            postToUse.postWriteUp = post.postWriteUp;
            var OurPost = _blogRepository.addLike(postToUse);
            var Post = _blogRepository.AddComent(OurPost);
            postDishOut Model = new postDishOut();
            Model.post = Post;
            var all = GetAllpost();
            Model.Allpost = all;
            var typcount = _blogRepository.TypeCount();
            Model.CatigoryTypeCount = typcount;
            return View(Model);
        }

        // GET: HomeController/Create
        [Authorize]
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

        [HttpGet("/home/GetPostByDiscription/{description}")]
        public IActionResult GetPostByDiscription(int description)
        {
            var posts = _blogRepository.GetByDiscription((Category)description);
            List<RePost> rePosts = new List<RePost>();
            foreach (var post in posts)
            {
                var postToUse = new RePost();
                postToUse.Date = post.Date;
                postToUse.Discription = post.Discription;
                postToUse.Headline = post.Headline;
                postToUse.Photopath = post.Photopath;
                postToUse.PostId = post.PostId;
                postToUse.postWriteUp = post.postWriteUp;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            postDishOut Model = new postDishOut();
            Model.Manypost = Post;
            var all = GetAllpost();
            var typcount = _blogRepository.TypeCount();
            Model.CatigoryTypeCount = typcount;
            Model.Allpost = all;
            return View("Index", Model);
        }

        // GET: HomeController/Delete/5
        [Authorize]
        public ActionResult Delete(int Id)
        {
            _blogRepository.Deletepost(Id);
            return View();
        }
        [HttpPost]
        public IActionResult GetPostByHeadline(string HeadLine)
        {

            var TrimedHeadline = HeadLine.Trim();
            IEnumerable<Post> posts = _blogRepository.GetPostByHeadline(TrimedHeadline);
            List<RePost> rePosts = new List<RePost>();
            foreach (var post in posts)
            {
                var postToUse = new RePost();
                postToUse.Date = post.Date;
                postToUse.Discription = post.Discription;
                postToUse.Headline = post.Headline;
                postToUse.Photopath = post.Photopath;
                postToUse.PostId = post.PostId;
                postToUse.postWriteUp = post.postWriteUp;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            postDishOut Model = new postDishOut();
            Model.Manypost = Post;
            var typcount = _blogRepository.TypeCount();
            Model.CatigoryTypeCount = typcount;
            var all = GetAllpost();
            Model.Allpost = all;
            return View("Index", Model);

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddComment(string Comment, int id,string Commenter)
        {
            var comment = new Comment()
            {
                PostId = id,
                comments = Comment,
                WhoCommented =Commenter
            };
            _blogRepository.SaveComent(comment);
            return RedirectToAction("index");
        }
        [Authorize]
        public IActionResult SaveLike(int id,string likedBy )
        {
            var Liked = _blogRepository.likedBefore(id, likedBy);
            if (Liked.Equals(false))
            {
                var likeTosave = new Like { Postid = id, WhoLiked = likedBy };
                _blogRepository.SaveLike(likeTosave);
                return RedirectToAction("index");
            }
            else
                _blogRepository.Removelike(id, likedBy);
            return RedirectToAction("Index");
       
        }
        public IEnumerable<RePost> GetAllpost()
        {
            List<RePost> rePosts = new List<RePost>();
            var NewsUpdate = _blogRepository.GetALLpost();
            foreach (var post in NewsUpdate)
            {
                var postToUse = new RePost();
                postToUse.Date = post.Date;
                postToUse.Discription = post.Discription;
                postToUse.Headline = post.Headline;
                postToUse.Photopath = post.Photopath;
                postToUse.PostId = post.PostId;
                postToUse.postWriteUp = post.postWriteUp;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            return Post;
        }
    }
}
