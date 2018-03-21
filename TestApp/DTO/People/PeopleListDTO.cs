using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.DTO
{
    /// <summary>
    /// People list dto (for grid)
    /// </summary>
    public class PeopleListDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Birthdate { get; set; }
    }
}
