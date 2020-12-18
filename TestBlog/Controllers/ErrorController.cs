using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlog.Controllers
{
    public class ErrorController:Controller
    {
        [Route("Error")]
        public ActionResult Errorhandler()
        {
            var ErrorDetails = HttpContext.Features.Get<IExceptionHandlerFeature>();
           
            if (ErrorDetails.Error.Message.Equals("No such host is known"))
            {
                ViewBag.ErrorMessage = "Sorry Turn on your Internet and Hit the \"Back to Index\" button";
            }
            else if (ErrorDetails.Error.Message.Equals(404))
            {
                ViewBag.ErrorMessage = "Sorry The Route does not Exit";
            }
            else 
            {
                ViewBag.ErrorMessage = "Sorry server could not reached";
            }
             return View("NotFound");
        }
    }
}
