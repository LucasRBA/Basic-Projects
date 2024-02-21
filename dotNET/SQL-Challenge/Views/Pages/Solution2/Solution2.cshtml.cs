
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution2
{
    public class Solution2 : PageModel
    {
        private readonly ILogger<Solution2> _logger;

        public Solution2(ILogger<Solution2> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}