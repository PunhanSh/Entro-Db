using Entro.DataDbContext;
using Entro.Models;
using Entro.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class ConcertsController : Controller
    {
        private readonly DataDb _datadb;
        public ConcertsController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            Concert concert = _datadb.Concerts.FirstOrDefault();

            return View(concert);
        }
    }
}
