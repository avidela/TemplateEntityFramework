using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Proyect
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ProyectId { get; set; }
        public IList<Agent> Agents { get; set; }

        public Proyect()
        {
            Id = Guid.NewGuid();
        }
    }
}