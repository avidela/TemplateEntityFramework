using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic.Exceptions;
using Domain;
using Infrastructure.Data;
using Presentation.Support;
using Presentation.Support.DTOS;

namespace BusinessLogic
{
    public class Management : IManagement
    {
        private ObjectContext Context { get; set; }

        public Management()
        {
            Context = new ObjectContext();
        }

        public IEnumerable<AgentDTO> GetAgents()
        {
            return Context.Agents.Select(x => new AgentDTO
                {
                    AgentId = x.AgentId,
                    Name = x.Name,
                    LastName = x.LastName
                });
        }

        public IEnumerable<ProyectDTO> GetProyects()
        {
            return Context.Proyects.Select(proyect => new ProyectDTO
            {
                ProyectId = proyect.ProyectId,
                Name = proyect.Name,
                Agents = proyect.Agents.Select(agent => new AgentDTO
                {
                    AgentId = agent.AgentId,
                    Name = agent.Name,
                    LastName = agent.LastName
                }).ToList()
            });
        }

        public ResultDTO AddAgent(AgentDTO agent)
        {
            try
            {
                Context.Agents.Add(new Agent
                {
                    AgentId = agent.AgentId,
                    Name = agent.Name,
                    LastName = agent.LastName
                });
                SaveChanges();
                return new ResultDTO { Success = true };
            }
            catch (Exception ex) { return new ResultDTO { Success = false, Message = ex.Message }; }
        }

        public ResultDTO RemoveAgent(string agentId)
        {
            try
            {
                var agent = Context.Agents.FirstOrDefault(x => x.AgentId == agentId);
                if (agent == null) throw new AgentNotFoundException();
                Context.Agents.Remove(agent);
                SaveChanges();
                return new ResultDTO { Success = true };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Success = false,
                    Message = ex.Message
                };
            }

        }

        public ResultDTO AddProyect(ProyectDTO proyectDTO)
        {
            try
            {
                Context.Proyects.Add(new Proyect
                {
                    ProyectId = proyectDTO.ProyectId,
                    Name = proyectDTO.Name,
                    Agents = proyectDTO.Agents.Select(x => new Agent
                    {
                        AgentId =  x.AgentId,
                        LastName = x.LastName,
                        Name = x.Name
                    }).ToList()
                });
                SaveChanges();
                return new ResultDTO { Success = true };
            }
            catch (Exception ex) { return new ResultDTO { Success = false, Message = ex.Message }; }
        }

        public ResultDTO RemoveProyect(string proyectId)
        {
            try
            {
                var agent = Context.Proyects.FirstOrDefault(x => x.ProyectId == proyectId);
                if (agent == null) throw new AgentNotFoundException();
                Context.Proyects.Remove(agent);
                SaveChanges();
                return new ResultDTO { Success = true };
            }
            catch (Exception ex)
            {
                return new ResultDTO
                {
                    Success = false,
                    Message = ex.Message
                };
            }

        }

        private void SaveChanges()
        {
            Context.SaveChanges();
        }
    }
}
