using Microsoft.AspNetCore.Mvc.RazorPages;
using NexCountStoreFront.NewFolder1;
using System.Collections.Generic;
using System.Linq;

namespace NexCountStoreFront.Pages
{
    class DataStore<T>
    {
        public T Data { get; set; }
    }
    public class ExplorerAppModel2 : PageModel
    {

        public List<AppCard> AppCardData { get; set; } = new List<AppCard>();
        public IEnumerable<IGrouping<string, AppCard>> AppGrouped { get; set; }


        public void OnGet()
        {
            AppCardData = new List<AppCard>
            {
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Invoicing", AppDescription = "Our Invoicing app for qutions", Category = "Sales"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Finance", AppDescription = "Our Finance app for qs", Category = "Sales"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Accounting", AppDescription = "Our Accounting app for quick and precise transactions", Category = "HR"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Invoicing", AppDescription = "Our Invoicing app for qutions", Category = "HR"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Finance", AppDescription = "Our Finance app for qs", Category = "Finance"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Accounting", AppDescription = "Our Accounting app for quick and precise transactions", Category = "Finance"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Invoicing", AppDescription = "Our Invoicing app for qutions", Category = "Marketing"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Finance", AppDescription = "Our Finance app for qs", Category = "Marketing"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Accounting", AppDescription = "Our Accounting app for quick and precise transactions", Category = "Marketing"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Invoicing", AppDescription = "Our Invoicing app for qutions", Category = "Finance"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Finance", AppDescription = "Our Finance app for qs", Category = "Finance"},
                new AppCard { AppImageUrl = "images/gym/Invoicing.jpg", AppTitle = "Accounting", AppDescription = "Our Accounting app for quick and precise transactions", Category = "Sales"},

            };

            AppGrouped = AppCardData.GroupBy(a => a.Category);




        }
    }
}
