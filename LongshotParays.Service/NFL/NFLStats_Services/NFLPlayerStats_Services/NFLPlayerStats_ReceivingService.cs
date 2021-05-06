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
    public class NFLPlayerStats_ReceivingService
    {
        private readonly Guid _userId;

        public NFLPlayerStats_ReceivingService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateReceivingStats(NFLPlayerStats_ReceivingCreate model)
        {
            var entity =
                new NFLPlayerStats_Receiving()
                {
                    Targets = model.Targets,
                    Receptions = model.Receptions,
                    Touchdowns = model.Touchdowns
                };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.NFLPlayer_Receiving.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLPlayerStats_ReceivingListItem> GetReceivingStats()
        {
            using(var ctx= new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NFLPlayer_Receiving
                        .Select(e =>
                                    new NFLPlayerStats_ReceivingListItem
                                    {
                                        PlayerId = e.PlayerId,
                                        Targets=e.Targets,
                                        Receptions=e.Receptions,
                                        Touchdowns=e.Touchdowns,
                                    }
                        );
                return query.ToArray();
            }
        }

        public NFLPlayerStats_ReceivingDetails GetReceivingStatsById(int id)
        {
            using(var ctx= new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Receiving
                        .Single(e => e.PlayerId == id);
                return
                    new NFLPlayerStats_ReceivingDetails
                    {
                        PlayerId = entity.PlayerId,
                        Targets = entity.Targets,
                        Receptions = entity.Receptions,
                        Touchdowns = entity.Touchdowns
                    };
            }
        }

        public bool UpdateReceivingStats(NFLPlayerStats_ReceivingEdit model)
        {
            using(var ctx=new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Receiving
                        .Single(e => e.PlayerId == model.PlayerId);

                entity.Targets = model.Targets;
                entity.Receptions = model.Receptions;
                entity.Touchdowns = model.Touchdowns;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteReceivingStats(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLPlayer_Receiving
                        .Single(e => e.PlayerId == id);

                ctx.NFLPlayer_Receiving.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
