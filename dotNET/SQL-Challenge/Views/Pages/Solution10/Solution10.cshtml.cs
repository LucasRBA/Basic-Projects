using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution10
{
    public class Solution10 : PageModel
    {
        private readonly ILogger<Solution10> _logger;

        public Solution10(ILogger<Solution10> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}