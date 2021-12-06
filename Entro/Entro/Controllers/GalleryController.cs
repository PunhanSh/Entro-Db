using Entro.DataDbContext;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class GalleryController : Controller
    {
        private readonly DataDb _datadb;
        public GalleryController(DataDb dataDb)
        {
            _datadb = dataDb;
        }
        public IActionResult Index()
        {
            List<Gallery> gallery = _datadb.Galleries.Include(option => option.Images).ToList();

            return View(gallery);
        }
    }
}
