using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }  //Navigation type, from one class to another, no need to reference to id
        public byte GenreId { get; set; }  //by naming convention treats it as a foreign key

        public DateTime ReleasedDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberInStock { get; set; }
    }
}