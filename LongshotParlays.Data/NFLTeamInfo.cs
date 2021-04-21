using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    class NFLTeamInfo
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public string Conference { get; set; }
        public string Division { get; set; }
        public string HeadCoach { get; set; }
    }
}
