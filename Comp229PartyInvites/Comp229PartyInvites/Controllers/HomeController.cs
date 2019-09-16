using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Comp229PartyInvites.Models;

namespace Comp229PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {

            int hour = DateTime.Now.Hour;
            ViewBag.greeting = hour < 12 ? "Good Morning" : "Good afternoon";
            return View("MyView");
        }
        [HttpGet]
    public ViewResult RsvpForm()
        {
            return View("Rsvp");
        }
        [HttpPost]

        public ViewResult RsvpForm(GuestResponse guestResponse )
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View("Rsvp");
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r=>r.WillAttend==true));
        }
    }
}