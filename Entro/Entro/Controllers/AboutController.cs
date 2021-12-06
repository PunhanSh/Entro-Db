using Entro.DataDbContext;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class AboutController : Controller
    {
        private readonly DataDb _datadb;
        public AboutController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            About about = _datadb.Abouts.FirstOrDefault();

            return View(about);
        }
    }
}
