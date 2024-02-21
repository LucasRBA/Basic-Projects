
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution1
{
    public class Solution1 : PageModel
    {
        private readonly ILogger<Solution1> _logger;

        public List<Movies> MoviesList {get;set;}


        public Solution1(ILogger<Solution1> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
