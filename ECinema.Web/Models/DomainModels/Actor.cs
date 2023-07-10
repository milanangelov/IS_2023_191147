using System;
using System.Collections.Generic;

namespace ECinema.Web.Models.DomainModels
{
    public class Actor
    {
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public virtual ICollection<ActorsInMovies> ActorsInMovies { get; set; }
    }
}
