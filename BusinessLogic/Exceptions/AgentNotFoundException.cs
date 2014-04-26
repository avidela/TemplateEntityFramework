using System;

namespace BusinessLogic.Exceptions
{
    public class AgentNotFoundException :Exception
    {
        public AgentNotFoundException()
            :base("Agent was not found")
        {
            
        }
    }
}
