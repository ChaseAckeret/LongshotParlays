using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerStats_ReceivingListItem
    {
        public int PlayerId { get; set; }
        public virtual NFLPlayerInfo Player { get; set; }
        public int Targets { get; set; }
        public int Receptions { get; set; }
        public int Touchdowns { get; set; }

    }
}
