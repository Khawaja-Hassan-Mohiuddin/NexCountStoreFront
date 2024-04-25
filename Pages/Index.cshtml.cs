
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using NexCountStoreFront.NewFolder1;
using System.Collections.Generic;
using System.Linq;

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
        public List<CardData> FeaturedCards { get; set; } = new List<CardData>();

        //public IEnumerable<CardData> Cards { get; set; }

        // Initialize CardDataList in the OnGet method
        public void OnGet()
        {
            // Initialize CardDataList with dynamic data
            CardDataList = new List<CardData>
            {
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Invoicing", Description = "Our Invoicing app for qutions", Url = "appdetail/appone", Featured = true ,Rating=4 ,order=0},
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Finance", Description = "Our Finance app for qs", Url = "appdetail/apptwo" , Featured = false ,Rating=3,order=6},
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Accounting", Description = "Our Accounting app for quick and precise transactions", Url = "appdetail/appthree", Featured = true,Rating=5,order=2 },
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Finance", Description = "Our Finance app for qs", Url = "appdetail/apptwo" , Featured = true ,Rating=5, order = 4},
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Accounting", Description = "Our zzzz app for quick and precise transactions", Url = "appdetail/appthree" , Featured = true , Rating = 2, order = 3},
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Finance", Description = "Our Finance app for qs", Url = "appdetail/apptwo", Featured = false , Rating = 3 ,order = 5},
                new CardData { ImageUrl = "images/gym/Invoicing.jpg", Title = "Accounting", Description = "Our uuuu app for quick and precise transactions", Url = "appdetail/appthree", Featured = true , Rating = 0, order = 1},

            };

            FeaturedCards = CardDataList
           .Where(card => card.Featured) // Filter where Featured is true
           .OrderBy(card => card.order) // Order by Rating in descending order
           .Take(3).ToList(); // Take the top 3 results


        }


    }
}
