using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImdbWebApp.Models
{
    public class Genre
    {
        [Key]
        [Required]
        public int GenreId { get; set; }
        [MinLength(1, ErrorMessage = "Name should be minimum 1 character")]
        [MaxLength(20, ErrorMessage = "Name should be less than 20 characters ")]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        public void InsertActor()
        {
            using (var context = new imdbContext())
            {
                context.Database.ExecuteSqlCommand("INSERT INTO Genres (Name)" +
                "VALUES ('Comedy')");
            }
        }
    }
}