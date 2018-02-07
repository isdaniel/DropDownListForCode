using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Models
{
    public class DropDownViewModel
    {
        [Display(Name = "Dealer")]
        public int? DealerIdRef { get; set; }

        public IEnumerable<SelectListItem> Ddllist { get; set; }
    }
}