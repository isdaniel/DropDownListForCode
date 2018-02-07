﻿using Sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            DropDownViewModel model = new DropDownViewModel()
            {
                Ddllist = GetDDL(),
                DealerIdRef = 1
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult ShowDDL(DropDownViewModel viewModel)
        {
            return View(viewModel);
        }

        private IEnumerable<SelectListItem> GetDDL()
        {
            return new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Text = "One",
                    Value = "1"
                },
                new SelectListItem()
                {
                    Text = "Two",
                    Value = "2"
                }
            };
        }
    }
}