using System.Linq;
using BusinessLogic;
using Presentation.Support.DTOS;

namespace Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var management = new Management();
            management.AddAgent(new AgentDTO
            {
                AgentId = "26514",
                Name = "John",
                LastName = "Doe"

            });
            management.AddAgent(new AgentDTO
            {
                AgentId = "26515",
                Name = "Jane",
                LastName = "Doe"

            });
            management.AddProyect(new ProyectDTO
            {
                ProyectId = "00-01",
                Name = "Citibank",
                Agents = management.GetAgents().ToList()
            });

            var agents = management.GetAgents();

            foreach (var agentDTO in agents)
            {
                System.Console.WriteLine(agentDTO.Name);
            }

            System.Console.ReadLine();
        }
    }
}
