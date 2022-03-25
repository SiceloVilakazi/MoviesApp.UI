namespace MoviesApp.UI.Services
{
    public interface IAgentService
    {
        List<Agent> agents { get; set; }

        Task GetAgents();
    }
}
