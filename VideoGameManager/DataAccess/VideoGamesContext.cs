using Microsoft.EntityFrameworkCore;

namespace VideoGame
{
    public class VideoGamesContext:DbContext
    {
        public VideoGamesContext(DbContextOptions<VideoGamesContext> options) : base(options)
        {

        }

        public DbSet<GameGenre> GameGenres { get; set; }

        public DbSet<Game> Games { get; set; }
    }
}
