using CQRS_lib.Data.Models;
using CQRS_lib.Repos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepo _repo;
        public ItemsController(IItemsRepo repo) 
        {
            _repo = repo;
        }


        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            return Ok(_repo.GetItems());
        }

        [HttpPost]   
        public async Task<IActionResult> InsertItem(Items item)
        {
            _repo.InsertItem(item);
            return Ok(item);

        }
    }
}
