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
        public string Name { get; set; }
        [Required]
        public DateTime ReleasedDate { get; set; }
        [Required]
        public DateTime AddedDate { get; set; }
        [Required]
        public int NumberInStock { get; set; }
        public Genre Genre { get; set; }  //Navigation type, from one class to another, no need to reference to id
        public byte GenreId { get; set; }  //by naming convention treats it as a foreign key
    }
}