﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Register()
        {
            return View(new Movie());
        }
        public IActionResult Result(Movie movie)
        {
            if(ModelState.IsValid)
            {
                return View(movie);
            }
            else
            {
                return View(nameof(Register), movie);
            }
        }
    }
}
