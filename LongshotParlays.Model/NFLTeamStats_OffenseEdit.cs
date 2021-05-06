using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLTeamStats_OffenseEdit
    {
        public int TeamId { get; set; }
        public virtual NFLTeamInfo Team { get; set; }
        public int GamesPlayed { get; set; }
        public int PointsForced { get; set; }
    }
}
