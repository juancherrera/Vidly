using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public byte GenreId { get; set; }  //by naming convention treats it as a foreign key

        public DateTime ReleasedDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}