using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models.ViewModels
{
    public class HomeModel
    {
        public About About { get; set; }
        public List<Gallery> Galleries { get; set; }
        public Concert Concert { get; set; }
        public Setting Setting { get; set; }
        public List<Social> Social { get; set; }
        public Slider Slider { get; set; }
    }
}
