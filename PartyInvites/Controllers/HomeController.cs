using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index(){
            return View();
        }

        //Including a RSVP form (GET Request):
        [HttpGet]
        public ViewResult RsvpForm(){
            return View();
        }



        //HTTP: POST Request
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse){
            //TODO: store response from guest
          
            //Checks to see if there is a validation error:
            if(ModelState.IsValid){
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else{
                return View();
            }
        }


        //Calls the View method useing Responses.Repository as argument
        public ViewResult ListResponses(){
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
