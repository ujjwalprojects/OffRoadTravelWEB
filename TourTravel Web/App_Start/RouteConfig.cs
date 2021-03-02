﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TourTravel_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              "TourPackage",
              "tourpackage/{name}",
              new { controller = "gentourpackage", action = "tourpackagedetails", name = UrlParameter.Optional },
              namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
             "CustomTourPackage",
             "customtourpackage/{name}",
             new { controller = "gentourpackage", action = "clientdetail", name = UrlParameter.Optional },
             namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
            "CustomTourPackages",
            "customtourpackages/{ec}",
            new { controller = "gentourpackage", action = "clientdetails", ec = UrlParameter.Optional },
            namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
             "CustomTtineraries",
             "customitineraries/{ec}",
             new { controller = "gentourpackage", action = "itinerarydetail", ec = UrlParameter.Optional },
             namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
           "CustomActivities",
           "customactivities/{ec}",
           new { controller = "gentourpackage", action = "AdvActivityDetail", ec = UrlParameter.Optional },
           namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
              "CustomPackageSummary",
              "custompackagesummary/{ec}",
              new { controller = "gentourpackage", action = "ClientPackageSummary", ec = UrlParameter.Optional },
              namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
              "DestinationPackage",
              "destinationpackage/{id}",
              new { controller = "gentourpackage", action = "destinationpackage", ec = UrlParameter.Optional },
              namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
           "PackageOffer",
           "PackageOffer/{po}",
            new { controller = "gentourpackage", action = "PackageOfferDetails", po = UrlParameter.Optional },
            namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            routes.MapRoute(
            "Submission",
            "Submission/{result}",
            new { controller = "gentourpackage", action = "SubmissionPage", ec = UrlParameter.Optional },
            namespaces: new[] { "TourTravel.Web.Controllers" }
            );
            //routes.MapRoute(
            //name: "Default",
            //url: "{controller}/{action}/{id}",
            //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            routes.MapRoute(
           "TourGuide",
           "tourguide/{link}",
            new { controller = "gentourpackage", action = "TourGuideDetails", link = UrlParameter.Optional },
            namespaces: new[] { "TourTravel.Web.Controllers" }
            );

            //routes.MapRoute(
            //"Submission",
            //"Submission/{result}",
            //new { controller = "gentourpackage", action = "SubmissionPage", ec = UrlParameter.Optional },
            //namespaces: new[] { "TourTravel.Web.Controllers" }
            //);
            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
