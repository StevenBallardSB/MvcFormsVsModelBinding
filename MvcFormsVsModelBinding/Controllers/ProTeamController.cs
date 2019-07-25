using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcFormsVsModelBinding.Models;

namespace MvcFormsVsModelBinding.Controllers
{
    public class ProTeamController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        //When data is posted to /ProTeam/Register
        //this action will execute
        // Add error messages on page to notify user

        [HttpPost]
        public IActionResult Register(IFormCollection data)
        {
            //Validate input
            //Server-side and client-side

            ProTeam pro = new ProTeam()
            {
                NameOfTeam = data["name-of-team"],
                NameOfCoach = data["name-of-coach"],
                Country = data["contry"],
                Sport = data["sport"],
                DateFounded = Convert.ToDateTime(data["dof"])
            };

            //Add to database
            return View();
        }

        //Registration done with model binding
        [HttpGet]
        public IActionResult RegisterMB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterMB(ProTeam p)
        {
            // This verifies all data annotation in the class are valid
            if (ModelState.IsValid)
            {
                // Add to database
                ProTeamDB.Register(p);
                // Display success message
                ViewData["Success"] = "Pro Team was successfully registered";
            }

            return View();
        }
    }
    
}