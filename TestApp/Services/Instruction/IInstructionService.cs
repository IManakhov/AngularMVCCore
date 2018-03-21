using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.DTO;

namespace TestApp.Services.Instruction
{
    /// <summary>
    /// Instruction service interface for work with instruction's
    /// </summary>
    public interface IInstructionService
    {
        /// <summary>
        /// Method for get some instruction
        /// </summary>
        InstructionGetDTO Get();
    }
}
