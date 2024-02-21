using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Data.SqlClient;
using System.Collections;
using SQL_Challenge_DIO.Models;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace SQL_Challenge_DIO.Controllers
{
    [Route("movies/[action]")]
    public class MoviesController : Controller
    {

        private readonly string _connectionString;
        private readonly ILogger<MoviesController> _logger;

        private readonly static string firstQuery ="SELECT Name, Year FROM dbo.Movies;";

        public static string GetFirstQuery()
        {
            return "<strong>"+firstQuery+"</strong>";
        }

        private readonly static string secondQuery=("SELECT Name, Year, MovieLength" +
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          ORDER BY Year;");

        public static string GetSecondQuery()
        {
            return "<strong>"+secondQuery+"</strong>";
        }

        private readonly static string thirdQuery=("SELECT Name, Year, MovieLength" +
                                            Environment.NewLine +"          FROM dbo.Movies" +
                                            Environment.NewLine +"          WHERE Year=1985;");

        public static string GetThirdQuery()
        {
            return "<strong>"+thirdQuery+"</strong>";
        }

        private static readonly string fourthQuery = (@"SELECT Name, Year, MovieLength"+ 
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          WHERE Year=1997;");        

        public static string GetFourthQuery()
        {
            return "<strong>"+fourthQuery+"</strong>";
        }

        public MoviesController(IConfiguration configuration, ILogger<MoviesController> logger)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private static readonly string fifthQuery=(@"SELECT Name, Year, MovieLength"+ 
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          Where Year>2000; "); 

        public static string GetFifthQuery()
        {
            return "<strong>"+fifthQuery+"</strong>";
        }

        private readonly static string sixthQuery=(@"SELECT Name, Year, MovieLength"+ 
                                            Environment.NewLine +"          FROM dbo.Movies"+
                                            Environment.NewLine +"          WHERE MovieLength > 100"+
                                            Environment.NewLine +"          ORDER BY MovieLength; ");

        public static string GetSixthQuery()
        {
            return "<strong>"+sixthQuery+"</strong>";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solution1() 
        {
            List<Movies> moviesList;
            moviesList = FirstSolution();

            return View("/Views/Pages/Solution1/Solution1.cshtml",moviesList);
        }

        public IActionResult Solution2() 
        {
            List<Movies> moviesList;
            moviesList = SecondSolution();

            return View("/Views/Pages/Solution2/Solution2.cshtml", moviesList);
        }

        public IActionResult Solution3() 
        {
            List<Movies> moviesList;
            moviesList = ThirdSolution();

            return View("/Views/Pages/Solution3/Solution3.cshtml", moviesList);
        }

        public IActionResult Solution4() 
        {
            List<Movies> moviesList;
            moviesList = FourthSolution();

            return View("/Views/Pages/Solution4/Solution4.cshtml", moviesList);
        }

        public IActionResult Solution5() 
        {
            List<Movies> moviesList;
            moviesList = FifthSolution();

            return View("/Views/Pages/Solution5/Solution5.cshtml", moviesList);
        }

        public IActionResult Solution6() 
        {
            List<Movies> moviesList;
            moviesList = SixthSolution();

            return View("/Views/Pages/Solution6/Solution6.cshtml", moviesList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public List<Movies> FirstSolution()
        {

            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(firstQuery, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while (reader.Read())
                {
                    reader.GetString(0);
                    reader.GetInt32(1);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found!");
            }
            finally
            {
                reader.Close();
            }
            GetFirstQuery();
            return movies;
        }

        [HttpGet]
        public List<Movies> SecondSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(secondQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while (reader.Read())
                {
                    reader.GetString(0);
                    reader.GetInt32(1);
                    reader.GetInt32(2);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1) + " " + reader.GetInt32(2));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1), MovieLength =reader.GetInt32(2)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found!");
            }
            finally
            {
                connection.Close();
            }
            return movies;
        }

        [HttpGet]
        public List<Movies> ThirdSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(thirdQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetInt32(1);
                    reader.GetInt32(2);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1) + " " + reader.GetInt32(2));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1), MovieLength =reader.GetInt32(2)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found");            
            }
            finally 
            {
                connection.Close();
            }
            return movies;
        }

        [HttpGet]
        public List<Movies> FourthSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(fourthQuery,connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while (reader.Read()){
                    reader.GetString(0);
                    reader.GetInt32(1);
                    reader.GetInt32(2);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1) + " " + reader.GetInt32(2));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1), MovieLength =reader.GetInt32(2)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found");
            }
            finally
            {
                connection.Close();
            }
            return movies;
        }

        [HttpGet]
        public List<Movies> FifthSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(fifthQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetInt32(1);
                    reader.GetInt32(2);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1) + " " + reader.GetInt32(2));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1), MovieLength =reader.GetInt32(2)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found");
            }
            finally
            {
                connection.Close();
            }
            return movies;
        }

        [HttpGet]
        public List<Movies> SixthSolution()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(sixthQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Movies> movies = new List<Movies>();

            try
            {
                while(reader.Read())
                {
                    reader.GetString(0);
                    reader.GetInt32(1);
                    reader.GetInt32(2);
                    Console.WriteLine(reader.GetString(0) + " " + reader.GetInt32(1) + " " + reader.GetInt32(2));
                    movies.Add(new Movies() { Name = reader.GetString(0), Year = reader.GetInt32(1), MovieLength =reader.GetInt32(2)});
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No Data was found");
            }
            finally
            {
                connection.Close();
            }
            return movies;
        }

    }
}