using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution9
{
    public class Solution9 : PageModel
    {
        private readonly ILogger<Solution9> _logger;

        public Solution9(ILogger<Solution9> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}