using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Sdk;

namespace _9_11_ProjectPetShop_1.Models
{
    public class Animals
    {
        public int Id { get; set; }
        [Display(Name = "Name:")]
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Display(Name = "Age:")]
        [Range(0, 120)]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Please enter the age.")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Please enter a file picture.")]
        [Display(Name = "Picture:")]
        public int ImageId { get; set; }
        public virtual Image Image { get; set; }

        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a Description.")]
        [Display(Name = "Description:")]
        public string Description { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public virtual Categories Category { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }
}
