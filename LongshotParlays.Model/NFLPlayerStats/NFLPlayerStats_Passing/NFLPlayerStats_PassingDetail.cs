using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerStats_PassingDetail
    {
        public int PlayerId { get; set; }
        public virtual NFLPlayerInfo Player { get; set; }
        public int Completions { get; set; }
        public int Attempts { get; set; }
        public int Yards { get; set; }
    }
}
