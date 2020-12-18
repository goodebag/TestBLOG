using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TestBlog.Data;
using TestBlog.Models;
using TestBlog.Models.CoinMarketCap;
using TestBlog.ViewModels;

namespace TestBlog.Controllers
{
    public class UserController:Controller
    {
        private readonly UserManager<myIdentityUser> _userManager;
        private readonly SignInManager<myIdentityUser> _signInManager;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IBlogRepo _blogRepository;

        public UserController(UserManager<myIdentityUser> userManager, SignInManager<myIdentityUser> signInManager, IHostingEnvironment
            hostingEnvironment, IBlogRepo blogRepository)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            this.hostingEnvironment = hostingEnvironment;
            this._blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> UserSignUP()
        {

            ViewBag.FormTitle = "User SignUp Page";
            var Post = GetAllpost();
            var typcount = _blogRepository.TypeCount();
            ViewBag.Allpost = (IEnumerable<RePost>)Post;
            ViewBag.CatigoryTypeCount = typcount;
            // loading coins to layout
            var Crypto = await returnCoinToLayout();
            ViewBag.Crypto = Crypto;
            return View("~/Views/Admin/AdminSignUP.cshtml");
        }
        public async Task<IEnumerable<CryptoMarketResponse>> returnCoinToLayout()
        {
            CoinProcessor processorR = new CoinProcessor();
            var coinAndPrices = await processorR.LoadCoins();
            var Crypto = (IEnumerable<CryptoMarketResponse>)coinAndPrices;
            return Crypto;
        }

        [HttpPost]
        public async Task<IActionResult> UserSignUP(AdminViewModel model)
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
                // Copy data from RegisterViewModel to IdentityUser
                var user = new myIdentityUser
                {
                    Photophath = uniqueFileName,
                    Fullname = (model.LastName + " " + model.FirstName),
                    UserName = model.UserName,
                    Email = model.Email.Trim(),
                    GetUserType = UserType.User,
                    customid = model.LastName + "-" + model.FirstName + "_"
                }; 

                // Store user data in AspNetUsers database table
                var result = await _userManager.CreateAsync(user, model.Password.Trim());

                //  If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "home");
                }

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError(string.Empty, error.Description);
                //}

            

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UserLogIn()
        {

            ViewBag.FormTitle = "User Login Page";
            var Post = GetAllpost();
            var typcount = _blogRepository.TypeCount();
            ViewBag.Allpost = (IEnumerable<RePost>)Post;
            ViewBag.CatigoryTypeCount = typcount;
            // loading coins to layout
            var Crypto = await returnCoinToLayout();
            ViewBag.Crypto = Crypto;
            return View("~/Views/Admin/AdminLogIn.cshtml");
        }
        [HttpPost]
        public async Task<IActionResult> UserLogIn(LogInViewModel model)
        {

                var result = await _signInManager.PasswordSignInAsync(
                    model.Email.Trim(), model.Password.Trim(), model.RemenberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            

            return View("~/Views/Admin/AdminLogIn.cshtml", model);
        }

        public async Task<IActionResult> LogOutAdmin()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
