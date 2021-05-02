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
    public class NFLTeamInfoService
    {
        private readonly Guid _userId;

        public NFLTeamInfoService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateTeam(NFLTeamInfoCreate model)
        {
            var entity =
                new NFLTeamInfo()
                {
                    Name = model.Name,
                    Abbreviation = model.Abbreviation,
                    City = model.City,
                    Division = model.Division,
                    HeadCoach = model.HeadCoach,
                    Stadium = model.Stadium
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.TeamInfo.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLTeamInfoListItem> GetTeams()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .TeamInfo
                        .Select(
                            e =>
                                new NFLTeamInfoListItem
                                {
                                    TeamId = e.TeamId,
                                    Name = e.Name,
                                }
                         );
                return query.ToArray();
            }
        }

        public NFLTeamInfoDetail GetTeamById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .TeamInfo
                        .Single(e => e.TeamId == id);
                return
                new NFLTeamInfoDetail
                {
                    TeamId = entity.TeamId,
                    Name = entity.Name,
                    Abbreviation = entity.Abbreviation,
                    City = entity.City,
                    Stadium = entity.Stadium,
                    Conference = entity.Conference,
                    Division = entity.Division,
                    HeadCoach = entity.HeadCoach
                };
            }
        }

        public bool UpdateNFLTeamInfo (NFLTeamInfoEdit model)
        {
            using (var ctx =new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .TeamInfo
                        .Single(e => e.TeamId == model.TeamId);

                entity.Name = model.Name;
                entity.City = model.City;
                entity.Abbreviation = model.Abbreviation;
                entity.Conference = model.Conference;
                entity.Division = model.Division;
                entity.Stadium = model.Stadium;
                entity.HeadCoach = model.HeadCoach;

                return ctx.SaveChanges() == 1;    
            }
        }

        public bool DeleteNFLTeamInfo(int teamId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .TeamInfo
                        .Single(e => e.TeamId == teamId);

                ctx.TeamInfo.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
