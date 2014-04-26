using BusinessLogic;

namespace Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var management = new Management();
            var agents = management.GetAgents();

            foreach (var agentDTO in agents)
            {
                System.Console.WriteLine(agentDTO.Name);
            }
        }
    }
}
