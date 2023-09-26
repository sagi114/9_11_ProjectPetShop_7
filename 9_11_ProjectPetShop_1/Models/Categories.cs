using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Display(Name = "Catagory name:")]
        public string Name { get; set; }
        public virtual ICollection<Animals> Animals { get; set; }
    }
}
