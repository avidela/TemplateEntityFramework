using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Agent
    {
        [Key]
        public Guid Id { get; set; }
        public string AgentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        
        public Agent()
        {
            Id = Guid.NewGuid();
        }
    }
}
