﻿using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TourTravel_Web.Models;

namespace TourTravel_Web.Controllers
{
    public class BaseController : Controller
    {
        protected SessionModel _sModel;

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _sModel = Session["SessionVar"] as SessionModel;

            if (_sModel == null)
            {
                HttpContext.GetOwinContext().Authentication.SignOut();

                TempData["ErrMsg"] = "Your login session has expired. Please login again to continue.";
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "account",
                    action = "login",
                    area = ""
                }));
            }
            else
            {
                ViewBag.CurrentUserName = _sModel.UserName;
                ViewBag.Role = _sModel.Role;

                if (_sModel.UserImage != "")
                {
                    ViewBag.UserImageSrc = _sModel.UserImage;
                }
            }
                    
        }
	}
}