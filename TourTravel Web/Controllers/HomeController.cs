﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TourTravel_Web.Areas.Admin.CustomModels;
using TourTravel_Web.Areas.Admin.Models;
using TourTravel_Web.CustomModels;
using TourTravel_Web.Helpers;
using TourTravel_Web.ViewModels;

namespace TourTravel_Web.Controllers
{
    public class HomeController : Controller
    {
        ApiConnection objAPI = new ApiConnection("general");
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            IEnumerable<DestinationView> model = objAPI.GetAllRecords<DestinationView>("tourpackage", "destinations");
            var groupedDests = (from s in model group s by s.StateName).ToDictionary(x => x.Key, x => x.ToList());
            ViewBag.Dests = groupedDests;
            ViewBag.FootDest = objAPI.GetAllRecords<utblMstDestination>("clientenquiry", "alldestinations").Take(4);  

        }
        public ActionResult Index()
        {
            string query = "PageNo=1&PageSize=10&SearchTerm=";
            ViewBag.TourPackages = objAPI.GetRecordByQueryString<GenTourPackageVM>("tourpackage", "GenTourPackageList", query).PackageList;
            ViewBag.Destinations = objAPI.GetAllRecords<utblMstDestination>("clientenquiry", "alldestinations").Take(6);
            ViewBag.BannerList = objAPI.GetAllRecords<utblMstBanner>("tourpackage", "homebannerlist");
            string[] abc = objAPI.GetAllRecords<string>("tourpackage", "wherenames").ToArray();
            ViewBag.Where = abc;
            ViewBag.TourTypes = objAPI.GetAllRecords<utblMstPackageType>("tourpackage", "tourtypes");
            //ViewBag.PackagesTypeList = objAPI.GetRecordByQueryString<GenTourPackageVM>("tourpackage", "GenTourPackageDispList", query).PackageList;
            GenTourPackageVM obj = new GenTourPackageVM();
            obj.PackageList = objAPI.GetRecordByQueryString<GenTourPackageVM>("tourpackage", "GenTourPackageDispList", query).PackageList;
            var pType = (from s in obj.PackageList group s by s.PackageTypeName).ToDictionary(x => x.Key, x => x.ToList());
            ViewBag.PType = pType;

            //offer package list
            ViewBag.OfferPackage = objAPI.GetAllRecords<GenPackageOfferView>("tourpackage", "GenOfferPackagelist");
            ViewBag.TourGuides = objAPI.GetAllRecords<TourGuideListView>("tourpackage", "tourguides");
            return View();
        }

        public ActionResult About()
        {
          

            return View();
        }
        public ActionResult WhyUs()
        {


            return View();
        }

        public ActionResult WhyTouring()
        {
            return View();
        }
        public ActionResult TravelInsurance()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Error(int id = 0)
        {
            ViewBag.StatusCode = id;
            return View();
        }
        public ActionResult PageNotFound()
        {
            return View();
        }
    }
}