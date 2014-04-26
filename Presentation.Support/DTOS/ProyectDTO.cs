using System.Collections.Generic;

namespace Presentation.Support.DTOS
{
    public class ProyectDTO
    {
        public string Name { get; set; }
        public string ProyectId { get; set; }
        public IList<AgentDTO> Agents { get; set; }
    }
}
