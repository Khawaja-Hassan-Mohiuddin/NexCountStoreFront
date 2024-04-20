
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NexCountStoreFront.NewFolder1;
using System.Collections.Generic;

namespace NexCountStoreFront.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        // Define the CardDataList property
        public List<CardData> CardDataList { get; set; } = new List<CardData>();

        // Initialize CardDataList in the OnGet method
        public void OnGet()
        {
            // Initialize CardDataList with dynamic data
            CardDataList = new List<CardData>
            {
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Invoicing", Description = "Our Invoicing app for qutions", Url = "appdetail/appone" },
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Finance", Description = "Our Finance app for qs", Url = "appdetail/apptwo" },
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Accounting", Description = "Our Accounting app for quick and precise transactions", Url = "appdetail/appthree" }

            };
        }


    }
}
