using System;

namespace Presentation.Support.DTOS
{
    public class AgentDTO
    {
        public Guid Id { get; set; }
        public string AgentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
