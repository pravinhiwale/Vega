using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.api.Controllers.Resources;
using vega.api.Models;
using vega.api.Persistence;

namespace vega.api.Controllers
{
    public class Makes : ControllerBase
    {
        private readonly VegaDbContext context;
        private readonly IMapper mapper;

        public Makes(VegaDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Make.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);

        }

    }
}