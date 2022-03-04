using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rakic_Pizza.Models;

namespace Rakic_Pizza.Controllers
{
    public class FoodController : Controller
    {
        // GET: Essen/Random
        public ActionResult Random()
        {
            var food = new Food() { Name = "Hawai Pizza" };

            return View(food);
        }
    }
}