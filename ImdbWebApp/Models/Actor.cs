using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImdbWebApp.Models
{
    public class Actor
    {
        [Key]
        [Required]
        public int ActorId { get; set; }
        [MinLength(1, ErrorMessage = "FirstName should be minimum 1 character")]
        public string FirstName { get; set; }
        [MinLength(1, ErrorMessage = "FirstName should be minimum 1 character")]
        public string SecondName { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Bio { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }

        public void InsertActor()
        {
            using (var context = new imdbContext())
            {
                context.Database.ExecuteSqlCommand("INSERT INTO Actors (FirstName, SecondName, Gender, Age, Bio)" +
                "VALUES ('David', 'Schwimmer', 'Man', '55', 'Ross Geller')");
            }
        }
    }
}