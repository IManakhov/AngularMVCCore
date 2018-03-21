using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.DTO;

namespace TestApp.Services.Instruction
{
    /// <summary>
    /// People service interface for work with people's data
    /// </summary>
    public interface IPeopleService
    {
        /// <summary>
        /// Method for get all data of peoples
        /// </summary>
        IList<PeopleListDTO> GetAll();
    }
}
