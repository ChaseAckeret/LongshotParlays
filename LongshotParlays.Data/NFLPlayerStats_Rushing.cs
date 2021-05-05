using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public class NFLPlayerStats_Rushing
    {

        [Key, ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual NFLPlayerInfo Player { get; set; }
        //public int Rank { get; set; }
        //public int GamesPlayed { get; set; }
        //public int GamesStarted { get; set; }
        public int Attempts { get; set; }
        public int Yards { get; set; }
        public int Touchdowns { get; set; }
        //public int FirstDowns { get; set; }
        //public int LongestRush { get; set; }
        //public float YardsPerAttempt { get; set; }
        //public float YardsPerGame { get; set; }
        //public int Fumbles { get; set; }
    }
}
