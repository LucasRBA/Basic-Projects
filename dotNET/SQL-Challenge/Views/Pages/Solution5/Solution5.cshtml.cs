using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution5
{
    public class Solution5 : PageModel
    {
        private readonly ILogger<Solution5> _logger;

        public Solution5(ILogger<Solution5> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}