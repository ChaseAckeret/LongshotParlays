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
    public class NFLTeamStats_DefenseService
    {
        private readonly Guid _userId;

        public NFLTeamStats_DefenseService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateDefenseStats(NFLTeamStats_DefenseCreate model)
        {
            var entity =
                new NFLTeamStats_Defense()
                {
                    TeamId = model.TeamId,
                    Team = model.Team,
                    GamesPlayed = model.GamesPlayed,
                    PointsAllowed = model.PointsAllowed
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.NFLTeam_Defense.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLTeamStats_DefenseListItem> GetDefenseStats()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .NFLTeam_Defense
                        .Select(
                            e =>
                                new NFLTeamStats_DefenseListItem
                                {
                                    TeamId = e.TeamId,
                                    Team = e.Team,
                                    GamesPlayed = e.GamesPlayed,
                                    PointsAllowed = e.PointsAllowed
                                }
                        );

                return query.ToArray();
                       
            }
        }

        public NFLTeamStats_DefenseDetail GetDefenseStatsById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Defense
                        .Single(e => e.TeamId == id);
                return
                    new NFLTeamStats_DefenseDetail
                    {
                        TeamId = entity.TeamId,
                        Team = entity.Team,
                        GamesPlayed = entity.GamesPlayed,
                        PointsAllowed=entity.PointsAllowed
                    };
                            
            }
        }

        public bool UpdateDefenseStats(NFLTeamStats_DefenseEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Defense
                        .Single(e => e.TeamId == model.TeamId);

                entity.Team = model.Team;
                entity.GamesPlayed = model.GamesPlayed;
                entity.PointsAllowed = model.PointsAllowed;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteDefenseStats(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .NFLTeam_Defense
                        .Single(e => e.TeamId == id);

                ctx.NFLTeam_Defense.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
