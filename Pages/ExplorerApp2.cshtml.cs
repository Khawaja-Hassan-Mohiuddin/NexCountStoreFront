using Microsoft.AspNetCore.Mvc.RazorPages;
using NexCountStoreFront.NewFolder1;
using System.Collections.Generic;

namespace NexCountStoreFront.Pages
{
    public class ExplorerAppModel2 : PageModel
    {
        public List<AppCard> AppCardData { get; set; } = new List<AppCard>();


        public void OnGet()
        {
            AppCardData = new List<AppCard>
            {
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Invoicing", AppDescription = "Our Invoicing app for qutions"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Finance", AppDescription = "Our Finance app for qs"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Accounting", AppDescription = "Our Accounting app for quick and precise transactions"}

            };
        }
    }
}
