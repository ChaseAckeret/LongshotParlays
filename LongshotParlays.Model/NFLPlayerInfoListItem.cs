using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerInfoListItem
    {
        public int PlayerId { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }
        public string Position { get; set; }
        public string Team { get; set; }
        public string InjuryStatus { get; set; }

    }
}
