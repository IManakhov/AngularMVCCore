using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.DTO;
using TestApp.Services.Instruction;

namespace TestApp.Controllers
{
    /// <summary>
    /// Peoples manipulating controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/Peoples")]
    public class PeoplesController : Controller
    {
        public IPeopleService PeopleService { get; set; }

        public PeoplesController()
        {
            this.PeopleService = new PeopleService();
        }

        /// <summary>
        /// Get all sample data of people
        /// </summary>
        /// <returns></returns>
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<PeopleListDTO> Get()
        {
            return PeopleService.GetAll();
        }
    }
}