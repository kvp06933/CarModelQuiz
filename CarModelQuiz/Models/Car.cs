using CarModelQuiz.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarModelQuiz.Models
{
    public class Car
    {
        //Primary key
        public int Id { get; set; }
        //Foreign key
        public string UserId { get; set; }
      
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Milage { get; set; }
        public float Price { get; set; }
        public IsNewUsed NewUsed { get; set; }

        [NotMapped]
        [Display(Name = "Contact Image")]
        [DataType(DataType.Upload)]
        public IFormFile ImageFile { get; set; }

        public byte[] ImageData { get; set; }
        public string ImageType { get; set; }

        public DateTime Created { get; set; }

        public virtual IdentityUser User { get; set; }

        public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    }
}
