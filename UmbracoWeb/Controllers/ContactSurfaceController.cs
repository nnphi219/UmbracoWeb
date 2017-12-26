using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using UmbracoWeb.Models;

namespace UmbracoWeb.Controllers
{
    public class ContactSurfaceController : SurfaceController
    {
        public ActionResult ShowForm()
        {
            ContactViewModel model = new ContactViewModel();
            return PartialView("ContactForm", model);
        }

        public ActionResult HandleFormPost(ContactViewModel model)
        {
            return RedirectToCurrentUmbracoPage();
        }
    }
}