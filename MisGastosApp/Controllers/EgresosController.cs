using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using MisGastosApp.DataAccess;

namespace MisGastosApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EgresosController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public EgresosController(AplicationDbContext myWorldDbContext)
        {
            _context = myWorldDbContext;
        }

        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Egresos.AsQueryable());
        }

    }
}
