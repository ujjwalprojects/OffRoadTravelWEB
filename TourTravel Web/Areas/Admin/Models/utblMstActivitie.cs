﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TourTravel_Web.Areas.Admin.Models
{
    public class utblMstActivitie
    {
        [Key]
        public long ActivityID { get; set; }
        public string ActivityName { get; set; }
        public string ActivityDesc { get; set; }
        public long DestinationID { get; set; }
        public decimal BaseFare { get; set; }
    }
}