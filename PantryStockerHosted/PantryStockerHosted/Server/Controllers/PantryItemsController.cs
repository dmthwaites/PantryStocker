using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PantryStockerHosted.Shared.PantryItems;

namespace PantryStockerHosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantryItemsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PantryItem> Get() 
        { 
            var pantry = new List<PantryItem>();
            pantry.Add(new PantryItem { Name = "Brown Rice", Description = "it's brown", Amount = 500, Measure = "grams" });
            pantry.Add(new PantryItem { Name = "Spaghetti", Description = "it's long", Amount = 1.5, Measure = "kilos" });
            pantry.Add(new PantryItem { Name = "Spaghetti", Description = "it's long", Amount = 1.5, Measure = "kilos" });
            return pantry;
        }
    }
}
