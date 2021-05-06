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
     public class NFLTeamStats_OffenseService
    {
        private readonly Guid _userId;

        public NFLTeamStats_OffenseService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateOffenseStats(NFLTeamStats_OffenseCreate model)
        {
            var entity =
                new NFLTeamStats_Offense()
                {
                    TeamId = model.TeamId,
                    Team = model.Team,
                    GamesPlayed = model.GamesPlayed,
                    PointsForced = model.PointsForced
                };

            using (var ctx=new ApplicationDbContext())
            {
                ctx.NFLTeam_Offense.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLTeamStats_OffenseListItem> GetOffenseStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NFLTeam_Offense
                        .Select(
                            e =>
                                new NFLTeamStats_OffenseListItem
                                {
                                    TeamId = e.TeamId,
                                    Team = e.Team,
                                    GamesPlayed = e.GamesPlayed,
                                    PointsForced = e.PointsForced
                                }
                        );

                return query.ToArray();
            }
        }

        public NFLTeamStats_OffenseDetail GetOffenseStatsById(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Offense
                        .Single(e => e.TeamId == id);
                return
                    new NFLTeamStats_OffenseDetail
                    {
                        TeamId = entity.TeamId,
                        Team = entity.Team,
                        GamesPlayed = entity.GamesPlayed,
                        PointsForced = entity.PointsForced
                    };

                      
            }
        }

        public bool UpdateOffenseStats(NFLTeamStats_OffenseEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Offense
                        .Single(e => e.TeamId == model.TeamId);

                entity.Team = model.Team;
                entity.GamesPlayed = model.GamesPlayed;
                entity.PointsForced = model.PointsForced;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteOffenseStats(int id)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Offense
                        .Single(e => e.TeamId == id);

                ctx.NFLTeam_Offense.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
