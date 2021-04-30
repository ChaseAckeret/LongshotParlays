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
    public class NFLPlayerInfoService
    {
        private readonly Guid _userId;

        public NFLPlayerInfoService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreatePlayer(NFLPlayerInfoCreate model)
        {
            var entity =
                new NFLPlayerInfo()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Position = model.Position,
                    Team = model.Team,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.PlayerInfo.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<NFLPlayerInfoListItem> GetPlayers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .PlayerInfo
                        .Select(
                                e =>
                                    new NFLPlayerInfoListItem
                                    {
                                        PlayerId = e.PlayerId,
                                        FullName = e.FirstName + e.LastName,
                                        Position = e.Position,
                                        Team = e.Team.Name,
                                        InjuryStatus = e.InjuryStatus
                                    }
                                );
                return query.ToArray();
            }

        }

        public NFLPlayerInfoDetail GetPlayerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerInfo
                        .Single(e => e.PlayerId == id);
                return
                    new NFLPlayerInfoDetail
                    {
                        PlayerId = entity.PlayerId,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,
                        Age = entity.Age,
                        Team = entity.Team,
                        Position = entity.Position,
                        InjuryStatus = entity.InjuryStatus,
                    };
            }
        }

        public bool UpdateNFLPlayerInfo(NFLPlayerInfoEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerInfo
                        .Single(e => e.PlayerId == model.PlayerId);

                entity.FirstName = model.FirstName;
                entity.LastName = model.LastName;
                entity.Position = model.Position;
                entity.Team = model.Team;
                entity.Age = model.Age;
                entity.InjuryStatus = model.InjuryStatus;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePlayer(int playerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .PlayerInfo
                        .Single(e => e.PlayerId == playerId);

                ctx.PlayerInfo.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
