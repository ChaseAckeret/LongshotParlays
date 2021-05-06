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
    public class NFLPlayerStats_PassingService
    {
        private readonly Guid _userId;

        public NFLPlayerStats_PassingService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreatePassingStats(NFLPlayerStats_PassingCreate model)
        {
            var entity =
                new NFLPlayerStats_Passing()
                {
                    PlayerId=model.PlayerId,
                    Player = model.Player,
                    Completions = model.Completions,
                    Attempts = model.Attempts,
                    Yards = model.Yards
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.NFLPlayer_Passing.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLPlayerStats_PassingListItem> GetPlayerPassingStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NFLPlayer_Passing
                        .Select(
                            e =>
                                new NFLPlayerStats_PassingListItem
                                {
                                    PlayerId = e.PlayerId,
                                    Player = e.Player,
                                    Completions=e.Completions,
                                    Attempts=e.Attempts,
                                    Yards=e.Yards
                                }
                     );

                return query.ToArray();
            }
        }

        public NFLPlayerStats_PassingDetail GetPlayerPassingStatsById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Passing
                        .Single(e => e.PlayerId == id);
                return
                    new NFLPlayerStats_PassingDetail
                    {
                        PlayerId = entity.PlayerId,
                        Player = entity.Player,
                        Completions = entity.Completions,
                        Attempts = entity.Attempts,
                        Yards = entity.Yards
                    };
            }
        }

        public bool UpdatePassingStats(NFLPlayerStats_PassingEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Passing
                        .Single(e => e.PlayerId == model.PlayerId);

                entity.Player = model.Player;
                entity.Completions = model.Completions;
                entity.Attempts = model.Attempts;
                entity.Yards = model.Yards;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePlayerPassingStats(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Passing
                        .Single(e => e.PlayerId == id);

                ctx.NFLPlayer_Passing.Remove(entity);

                return ctx.SaveChanges() == 1;
            }

            
        }
    }
}
