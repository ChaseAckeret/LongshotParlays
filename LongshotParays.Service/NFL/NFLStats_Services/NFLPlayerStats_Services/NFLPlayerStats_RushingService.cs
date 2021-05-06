using LongshotParlays.Data;
using LongshotParlays.Model;
using LongshotParlays.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongshotParays.Service
{
    public class NFLPlayerStats_RushingService
    {
        private readonly Guid _userId;

        public NFLPlayerStats_RushingService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRushingStats(NFLPlayerStats_RushingCreate model)
        {
            var entity =
                new NFLPlayerStats_Rushing()
                {
                    Attempts = model.Attempts,
                    Yards = model.Yards,
                    Touchdowns = model.Touchdowns
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.NFLPlayer_Rushing.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLPlayerStats_RushingListItem> GetRushingStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NFLPlayer_Rushing
                        .Select(e =>
                                    new NFLPlayerStats_RushingListItem
                                    {
                                        PlayerId = e.PlayerId,
                                        Attempts=e.Attempts,
                                        Yards=e.Yards,
                                        Touchdowns=e.Touchdowns
                                    }
                        );
                return query.ToArray();
            }
        }

        public NFLPlayerStats_RushingDetail GetRushingStatsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Rushing
                        .Single(e => e.PlayerId == id);
                return
                    new NFLPlayerStats_RushingDetail
                    {
                        PlayerId = entity.PlayerId,
                        Attempts = entity.Attempts,
                        Yards = entity.Yards,
                        Touchdowns = entity.Touchdowns
                    };
            }
        }

        public bool UpdateRushingStats(NFLPlayerStats_RushingEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Rushing
                        .Single(e => e.PlayerId == model.PlayerId);

                entity.Attempts = model.Attempts;
                entity.Yards = model.Yards;
                entity.Touchdowns = model.Touchdowns;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteRushingStats(int id)
        {
            using(var ctx= new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Rushing
                        .Single(e => e.PlayerId == id);

                ctx.NFLPlayer_Rushing.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
