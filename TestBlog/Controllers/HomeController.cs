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
using TestBlog.Models.CoinMarketCap;
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
        public async Task<ViewResult> Index()
        {
            var Post = GetAllpost();
            if (Post == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMessage = "Sorry we couldn't reach the server at this point";
                return View("NotFound");
            }
            postDishOut Model = new postDishOut();
            Model.Manypost = Post;
            var typcount = _blogRepository.TypeCount();
              ViewBag.Allpost = (IEnumerable<RePost>)Post;
             ViewBag.CatigoryTypeCount = typcount;
            // loading coins to layout   
            var Crypto = await returnCoinToLayout();
            if (Crypto == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMessage = "No network access (Please make your Internet is on)";
                return View("NotFound");
            }

            ViewBag.Crypto = Crypto;
            return View(Model);
        }

        // GET: HomeController
        [HttpGet("/Home/Details/")]
        public async Task<IActionResult> Details(int Id)
        {
            var post = _blogRepository.GetPost(Id);
            if (post== null)
            {
                Response.StatusCode = 404; 
                ViewBag.ErrorMessage = "Sorry the news you looking for doesn't exist";
                return View("NotFound");
            }
            var postToUse = new RePost();
            postToUse.Date = post.Date;
            postToUse.Discription = post.Discription;
            postToUse.Headline = post.Headline;
            postToUse.Photopath = post.Photopath;
            postToUse.PostId = post.PostId;
            postToUse.PosterName = post.WhoPosted;
            postToUse.PostersPhotopath = post.PosterPhotopath;
            postToUse.postWriteUp = post.postWriteUp;
            var OurPost = _blogRepository.addLike(postToUse);
            var Post = _blogRepository.AddComent(OurPost);
            postDishOut Model = new postDishOut();
            Model.post = Post;
            var all = GetAllpost();
            ViewBag.Allpost = (IEnumerable<RePost>)all;
            var typcount = _blogRepository.TypeCount();
           ViewBag.CatigoryTypeCount = (PostTypeCount)typcount;
            var Crypto = await returnCoinToLayout();
            ViewBag.Crypto = Crypto;
            return View(Model);
        }

        // GET: HomeController/Create
        [Authorize]
        public async Task<ViewResult> Create()
        {
            var all = GetAllpost();
            ViewBag.Allpost = (IEnumerable<RePost>)all;
            var typcount = _blogRepository.TypeCount();
            ViewBag.CatigoryTypeCount = (PostTypeCount)typcount;
            //var Crypto = await returnCoinToLayout();
            //ViewBag.Crypto = Crypto;
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
                newpost.Date = model.Date;
                newpost.WhoPosted = model.whoIsPosting;
                newpost.PosterPhotopath = model.Photopath;
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
        public async Task<IActionResult> GetPostByDiscription(int description)
        {
            var posts = _blogRepository.GetByDiscription((Category)description);
            if (posts == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMessage = "Sorry there's no news yet on the searched category";
                return View("NotFound");
            }
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
                postToUse.PosterName = post.WhoPosted;
                postToUse.PostersPhotopath = post.PosterPhotopath;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            postDishOut Model = new postDishOut();
            Model.Manypost = Post;
            var all = GetAllpost();
            ViewBag.Allpost = (IEnumerable<RePost>)all;
            var typcount = _blogRepository.TypeCount();
            ViewBag.CatigoryTypeCount = (PostTypeCount)typcount;
            //var Crypto = await returnCoinToLayout();
            //ViewBag.Crypto = Crypto;
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
        public async Task<IActionResult> GetPostByHeadline(string HeadLine)
        {

            var TrimedHeadline = HeadLine.Trim();
            IEnumerable<Post> posts = _blogRepository.GetPostByHeadline(TrimedHeadline);
            if (posts == null)
            {
                Response.StatusCode = 404;
                ViewBag.ErrorMessage = "Sorry no news that matched searched terms";
                return View("NotFound");
            }
            List<RePost> rePosts = new List<RePost>();
            foreach (var post in posts)
            {
                var postToUse = new RePost();
                postToUse.Date = post.Date;
                postToUse.Discription = post.Discription;
                postToUse.Headline = post.Headline;
                postToUse.Photopath = post.Photopath;
                postToUse.PosterName = post.WhoPosted;
                postToUse.PostersPhotopath = post.PosterPhotopath;
                postToUse.PostId = post.PostId;
                postToUse.postWriteUp = post.postWriteUp;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            postDishOut Model = new postDishOut();
            Model.Manypost = Post;
            var all = GetAllpost();
            ViewBag.Allpost = (IEnumerable<RePost>)all;
            var typcount = _blogRepository.TypeCount();
            ViewBag.CatigoryTypeCount = (PostTypeCount)typcount;
            //var Crypto = await returnCoinToLayout();
            //ViewBag.Crypto = Crypto;
            return View("Index", Model);

        }


        [Route("/Home/Error/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry The Route does not Exit";
                    break;
                case 500:
                    ViewBag.ErrorMessage = "Sorry server could not reached";
                    break;

            }
           
            return View("NotFound");
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddComment(string Comment, int id,string Commenter,string CommenterPhoto)
        {
            var comment = new Comment()
            {
                PostId = id,
                comments = Comment,
                WhoCommented =Commenter,
                CommenterSphotopath =CommenterPhoto,
                DateAndtime = DateTime.Now
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
                var likeTosave = new Like { Postid = id, WhoLiked = likedBy};
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
                postToUse.PosterName = post.WhoPosted;
                postToUse.PostersPhotopath = post.PosterPhotopath;
                postToUse.PostId = post.PostId;
                postToUse.postWriteUp = post.postWriteUp;
                rePosts.Add(postToUse);
            }
            var OurPost = _blogRepository.addLikes(rePosts);
            var Post = _blogRepository.AddComents(OurPost);
            return Post;
        }
        public async Task<IEnumerable<CryptoMarketResponse>> returnCoinToLayout()
        {
            CoinProcessor processorR = new CoinProcessor();
            var coinAndPrices = await processorR.LoadCoins();
          var Crypto = (IEnumerable<CryptoMarketResponse>)coinAndPrices;
            return Crypto;
        }
        public PartialViewResult signUpForEmailNotification()
        {
            return PartialView();
        }
        [HttpGet("/Home/signUpForEmailNotification/")]
        public  void signUpForEmailNotification(EmailNotification model)
        {
            ViewBag.ThanksStatment = _blogRepository.AddEmail(model);
        }
    }
}
