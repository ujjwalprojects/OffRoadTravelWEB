using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourTravel_Web.Areas.Admin.Models
{
    public class utblMstTourCancellation
    {
        [Key]
        public long CancellationID { get; set; }
        public string CancellationDesc { get; set; }
    }
}