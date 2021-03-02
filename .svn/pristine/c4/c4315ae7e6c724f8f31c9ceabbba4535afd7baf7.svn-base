using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourTravel_Web.Areas.Admin.Models
{
    public class utblMstCabType
    {
        public long CabTypeID { get; set; }
        [Required(ErrorMessage = "Enter Cab Type Name")]
        [Display(Name = "Cab Type")]
        public string CabTypeName { get; set; }
        [Display(Name = "Cab Type Description")]
        public string CabTypeDesc { get; set; }
        [Required(ErrorMessage = "Enter Base Fare")]
        [Display(Name = "Base Fare")]
        public decimal BaseFare { get; set; }
    }
}