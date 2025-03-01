using Microsoft.AspNetCore.Mvc;
using ZambiaAPI.Data;
using ZambiaAPI.Models.DTO;

namespace ZambiaAPI.Controllers
{
    // The route construction will be https://localhost:portnumber/api/regions : [controller] will be replaced by the name of the controller.
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : Controller
    {
        private readonly ZambiaDbContext _dbcontext;
        // inject DBContext in the controller constructor
        public RegionsController(ZambiaDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        // GET ALL REGIONS
        // GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            // Get all regions from the database : Domain models
            var regionsDomain = _dbcontext.Regions.ToList();

            // Map Domain models to DTOs : Only a subset of the properties is mapped as per business requirements
            // For security reasons, we only expose a subset of the properties to the client and exclude sensitive information.
            var regionDTOs = new List<RegionsDTO>();
            foreach (var region in regionsDomain)
            {
                regionDTOs.Add(new RegionsDTO()
                {
                    Code = region.Code,
                    Name = region.Name,
                    RegionUrl = region.RegionUrl
                });
            }

            // Return DTOs
            return Ok(regionDTOs);
        }

        // GET REGION BY ID
        // GET: https://localhost:portnumber/api/regions/1
        [HttpGet("{id}")]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var region = _dbcontext.Regions.Find(id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }
    }
}
