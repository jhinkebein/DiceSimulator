using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDiceSimulator.Models;

namespace WebDiceSimulator.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Total = 0;
            return View();
        }
        [HttpPost]
        public ActionResult Index(RollDice roll)
        {

            if (ModelState.IsValid)
            {
                string[] rolls = new string[2];
                rolls = roll.rollDice();

                ViewBag.Die1 = rolls[0];
                ViewBag.Die2 = rolls[1];
                
            }
            else
            {
                ViewBag.Total = 0;
            }

            return View();
        }
    }
}