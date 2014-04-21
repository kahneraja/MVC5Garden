using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Garden.Controllers
{
    // [Authorize] Rejects anonymous identity.
    // [Authorize(Users = "KahneRaja")]
    // [Authorize(Roles = "admin, sales")]

    /// <summary>
    /// Cookies.
    /// By default this identity information is being tracked with Cookies. The browser is capturing the required authentication details in the cookie and passing it along with each request.
    /// </summary>

    public class SecretController : Controller
    {
        /// <summary>
        /// Private
        /// http://localhost:54795/Secret/Get
        /// </summary>
        /// <returns></returns>
        
        //  [Authorize] // Restricted access.
        public ContentResult Get()
        {
            return Content("This is private...");
        }

        /// <summary>
        /// Public
        /// http://localhost:54795/Secret/Overt
        /// </summary>
        /// <returns></returns>

        [AllowAnonymous] // Override the class level authorisation attribute.
        public ContentResult Overt()
        {
            return Content("This is public...");
        }
	}
}