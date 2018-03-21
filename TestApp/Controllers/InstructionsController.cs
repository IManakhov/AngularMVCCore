using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApp.DTO;
using TestApp.Services.Instruction;

namespace TestApp.Controllers
{
    /// <summary>
    /// Instruction manipulating controller
    /// </summary>
    [Produces("application/json")]
    [Route("api/Instructions/")]
    public class InstructionsController : Controller
    {
        IInstructionService InstructionService { get; set; }

        public InstructionsController() {
            InstructionService = new InstructionService();
        }

        /// <summary>
        /// Get sample instruction of angular 5
        /// </summary>
        /// <returns></returns>
        // GET: api/<controller>
        [HttpGet(Name = "Get")]
        public InstructionGetDTO Get()
        {
            return InstructionService.Get();
        }
    }
}
