using System.Collections.Generic;
using Domain;
using Presentation.Support;
using Presentation.Support.DTOS;

namespace BusinessLogic
{
    public interface IManagement
    {
        IEnumerable<Agent> GetAgents();
        IEnumerable<Proyect> GetProyects();
        ResultDTO AddAgent(AgentDTO agent);
        ResultDTO RemoveAgent(string agentId);
        ResultDTO AddProyect(ProyectDTO proyectDTO);
        ResultDTO RemoveProyect(string proyectId);
    }

    public class Management :IManagement
    {
        public IEnumerable<Agent> GetAgents()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Proyect> GetProyects()
        {
            throw new System.NotImplementedException();
        }

        public ResultDTO AddAgent(AgentDTO agent)
        {
            throw new System.NotImplementedException();
        }

        public ResultDTO RemoveAgent(string agentId)
        {
            throw new System.NotImplementedException();
        }

        public ResultDTO AddProyect(ProyectDTO proyectDTO)
        {
            throw new System.NotImplementedException();
        }

        public ResultDTO RemoveProyect(string proyectId)
        {
            throw new System.NotImplementedException();
        }
    }
}
