using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution6
{
    public class Solution6 : PageModel
    {
        private readonly ILogger<Solution6> _logger;

        public Solution6(ILogger<Solution6> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}