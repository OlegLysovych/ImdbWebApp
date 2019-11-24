using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImdbWebApp.Models
{
    public class MovieDbInitializer : DropCreateDatabaseAlways<imdbContext>
    {
        protected override void Seed(imdbContext context)
        {
            context.Movies.Add(new Movie { Tittle = "Friends", MovieYear = 2001, Description = "NY city apartament without black people", RunTime = "1000plus hours" });
            context.Movies.Add(new Movie { Tittle = "GodFather", MovieYear = 1971, Description = "Italian Mafia in US", RunTime = "3 amazing hours" });
            context.Movies.Add(new Movie { Tittle = "Memento", MovieYear = 2004, Description = "To much hard detective", RunTime = "2 hours" });

            base.Seed(context);
        }
    }
}