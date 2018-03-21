using System.Collections.Generic;
using TestApp.DTO;

namespace TestApp.Services.Instruction
{
    /// <summary>
    /// People service that implement interface with simple GetAll method
    /// </summary>
    public class PeopleService : IPeopleService
    {
        /// <summary>
        /// Method that get all peoples
        /// </summary>
        /// <returns></returns>
        public IList<PeopleListDTO> GetAll()
        {
            return new List<PeopleListDTO>() {
                new PeopleListDTO{ FirstName = "Manakhov", LastName = "Ilshat", Birthdate = "01.03.1991" },
                new PeopleListDTO{ FirstName = "Ivanov", LastName = "Ivan", Birthdate = "20.11.1999" },
                new PeopleListDTO{ FirstName = "Petrov", LastName = "Boris", Birthdate = "01.03.1987" }
            };
        }
    }
}
