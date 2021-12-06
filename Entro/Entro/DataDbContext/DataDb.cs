using Entro.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.DataDbContext
{
    public class DataDb : DbContext
    {
        public DataDb(DbContextOptions option):base(option)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<MessageContact> MessageContacts { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Social> Socials { get; set; }
    }
}
