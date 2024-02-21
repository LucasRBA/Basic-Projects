using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQL_Challenge_DIO.Models;

namespace SQL_Challenge_DIO.Views.Pages.Solution8
{
    public class Solution8 : PageModel
    {
        private readonly ILogger<Solution8> _logger;

        public Solution8(ILogger<Solution8> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}