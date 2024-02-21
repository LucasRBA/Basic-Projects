using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;

namespace SQL_Challenge_DIO.Controllers
{
    [Route("joins/[action]")]
    public class JoinsController : Controller
    {
        private readonly ILogger<JoinsController> _logger;

        private readonly string _connectionString;

        public JoinsController(ILogger<JoinsController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private readonly static string seventhQuery=("SELECT Year,COUNT(*) AS NumberOfMovies"+
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          GROUP BY Year"+
                                            Environment.NewLine +"          ORDER BY NumberOfMovies DESC;");

        public static string GetSeventhQuery()
        {
            return "<strong>"+seventhQuery+"</strong>";
        }

        private static readonly string tenthQuery=("SELECT dbo.Movies.Name, dbo.GenresName.MovieGenre"+
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          JOIN dbo.MovieGenre"+ 
                                            Environment.NewLine +"          ON dbo.Movies.Id = dbo.MovieGenre.MovieId"+
                                            Environment.NewLine +"          JOIN dbo.GenresName"+
                                            Environment.NewLine +"          ON dbo.MovieGenre.GenreId = dbo.GenresName.Id;");
        public static string GetTenthQuery()
        {
            return "<strong>"+tenthQuery+"</strong>";
        }

        private static readonly string eleventhQuery=("SELECT dbo.Movies.Name, dbo.GenresName.MovieGenre"+  
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          JOIN dbo.MovieGenre"+ 
                                            Environment.NewLine +"          ON dbo.Movies.Id = dbo.MovieGenre.MovieId"+
                                            Environment.NewLine +"          JOIN dbo.GenresName"+
                                            Environment.NewLine +"          ON dbo.MovieGenre.GenreId = dbo.GenresName.Id"+
                                            Environment.NewLine +"          WHERE dbo.GenresName.MovieGenre = 'Mystery';");

        public static string GetEleventhQuery()
        {
            return "<strong>"+eleventhQuery+"</strong>";
        }

        private readonly static string twelfthQuery=("SELECT M.[Name],AA.[FirstName] AS 'First Name',AA.[LastName] AS 'Last Name',MC.[Role] AS Role"+
                                            Environment.NewLine +"          FROM [dbo].[Movies] M"+
                                            Environment.NewLine +"          JOIN [dbo].[MovieCast] MC"+
                                            Environment.NewLine +"          ON M.[Id] = MC.[MovieId]"+
                                            Environment.NewLine +"          JOIN [dbo].[Actor/Actress] AA"+ 
                                            Environment.NewLine +"          ON MC.[ActorId] = AA.[Id];");             

        public static string GetTwelfthQuery()
        {
            return "<strong>"+twelfthQuery+"</strong>";
        }                     

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solution7() 
        {
            List<Count> countList;
            countList=SeventhSolution();

            return View("/Views/Pages/Solution7/Solution7.cshtml", countList);
        }

        public IActionResult Solution10() 
        {
            List<MovieByGenre> moviesByGenre;
            moviesByGenre = TenthSolution();

            return View("/Views/Pages/Solution10/Solution10.cshtml", moviesByGenre);
        }

        public IActionResult Solution11() 
        {
            List<MovieByGenre> mysteryMovies;
            mysteryMovies = EleventhSolution();

            return View("/Views/Pages/Solution11/Solution11.cshtml", mysteryMovies);
        }

        public IActionResult Solution12() 
        {
            List<MainCharacterByMovie> mainCharacters;
            mainCharacters = TwelfthSolution();

            return View("/Views/Pages/Solution12/Solution12.cshtml", mainCharacters);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public class Count
        {
            private Int32 year;
            private Int32 movieCount;

            public Int32 Year{
                get => this.year;
                set => this.year = value;
            }
            public Int32 MovieCount
            {
                get => this.movieCount;
                set => this.movieCount = value;
            }

            public Count(Int32 year, Int32 movieCount)
            {
                this.year = year;
                this.movieCount = movieCount;
            }
        }

        public class MovieByGenre
        {
            private string name;
            private string genre;

            public string Name
            {
                get => this.name;
                set => this.name = value;
            }

            public string Genre
            {
                get => this.genre;
                set => this.genre = value;
            }

            public MovieByGenre(string name, string genre) 
            {
                this.name = name;
                this.genre = genre;
            }
        }

        public class MainCharacterByMovie
        {
            private string movieTitle;
            private string actorFirstName;
            private string actorLastName;
            private string characterName;

            public string MovieTitle
            {
                get => this.movieTitle;
                set => this.movieTitle = value;
            }

            public string ActorFirstName
            {
                get => this.actorFirstName;
                set => this.actorFirstName = value;
            }

            public string ActorLastName {
                get => this.actorLastName;
                set => this.actorLastName = value;
            }

            public string CharacterName {
                get => this.characterName;
                set => this.characterName = value;
            }

            public MainCharacterByMovie(string movieTitle, string actorFirstName, string actorLastName, string characterName)
            {
                this.movieTitle = movieTitle;
                this.actorFirstName = actorFirstName;
                this.actorLastName = actorLastName;
                this.characterName = characterName;
            }
        }

        [HttpGet]
        public List<Count> SeventhSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(seventhQuery,connection);
            connection.Open();

            SqlDataReader reader= command.ExecuteReader();
            List<Count> count = new List<Count>();

            try
            {
                while(reader.Read())
                {
                    reader.GetInt32(0);
                    reader.GetInt32(1);
                    Console.WriteLine("{0} - {1}",reader.GetInt32(0),reader.GetInt32(1));
                    count.Add(new Count(reader.GetInt32(0), reader.GetInt32(1)));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No data found");
            }
            finally
            {
                connection.Close();
            }
            return count;
        }

        [HttpGet]
        public List<MovieByGenre> TenthSolution(){

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(tenthQuery, connection);
            connection.Open();

            SqlDataReader reader= command.ExecuteReader();
            List<MovieByGenre> movieByGenre = new List<MovieByGenre>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetString(1);
                    Console.WriteLine("{0} - {1}",reader.GetString(0),reader.GetString(1));
                    movieByGenre.Add(new MovieByGenre(reader.GetString(0), reader.GetString(1)));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No data was found");
            }
            finally
            {
                connection.Close();
            }
            return movieByGenre;
        }

        [HttpGet]
        public List<MovieByGenre> EleventhSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(eleventhQuery, connection);
            connection.Open();

            SqlDataReader reader= command.ExecuteReader();
            List<MovieByGenre> mysteryMovies = new List<MovieByGenre>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetString(1);
                    Console.WriteLine("{0} - {1}",reader.GetString(0),reader.GetString(1));
                    mysteryMovies.Add(new MovieByGenre(reader.GetString(0), reader.GetString(1)));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No data was found");
            }
            finally
            {
                connection.Close();
            }
            return mysteryMovies;
        }

        [HttpGet]
        public List<MainCharacterByMovie> TwelfthSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command= new SqlCommand(twelfthQuery, connection);
            connection.Open();

            SqlDataReader reader= command.ExecuteReader();
            List<MainCharacterByMovie> mainCharacters = new List<MainCharacterByMovie>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetString(1);
                    reader.GetString(2);
                    reader.GetString(3);
                    Console.WriteLine("{0} - {1} {2} - {3}",reader.GetString(0),reader.GetString(1),reader.GetString(2),reader.GetString(3));
                    mainCharacters.Add(new MainCharacterByMovie(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No data was found");
            }
            finally
            {
                connection.Close();
            }
            return mainCharacters;
        }


    }
}