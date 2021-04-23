using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Data
{
    public  class NFLPlayerInfo
    {
        [Key]
        public int PlayerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public int Age { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Team { get; set; }

        [Required]
        public string InjuryStatus { get; set; }

        public int TeamId { get; set; }
    }
}
