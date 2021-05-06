namespace LongshotParlays.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTeamStatsTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.NFLTeamStats_Defense", "YardsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "TotalPlays");
            DropColumn("dbo.NFLTeamStats_Defense", "YardsAllowedPerPlay");
            DropColumn("dbo.NFLTeamStats_Defense", "Takeaways");
            DropColumn("dbo.NFLTeamStats_Defense", "FumblesLost");
            DropColumn("dbo.NFLTeamStats_Defense", "FirstDownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "CompletionsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "PassingAttemptsDefended");
            DropColumn("dbo.NFLTeamStats_Defense", "PassingYardsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "PassingTouchdownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "Interceptions");
            DropColumn("dbo.NFLTeamStats_Defense", "NetYardsPerAttemptAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "PassingFirstDownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "RushingAttemptsDefended");
            DropColumn("dbo.NFLTeamStats_Defense", "RushingYardsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "RushingTouchdownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "RushingYardsPerAttemptAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "RushingFirstDownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "Penalties");
            DropColumn("dbo.NFLTeamStats_Defense", "PenaltyYards");
            DropColumn("dbo.NFLTeamStats_Defense", "PenaltyFirstDownsAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "DrivesEndingInScoreAllowed");
            DropColumn("dbo.NFLTeamStats_Defense", "DrivesEndingInTakeaway");
            DropColumn("dbo.NFLTeamStats_Defense", "ExpectedPointsContributed");
            DropColumn("dbo.NFLTeamStats_Offense", "YardsGained");
            DropColumn("dbo.NFLTeamStats_Offense", "TotalPlaysRan");
            DropColumn("dbo.NFLTeamStats_Offense", "YardsPerPlay");
            DropColumn("dbo.NFLTeamStats_Offense", "Turnovers");
            DropColumn("dbo.NFLTeamStats_Offense", "FumblesLost");
            DropColumn("dbo.NFLTeamStats_Offense", "FirstDowns");
            DropColumn("dbo.NFLTeamStats_Offense", "Completions");
            DropColumn("dbo.NFLTeamStats_Offense", "PassingAttempts");
            DropColumn("dbo.NFLTeamStats_Offense", "PassingYards");
            DropColumn("dbo.NFLTeamStats_Offense", "PassingTouchdowns");
            DropColumn("dbo.NFLTeamStats_Offense", "InterceptionsThrown");
            DropColumn("dbo.NFLTeamStats_Offense", "NetPassingYardsPerAttempt");
            DropColumn("dbo.NFLTeamStats_Offense", "PassingFirstDowns");
            DropColumn("dbo.NFLTeamStats_Offense", "RushingAttempts");
            DropColumn("dbo.NFLTeamStats_Offense", "RushingYards");
            DropColumn("dbo.NFLTeamStats_Offense", "RushingTouchdowns");
            DropColumn("dbo.NFLTeamStats_Offense", "RushingYardsPerAttempt");
            DropColumn("dbo.NFLTeamStats_Offense", "RushingFirstDowns");
            DropColumn("dbo.NFLTeamStats_Offense", "Penalties");
            DropColumn("dbo.NFLTeamStats_Offense", "PenaltyYards");
            DropColumn("dbo.NFLTeamStats_Offense", "PenaltyFirstDowns");
            DropColumn("dbo.NFLTeamStats_Offense", "DrivesEndingInScorePercentage");
            DropColumn("dbo.NFLTeamStats_Offense", "DrivesEndingInTurnoverPercentage");
            DropColumn("dbo.NFLTeamStats_Offense", "ExpectedPointsContributed");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NFLTeamStats_Offense", "ExpectedPointsContributed", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "DrivesEndingInTurnoverPercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "DrivesEndingInScorePercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PenaltyFirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PenaltyYards", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "Penalties", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "RushingFirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "RushingYardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "RushingTouchdowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "RushingYards", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "RushingAttempts", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PassingFirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "NetPassingYardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "InterceptionsThrown", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PassingTouchdowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PassingYards", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "PassingAttempts", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "Completions", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "FirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "FumblesLost", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "Turnovers", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "YardsPerPlay", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "TotalPlaysRan", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Offense", "YardsGained", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "ExpectedPointsContributed", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "DrivesEndingInTakeaway", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "DrivesEndingInScoreAllowed", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PenaltyFirstDownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PenaltyYards", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "Penalties", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "RushingFirstDownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "RushingYardsPerAttemptAllowed", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "RushingTouchdownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "RushingYardsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "RushingAttemptsDefended", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PassingFirstDownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "NetYardsPerAttemptAllowed", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "Interceptions", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PassingTouchdownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PassingYardsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "PassingAttemptsDefended", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "CompletionsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "FirstDownsAllowed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "FumblesLost", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "Takeaways", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "YardsAllowedPerPlay", c => c.Single(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "TotalPlays", c => c.Int(nullable: false));
            AddColumn("dbo.NFLTeamStats_Defense", "YardsAllowed", c => c.Int(nullable: false));
        }
    }
}
