namespace TikoAPI.Models.ViewModels
{
    public class AgentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public AgentViewModel Map(Agent agent) => new AgentViewModel
        {
            Id = agent.Id,
            Name = agent.Name,
            City = agent.City?.Name
        };
    }
}