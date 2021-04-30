namespace LongshotParlays.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NFLPlayerStats_Passing",
                c => new
                    {
                        PlayerId = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        GamesStarted = c.Int(nullable: false),
                        Completions = c.Int(nullable: false),
                        Attempts = c.Int(nullable: false),
                        CompletionPrecentage = c.Single(nullable: false),
                        Yards = c.Int(nullable: false),
                        Touchdowns = c.Int(nullable: false),
                        TouchdownPercentage = c.Single(nullable: false),
                        Interceptions = c.Int(nullable: false),
                        InterceptionPercentage = c.Single(nullable: false),
                        FirstDowns = c.Int(nullable: false),
                        LongestPass = c.Int(nullable: false),
                        YardsPerAttempt = c.Single(nullable: false),
                        AdjustedYardsPerAttempt = c.Single(nullable: false),
                        YardsPerCompletion = c.Single(nullable: false),
                        Rating = c.Single(nullable: false),
                        TotalQuarterbackRating = c.Single(nullable: false),
                        SacksTaken = c.Int(nullable: false),
                        YardsLostBySacks = c.Int(nullable: false),
                        NetYardsPerAttempt = c.Single(nullable: false),
                        AdjustedNetYardsPerAttempt = c.Single(nullable: false),
                        SackPercentage = c.Single(nullable: false),
                        FourthQuarterComebacks = c.Int(nullable: false),
                        GameWinnigDrives = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.NFLPlayerInfo", t => t.PlayerId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.NFLPlayerInfo",
                c => new
                    {
                        PlayerId = c.Int(nullable: false, identity: true),
                        TeamId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Position = c.String(nullable: false),
                        InjuryStatus = c.String(),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.NFLTeamInfo", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.NFLPlayerStats_Receiving",
                c => new
                    {
                        PlayerId = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        GamesStarted = c.Int(nullable: false),
                        Targets = c.Int(nullable: false),
                        Receptions = c.Int(nullable: false),
                        CatchPercentage = c.Single(nullable: false),
                        Yards = c.Int(nullable: false),
                        YardsPerReception = c.Int(nullable: false),
                        Touchdowns = c.Int(nullable: false),
                        FirstDowns = c.Int(nullable: false),
                        LongestReception = c.Int(nullable: false),
                        YardsPerTarget = c.Single(nullable: false),
                        ReceptionsPerGame = c.Single(nullable: false),
                        YardsPerGame = c.Single(nullable: false),
                        Fumbles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.NFLPlayerInfo", t => t.PlayerId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.NFLPlayerStats_Rushing",
                c => new
                    {
                        PlayerId = c.Int(nullable: false),
                        Rank = c.Int(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        GamesStarted = c.Int(nullable: false),
                        Attempts = c.Int(nullable: false),
                        Yards = c.Int(nullable: false),
                        Touchdowns = c.Int(nullable: false),
                        FirstDowns = c.Int(nullable: false),
                        LongestRush = c.Int(nullable: false),
                        YardsPerAttempt = c.Single(nullable: false),
                        YardsPerGame = c.Single(nullable: false),
                        Fumbles = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerId)
                .ForeignKey("dbo.NFLPlayerInfo", t => t.PlayerId)
                .Index(t => t.PlayerId);
            
            CreateTable(
                "dbo.NFLTeamInfo",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Abbreviation = c.String(),
                        City = c.String(),
                        Stadium = c.String(),
                        Conference = c.String(),
                        Division = c.String(),
                        HeadCoach = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            CreateTable(
                "dbo.NFLTeamStats_Defense",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        PointsAllowed = c.Int(nullable: false),
                        YardsAllowed = c.Int(nullable: false),
                        TotalPlays = c.Int(nullable: false),
                        YardsAllowedPerPlay = c.Single(nullable: false),
                        Takeaways = c.Int(nullable: false),
                        FumblesLost = c.Int(nullable: false),
                        FirstDownsAllowed = c.Int(nullable: false),
                        CompletionsAllowed = c.Int(nullable: false),
                        PassingAttemptsDefended = c.Int(nullable: false),
                        PassingYardsAllowed = c.Int(nullable: false),
                        PassingTouchdownsAllowed = c.Int(nullable: false),
                        Interceptions = c.Int(nullable: false),
                        NetYardsPerAttemptAllowed = c.Single(nullable: false),
                        PassingFirstDownsAllowed = c.Int(nullable: false),
                        RushingAttemptsDefended = c.Int(nullable: false),
                        RushingYardsAllowed = c.Int(nullable: false),
                        RushingTouchdownsAllowed = c.Int(nullable: false),
                        RushingYardsPerAttemptAllowed = c.Single(nullable: false),
                        RushingFirstDownsAllowed = c.Int(nullable: false),
                        Penalties = c.Int(nullable: false),
                        PenaltyYards = c.Int(nullable: false),
                        PenaltyFirstDownsAllowed = c.Int(nullable: false),
                        DrivesEndingInScoreAllowed = c.Single(nullable: false),
                        DrivesEndingInTakeaway = c.Single(nullable: false),
                        ExpectedPointsContributed = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.NFLTeamInfo", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.NFLTeamStats_Offense",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        GamesPlayed = c.Int(nullable: false),
                        PointsForced = c.Int(nullable: false),
                        YardsGained = c.Int(nullable: false),
                        TotalPlaysRan = c.Int(nullable: false),
                        YardsPerPlay = c.Single(nullable: false),
                        Turnovers = c.Int(nullable: false),
                        FumblesLost = c.Int(nullable: false),
                        FirstDowns = c.Int(nullable: false),
                        Completions = c.Int(nullable: false),
                        PassingAttempts = c.Int(nullable: false),
                        PassingYards = c.Int(nullable: false),
                        PassingTouchdowns = c.Int(nullable: false),
                        InterceptionsThrown = c.Int(nullable: false),
                        NetPassingYardsPerAttempt = c.Single(nullable: false),
                        PassingFirstDowns = c.Int(nullable: false),
                        RushingAttempts = c.Int(nullable: false),
                        RushingYards = c.Int(nullable: false),
                        RushingTouchdowns = c.Int(nullable: false),
                        RushingYardsPerAttempt = c.Single(nullable: false),
                        RushingFirstDowns = c.Int(nullable: false),
                        Penalties = c.Int(nullable: false),
                        PenaltyYards = c.Int(nullable: false),
                        PenaltyFirstDowns = c.Int(nullable: false),
                        DrivesEndingInScorePercentage = c.Single(nullable: false),
                        DrivesEndingInTurnoverPercentage = c.Single(nullable: false),
                        ExpectedPointsContributed = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TeamId)
                .ForeignKey("dbo.NFLTeamInfo", t => t.TeamId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.NFLPlayerStats_Passing", "PlayerId", "dbo.NFLPlayerInfo");
            DropForeignKey("dbo.NFLPlayerInfo", "TeamId", "dbo.NFLTeamInfo");
            DropForeignKey("dbo.NFLTeamStats_Offense", "TeamId", "dbo.NFLTeamInfo");
            DropForeignKey("dbo.NFLTeamStats_Defense", "TeamId", "dbo.NFLTeamInfo");
            DropForeignKey("dbo.NFLPlayerStats_Rushing", "PlayerId", "dbo.NFLPlayerInfo");
            DropForeignKey("dbo.NFLPlayerStats_Receiving", "PlayerId", "dbo.NFLPlayerInfo");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.NFLTeamStats_Offense", new[] { "TeamId" });
            DropIndex("dbo.NFLTeamStats_Defense", new[] { "TeamId" });
            DropIndex("dbo.NFLPlayerStats_Rushing", new[] { "PlayerId" });
            DropIndex("dbo.NFLPlayerStats_Receiving", new[] { "PlayerId" });
            DropIndex("dbo.NFLPlayerInfo", new[] { "TeamId" });
            DropIndex("dbo.NFLPlayerStats_Passing", new[] { "PlayerId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.NFLTeamStats_Offense");
            DropTable("dbo.NFLTeamStats_Defense");
            DropTable("dbo.NFLTeamInfo");
            DropTable("dbo.NFLPlayerStats_Rushing");
            DropTable("dbo.NFLPlayerStats_Receiving");
            DropTable("dbo.NFLPlayerInfo");
            DropTable("dbo.NFLPlayerStats_Passing");
        }
    }
}
