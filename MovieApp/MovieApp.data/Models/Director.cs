using System;
using System.Collections.Generic;

#nullable disable

namespace MovieApp.data.Models
{
    public partial class Director
    {
        public Director()
        {
            Movie = new HashSet<Movie>();
        }
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Movie> Movie { get; set; }
    }
}
