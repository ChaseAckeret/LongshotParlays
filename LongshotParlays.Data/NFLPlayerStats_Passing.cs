using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public class NFLPlayerStats_Passing
    {
        [Key, ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }
        public virtual NFLPlayerInfo Player { get; set; }

        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string FullName { get; set; }

        public int Rank { get; set; }
        public int GamesPlayed { get; set; }
        public int GamesStarted { get; set; }
        public int Completions { get; set; }
        public int Attempts { get; set; }
        public float CompletionPrecentage { get; set; }
        public int Yards { get; set; }
        public int Touchdowns { get; set; }
        public float TouchdownPercentage { get; set; }
        public int Interceptions { get; set; }
        public float InterceptionPercentage { get; set; }
        public int FirstDowns { get; set; }
        public int LongestPass { get; set; }
        public float YardsPerAttempt { get; set; }
        public float AdjustedYardsPerAttempt { get; set; }
        public float YardsPerCompletion { get; set; }
        public float Rating { get; set; }
        public float TotalQuarterbackRating { get; set; }
        public int SacksTaken { get; set; }
        public int YardsLostBySacks { get; set; }
        public float NetYardsPerAttempt { get; set; }
        public float AdjustedNetYardsPerAttempt { get; set; }
        public float SackPercentage { get; set; }
        public int FourthQuarterComebacks { get; set; }
        public int GameWinnigDrives { get; set; }
    }
}
