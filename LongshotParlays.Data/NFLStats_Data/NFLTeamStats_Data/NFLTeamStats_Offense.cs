using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public class NFLTeamStats_Offense
    {
        [Key, ForeignKey(nameof(Team))]
        public int TeamId { get; set; }
        public virtual NFLTeamInfo Team { get; set; }

        public int GamesPlayed { get; set; }
        public int PointsForced { get; set; }
        //public int YardsGained { get; set; }
        //public int TotalPlaysRan { get; set; }
        //public float YardsPerPlay { get; set; }
        //public int Turnovers { get; set; }
        //public int FumblesLost { get; set; }
        //public int FirstDowns { get; set; }
        //public int Completions { get; set; }
        //public int PassingAttempts { get; set; }
        //public int PassingYards { get; set; }
        //public int PassingTouchdowns { get; set; }
        //public int InterceptionsThrown { get; set; }
        //public float NetPassingYardsPerAttempt { get; set; }
        //public int PassingFirstDowns { get; set; }
        //public int RushingAttempts { get; set; }
        //public int RushingYards { get; set; }
        //public int RushingTouchdowns { get; set; }
        //public float RushingYardsPerAttempt { get; set; }
        //public int RushingFirstDowns { get; set; }
        //public int Penalties { get; set; }
        //public int PenaltyYards { get; set; }
        //public int PenaltyFirstDowns { get; set; }
        //public float DrivesEndingInScorePercentage { get; set; }
        //public float DrivesEndingInTurnoverPercentage { get; set; }
        //public float ExpectedPointsContributed { get; set; }
    }
}
