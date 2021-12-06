using Entro.DataDbContext;
using Entro.Models;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataDb _datadb;
        public HomeController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            ViewBag.Controller = "Home";

            HomeModel homeModels = new HomeModel();

            About about = _datadb.Abouts.FirstOrDefault();
            Concert concert = _datadb.Concerts.FirstOrDefault();
            Setting setting = _datadb.Settings.FirstOrDefault();
            List<Social> socials = _datadb.Socials.ToList();
            List<Gallery> galleries = _datadb.Galleries.Include(o=>o.Images).ToList();
            Slider slider = _datadb.Sliders.FirstOrDefault();

            homeModels.Concert = concert;
            homeModels.Galleries = galleries;
            homeModels.Setting = setting;
            homeModels.Slider = slider;
            homeModels.Social = socials;
            homeModels.About = about;

            return View(homeModels);
        }
    }
}
