using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AdminLteMvcCore.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (User.Identity.IsAuthenticated)
            {
                if (RouteData.Values["action"].ToString().ToLower() == "login")
                {
                    filterContext.Result = new RedirectResult("~/");
                }
                if (filterContext.HttpContext.Request.Headers != null && filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                {
                    //AjaxRequest-true
                    ViewBag.Layout = null;
                    //  ViewBag.Layout = "~/Views/Shared/_AdminLayout.cshtml";
                }
                else
                {
                    //AjaxRequest-false
                    //    ViewBag.Layout = "~/Views/Shared/_AdminLayout.cshtml";
                    ViewBag.Layout = "~/Views/Shared/_Layout.cshtml";
                }
            }
            else
            {
                if (RouteData.Values["action"].ToString().ToLower() != "login")
                {
                    filterContext.Result = new RedirectResult("~/Account/Login");
                }
            }
        }

    }
}