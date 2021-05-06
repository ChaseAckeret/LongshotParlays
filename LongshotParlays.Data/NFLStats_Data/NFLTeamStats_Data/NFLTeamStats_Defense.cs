using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public class NFLTeamStats_Defense
    {
        [Key, ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual NFLTeamInfo Team { get; set; }

        public int GamesPlayed { get; set; }
        public int PointsAllowed { get; set; }
        //public int YardsAllowed { get; set; }
        //public int TotalPlays { get; set; }
        //public float YardsAllowedPerPlay { get; set; }
        //public int Takeaways { get; set; }
        //public int FumblesLost { get; set; }
        //public int FirstDownsAllowed { get; set; }
        //public int CompletionsAllowed { get; set; }
        //public int PassingAttemptsDefended { get; set; }
        //public int PassingYardsAllowed { get; set; }
        //public int PassingTouchdownsAllowed { get; set; }
        //public int Interceptions { get; set; }
        //public float NetYardsPerAttemptAllowed { get; set; }
        //public int PassingFirstDownsAllowed { get; set; }
        //public int RushingAttemptsDefended { get; set; }
        //public int RushingYardsAllowed { get; set; }
        //public int RushingTouchdownsAllowed { get; set; }
        //public float RushingYardsPerAttemptAllowed { get; set; }
        //public int RushingFirstDownsAllowed { get; set; }
        //public int Penalties { get; set; }
        //public int PenaltyYards { get; set; }
        //public int PenaltyFirstDownsAllowed { get; set; }
        //public float DrivesEndingInScoreAllowed { get; set; }
        //public float DrivesEndingInTakeaway { get; set; }
        //public float ExpectedPointsContributed { get; set; }
    }
}
