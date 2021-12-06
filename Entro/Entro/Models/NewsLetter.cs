using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Models
{
    public class NewsLetter
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Mail { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
