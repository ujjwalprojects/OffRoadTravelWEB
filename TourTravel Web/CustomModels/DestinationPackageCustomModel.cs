using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourTravel_Web.Areas.Admin.Models;
using TourTravel_Web.Helpers;
using TourTravel_Web.Models;

namespace TourTravel_Web.CustomModels
{
    public class GenDestinationVM
    {
        public utblMstDestination GenDestination { get; set; }
        public IEnumerable<GenTourPackageView> PackageList { get; set; }
        public GenTourPackageDtlView GenTourPackageDtlView { get; set; }
        public utblClientEnquirie ClientEnquiry { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}