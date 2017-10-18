using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MoviesFormViewModel
    {
        public IEnumerable<Genres> Genres { get; set; }   //using IEnumerable when no actions are needed in the hash
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }  //by naming convention treats it as a foreign key

        [Display(Name = "Released Date")]
        [Required]
        public DateTime? ReleasedDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        [Required]
        public byte? NumberInStock { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MoviesFormViewModel()
        {
            Id = 0;
        }
        public MoviesFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleasedDate = movie.ReleasedDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}