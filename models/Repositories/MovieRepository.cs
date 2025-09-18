


    public class MovieRepository
    {
        private readonly List<Movie> _movies;

        public MovieRepository()
        {
            _movies = GenerateMockMovies();
        }

        public List<Movie> GetMovies()
        {
            return _movies;
        }

        private List<Movie> GenerateMockMovies()
        {
            var movies = new List<Movie>();

            var titles = new[]
            {
                "The Fast and the Furious", "2 Fast 2 Furious", "Tokyo Drift", "Fast Five",
                "Furious 7", "The Fate of the Furious", "Fast X", "Need for Speed",
                "Rush", "Ford v Ferrari", "Talladega Nights", "Cars",
                "Cars 2", "Cars 3", "Death Race", "Gone in 60 Seconds",
                "Baby Driver", "Mad Max: Fury Road", "Mad Max 2", "Death Proof",
                "Drive", "Speed Racer", "Italian Job", "Le Mans", "Days of Thunder"
            };

            var directors = new[]
            {
                "Rob Cohen", "John Singleton", "Justin Lin", "James Wan",
                "Ron Howard", "James Mangold", "George Miller", "Quentin Tarantino",
                "Tony Scott", "Michael Bay", "Edgar Wright"
            };

            var genres = new[] { "Action", "Racing", "Thriller", "Drama", "Comedy" };

            var rnd = new Random();

            for (int i = 1; i <= 25; i++)
            {
                movies.Add(new Movie
                {
                    Id = i,
                    Title = titles[rnd.Next(titles.Length)],
                    Director = directors[rnd.Next(directors.Length)],
                    ReleaseYear = rnd.Next(1970, 2024),
                    Genre = genres[rnd.Next(genres.Length)],
                    Rating = Math.Round(rnd.NextDouble() * 4 + 5, 1) // 5.0 to 9.0
                });
            }

            return movies;
        }
    }

