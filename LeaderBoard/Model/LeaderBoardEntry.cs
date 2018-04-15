using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderBoard.Model
{
    public class LeaderBoardEntry
    {
        [Key]
        public int Index { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }

}
