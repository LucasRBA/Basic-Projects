using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution7
{
    public class Solution7 : PageModel
    {
        private readonly ILogger<Solution7> _logger;

        public Solution7(ILogger<Solution7> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}