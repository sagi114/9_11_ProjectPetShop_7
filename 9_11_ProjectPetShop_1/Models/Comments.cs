using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace _9_11_ProjectPetShop_1.Models
{
    public class Comments
    {
        public int Id { get; set; }
        [ForeignKey("AnimalesId")]
        public int AnimaleId { get; set; }
        public virtual Animals Animale { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "You didnt Enter a comment.")]
        [Display(Name = "Comment:")]
        public string Comment { get; set; }
    }
}
