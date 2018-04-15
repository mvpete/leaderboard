using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderBoard.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeaderBoard.Controllers
{
    [Produces("application/json")]
    [Route("Index")]
    public class IndexController : Controller
    {
        public LeaderBoardContext Context { get; }

        public IndexController(LeaderBoardContext ctx)
        {
            Context = ctx;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(Context);
        }
    }
}