﻿using LongshotParlays.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParlays.Model
{
    public class NFLPlayerStats_PassingListItem
    {
        public int PlayerId { get; set; }

        public virtual NFLPlayerInfo Player { get; set; }

    }
}
