namespace MoviesApp.UI.Services
{
    public interface IActorService
    {
        List<Actor> actors { get; set; }
        Task GetActors();

        Task<Actor> GetSingleActor(int id);
    }
}
