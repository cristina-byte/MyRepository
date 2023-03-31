using Microsoft.AspNetCore.Mvc;
using VideoGame;

namespace VideoGameManager.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController:ControllerBase
    {
        private readonly VideoGamesContext context;

        public GamesController(VideoGamesContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public IEnumerable<Game> GetAllGames()
        {
           var games=context.Games;
            return games;    
        }

        [HttpPost]
        public async Task<Game> AddGame([FromBody]Game newGame)
        {
            context.Games.Add(newGame);
           await context.SaveChangesAsync();
            return newGame;
        }

    }
}
