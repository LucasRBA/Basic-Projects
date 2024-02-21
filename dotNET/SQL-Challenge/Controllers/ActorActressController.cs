using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Controllers
{
    [Route("actors/[action]")]
    public class ActorActressController : Controller
    {
        private readonly ILogger<ActorActressController> _logger;
        private readonly string _connectionString;

        public ActorActressController(ILogger<ActorActressController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _connectionString = configuration.GetConnectionString("DBConnection");
        }

        private readonly static string eighthQuery=("SELECT * FROM dbo.[Actor/Actress]"+
                                    Environment.NewLine +"            WHERE Gender = 'M';");

        public static string GetEighthQuery(){
            return "<strong>"+eighthQuery+"</strong>";
        }

        private readonly static string ninthQuery=("SELECT * FROM dbo.[Actor/Actress]"+
                                    Environment.NewLine +"            WHERE Gender = 'F'"+
                                    Environment.NewLine +"            ORDER BY FirstName;");

        public static string GetNinthQuery()
        {
            return"<strong>"+ninthQuery+"</strong>";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Solution8() 
        {
            List<ActorActress> actorsList;
            actorsList = GetAllActors();

            return View("/Views/Pages/Solution8/Solution8.cshtml", actorsList);
        }

        public IActionResult Solution9() 
        {
            List<ActorActress> actressesList;
            actressesList = GetAllActresses();

            return View("/Views/Pages/Solution9/Solution9.cshtml", actressesList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        [HttpGet]
        public List<ActorActress> GetAllActors()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(eighthQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<ActorActress> actors = new List<ActorActress>();

            try
            {
                while (reader.Read())
                {
                    reader.GetInt32(0);
                    reader.GetString(1);
                    reader.GetString(2);
                    reader.GetString(3);
                    Console.WriteLine("{0} - {1} {2} - {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    actors.Add(new ActorActress(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No Data was Found");
            }
            finally
            {
                connection.Close();
            }
            return actors;
        }

        [HttpGet]
        public List<ActorActress> GetAllActresses()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            SqlCommand command = new SqlCommand(ninthQuery, connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<ActorActress> actresses = new List<ActorActress>();

            try
            {
                while (reader.Read())
                {
                    reader.GetInt32(0);
                    reader.GetString(1);
                    reader.GetString(2);
                    reader.GetString(3);
                    Console.WriteLine("{0} - {1} {2} - {3}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3));
                    actresses.Add(new ActorActress(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No Data was Found");
            }
            finally
            {
                connection.Close();
            }
            return actresses;
        }
        
    }
}