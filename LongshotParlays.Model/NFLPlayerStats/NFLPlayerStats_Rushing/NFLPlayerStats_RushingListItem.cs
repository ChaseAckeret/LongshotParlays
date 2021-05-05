using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerStats_RushingListItem
    {
        public int PlayerId { get; set; }
        public virtual NFLPlayerInfo Player { get; set; }
        public int Attempts { get; set; }
        public int Yards { get; set; }
        public int Touchdowns { get; set; }
    }
}
