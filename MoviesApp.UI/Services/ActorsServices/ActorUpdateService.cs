using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace MoviesApp.UI.Services
{
    public class ActorUpdateService : IActorUpdateService
    {
        private readonly HttpClient _httpClient;
        private readonly MovieApiClient _movieApiClient;
        private readonly NavigationManager _navigationManager;
        public ActorUpdateService(HttpClient http,NavigationManager navigationManager)
        {
            _httpClient = http;
            _movieApiClient = new MovieApiClient("https://localhost:7039/", _httpClient);
            _navigationManager = navigationManager;
          //  _actorService = actorService;
        }
        public async Task CreateActor(Actor actor)
        {
           await _movieApiClient.AddAsync(actor);
           _navigationManager.NavigateTo("Actors");

        }

        public async Task DeleteActor(int id)
        {
            await _movieApiClient.Actors2Async(id);
            _navigationManager.NavigateTo("Actors");
        }

        public async Task UpdateActor(Actor actor)
        {
            await _movieApiClient.EditAsync(actor);
            _navigationManager.NavigateTo("Actors");
        }

        //private async Task SetActors(HttpResponseMessage result)
        //{
        //    _actorService.GetActors();
        //    var response = await result.Content.ReadFromJsonAsync<List<Actor>>();
        //    _actorService.actors = response;
        //    _navigationManager.NavigateTo("Actors");
        //}
    }
}
