using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TourTravel_Web.Helpers;
using TourTravel_Web.Areas.Admin.Models;
namespace TourTravel_Web.Areas.Admin.CustomModels
{
    public class ItineraryView
    {
        public long ItineraryID { get; set; }
        public string ItineraryName { get; set; }
        public string ItineraryDesc { get; set; }
        public long OvernightDestinationID { get; set; }
    }


    public class ItineraryAPIVM
    {
        public IEnumerable<ItineraryView> ItinenaryList { get; set; }
        public int TotalRecords { get; set; }
    }
    public class ItineraryVM
    {
        public IEnumerable<ItineraryView> ItinenaryList { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }

    public class ItinerarySave
    {
        public utblMstitinerarie itinerarie { get; set; }
        public List<utblMstDestination> DestinationDD { get; set; }
    }
}