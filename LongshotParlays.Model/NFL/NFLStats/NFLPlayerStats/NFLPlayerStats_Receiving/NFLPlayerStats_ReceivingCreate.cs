using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerStats_ReceivingCreate
    {
        public int playerid { get; set; }
        public int Targets { get; set; }
        public int Receptions { get; set; }
        public int Yards { get; set; }
        public int Touchdowns { get; set; }
    }
}
