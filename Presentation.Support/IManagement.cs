using System.Collections.Generic;
using Presentation.Support.DTOS;

namespace Presentation.Support
{
    public interface IManagement
    {
        IEnumerable<AgentDTO> GetAgents();
        IEnumerable<ProyectDTO> GetProyects();
        ResultDTO AddAgent(AgentDTO agent);
        ResultDTO RemoveAgent(string agentId);
        ResultDTO AddProyect(ProyectDTO proyectDTO);
        ResultDTO RemoveProyect(string proyectId);
    }
}