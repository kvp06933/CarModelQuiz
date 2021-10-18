using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarModelQuiz.Models
{
    public class Category
    {
        //Primary key
        public int Id { get; set; }
        //Foreign Key
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        public string Name { get; set; }

        public virtual IdentityUser User { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}

