using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.Models
{
    public class Image
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a file picture.")]
        [Display(Name = "Picture:")]
        
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public int AnimaleId { get; set; }
        public virtual Animals Animals { get; set; }
    }
}
