using System.Collections.Generic;
using BusinessLogic;
using Presentation.Support.DTOS;

namespace Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var management = new Management();

            var result = management.AddProyect(new ProyectDTO
            {
                ProyectId = "00-01",
                Name = "Citibank",
                Agents = new List<AgentDTO>
                {
                    new AgentDTO
                    {
                        AgentId = "26514",
                        Name = "John",
                        LastName = "Doe"

                    },
                    new AgentDTO
                    {
                        AgentId = "26515",
                        Name = "Jane",
                        LastName = "Doe"
                    }
                }
            });

            if (!result.Success)
                System.Console.WriteLine(result.Message);

            var agents = management.GetAgents();

            foreach (var agentDTO in agents)
            {
                System.Console.WriteLine(agentDTO.Name);
            }

            System.Console.ReadLine();
        }
    }
}
