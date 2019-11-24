using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImdbWebApp.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [MinLength(1)]
        [MaxLength(20, ErrorMessage = "Tittle should be less than 20 characters ")]
        public string Tittle { get; set; }

        public int MovieYear { get; set; }

        [MaxLength(50, ErrorMessage = "Description should be less than 50 characters")]
        public string Description { get; set; }

        public string RunTime { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }

        public void InsertMovie()
        {
            using (var context = new imdbContext())
            {
                context.Database.ExecuteSqlCommand("INSERT INTO Movies (Tittle, MovieYear, Description, RunTime)" +
                "VALUES ('Friends', 2001, 'New York City', 'more 1000 hours')");
            }
        }
    }
}