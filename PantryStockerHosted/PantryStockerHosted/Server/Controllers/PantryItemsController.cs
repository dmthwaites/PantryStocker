using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PantryStockerHosted.Shared.Dtos;
using PantryStockerHosted.Shared.PantryItems;

namespace PantryStockerHosted.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PantryItemsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<PantryItemDto> Get() 
        { 
            var pantryItems = GetPantryItems();

            var dtos = new List<PantryItemDto>();
            foreach (var item in pantryItems)
            {
                var pantryItemDto = new PantryItemDto() { Name = item.Name, Amount = item.Amount, Measures = item.Measures.ToString()};
                dtos.Add(pantryItemDto);
               
            }
            return dtos;
        }

        private IEnumerable<PantryItem> GetPantryItems()
        {
            var pantry = new List<PantryItem>();
            pantry.Add(new PantryItem { Name = "Brown Rice", Amount = 500, Measures = Shared.Enums.MeasuresEnum.grams });
            pantry.Add(new PantryItem { Name = "Spaghetti", Amount = 1.5, Measures = Shared.Enums.MeasuresEnum.kilos });
            pantry.Add(new PantryItem { Name = "Mango", Amount = 1, Measures = Shared.Enums.MeasuresEnum.tin });
            pantry.Add(new PantryItem { Name = "White Rice", Amount = 3, Measures = Shared.Enums.MeasuresEnum.grams });
            return pantry;
        }
    }
}
