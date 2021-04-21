using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    class NFLPlayerStats_Receiving
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Rank { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesStarted { get; set; }
        public int Targets { get; set; }
        public int Receptions { get; set; }
        public float CatchPercentage { get; set; }
        public int Yards { get; set; }
        public int YardsPerReception { get; set; }
        public int Touchdowns { get; set; }
        public int FirstDowns { get; set; }
        public int LongestReception { get; set; }
        public float YardsPerTarget { get; set; }
        public float ReceptionsPerGame { get; set; }
        public float YardsPerGame { get; set; }
        public int Fumbles { get; set; }
    }
}
