using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public class NFLPlayerInfo
    {
        [Key]
        public int PlayerId { get; set; }
        public virtual NFLPlayerStats_Rushing RushingStats { get; set; }
        public virtual NFLPlayerStats_Passing PassingStats { get; set; }
        public virtual NFLPlayerStats_Receiving ReceivingStats { get; set; }
        public virtual NFLTeamInfo Team { get; set; }
        [ForeignKey(nameof(Team))]
        public int TeamId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int Age { get; set; }

        [Required]
        public string Position { get; set; }

        public string InjuryStatus { get; set; }


    }
}
