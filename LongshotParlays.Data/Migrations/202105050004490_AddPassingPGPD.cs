namespace LongshotParlays.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPassingPGPD : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NFLPlayerStats_Passing", newName: "NFLPlayerStatsPassing");
            DropColumn("dbo.NFLPlayerStatsPassing", "Rank");
            DropColumn("dbo.NFLPlayerStatsPassing", "GamesPlayed");
            DropColumn("dbo.NFLPlayerStatsPassing", "GamesStarted");
            DropColumn("dbo.NFLPlayerStatsPassing", "CompletionPrecentage");
            DropColumn("dbo.NFLPlayerStatsPassing", "Touchdowns");
            DropColumn("dbo.NFLPlayerStatsPassing", "TouchdownPercentage");
            DropColumn("dbo.NFLPlayerStatsPassing", "Interceptions");
            DropColumn("dbo.NFLPlayerStatsPassing", "InterceptionPercentage");
            DropColumn("dbo.NFLPlayerStatsPassing", "FirstDowns");
            DropColumn("dbo.NFLPlayerStatsPassing", "LongestPass");
            DropColumn("dbo.NFLPlayerStatsPassing", "YardsPerAttempt");
            DropColumn("dbo.NFLPlayerStatsPassing", "AdjustedYardsPerAttempt");
            DropColumn("dbo.NFLPlayerStatsPassing", "YardsPerCompletion");
            DropColumn("dbo.NFLPlayerStatsPassing", "Rating");
            DropColumn("dbo.NFLPlayerStatsPassing", "TotalQuarterbackRating");
            DropColumn("dbo.NFLPlayerStatsPassing", "SacksTaken");
            DropColumn("dbo.NFLPlayerStatsPassing", "YardsLostBySacks");
            DropColumn("dbo.NFLPlayerStatsPassing", "NetYardsPerAttempt");
            DropColumn("dbo.NFLPlayerStatsPassing", "AdjustedNetYardsPerAttempt");
            DropColumn("dbo.NFLPlayerStatsPassing", "SackPercentage");
            DropColumn("dbo.NFLPlayerStatsPassing", "FourthQuarterComebacks");
            DropColumn("dbo.NFLPlayerStatsPassing", "GameWinnigDrives");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NFLPlayerStatsPassing", "GameWinnigDrives", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "FourthQuarterComebacks", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "SackPercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "AdjustedNetYardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "NetYardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "YardsLostBySacks", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "SacksTaken", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "TotalQuarterbackRating", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "Rating", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "YardsPerCompletion", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "AdjustedYardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "YardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "LongestPass", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "FirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "InterceptionPercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "Interceptions", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "TouchdownPercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "Touchdowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "CompletionPrecentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "GamesStarted", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "GamesPlayed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStatsPassing", "Rank", c => c.Int(nullable: false));
            RenameTable(name: "dbo.NFLPlayerStatsPassing", newName: "NFLPlayerStats_Passing");
        }
    }
}
