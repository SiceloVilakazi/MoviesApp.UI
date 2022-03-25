namespace MoviesApp.UI.Services
{
    public interface IActorUpdateService
    {
        Task CreateActor(Actor actor);

        Task DeleteActor(int id);
    }
}
