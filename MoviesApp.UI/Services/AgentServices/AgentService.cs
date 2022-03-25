namespace MoviesApp.UI.Services
{
    public class AgentService : IAgentService
    {

        public List<Agent> agents { get; set; } = new List<Agent>();

        private readonly HttpClient _httpClient;
        private readonly MovieApiClient moviesApiClient;

        public AgentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            moviesApiClient = new MovieApiClient("https://localhost:7039/", _httpClient);
        }

        public async Task GetAgents()
        {
            var apiResponse = await moviesApiClient.GetAsync();
            if (apiResponse != null)
                agents = apiResponse.ToList();
        }
    }
}
