using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLTeamInfoCreate
    {
        public virtual NFLTeamInfoListItem Team { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public string City { get; set; }
        public string Stadium { get; set; }
        public string Division { get; set; }
        public string HeadCoach { get; set; }
    }
}
