using TestApp.DTO;

namespace TestApp.Services.Instruction
{
    /// <summary>
    /// Instruction service that implement interface with simple Get method
    /// </summary>
    public class InstructionService : IInstructionService
    {
        /// <summary>
        /// Method that get instruction of angular 5
        /// </summary>
        /// <returns></returns>
        public InstructionGetDTO Get()
        {
            return new InstructionGetDTO
            {
                Title = "Tutorial",
                Message = "In this tutorial you will build an app that helps a staffing agency manage its stable of heroes."
            };
        }
    }
}
