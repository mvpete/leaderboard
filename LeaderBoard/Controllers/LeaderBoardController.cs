using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderBoard.Model;
using Microsoft.AspNetCore.Mvc;

namespace LeaderBoard.Controllers
{

    [Route("api/[controller]")]
    public class LeaderBoardController : Controller
    {
        public LeaderBoardContext Context { get; }

        public LeaderBoardController(LeaderBoardContext context)
        {
            Context = context;
        }

        [HttpGet]
        public IEnumerable<LeaderBoardEntry> All()
        {
            return Context.Leaders();
        }

        [HttpGet("top/{count}")]
        public IEnumerable<LeaderBoardEntry> Top([FromRoute]int count)
        {
            return Context.Leaders(count);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]LeaderBoardEntry value)
        {
            if (value == null || value.Name == null)
                return BadRequest();
            value.Index = 0;
            Context.Entries.Add(value);
            await Context.SaveChangesAsync();
            return Created($"api/leaderboard/{value.Index}", value);
        }

    }
}
