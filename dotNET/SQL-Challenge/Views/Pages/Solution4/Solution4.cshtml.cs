using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution4
{
    public class Solution4 : PageModel
    {
        private readonly ILogger<Solution4> _logger;

        public Solution4(ILogger<Solution4> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}