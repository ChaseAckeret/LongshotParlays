namespace LongshotParlays.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPlayerStats : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.NFLPlayerStatsPassing", newName: "NFLPlayerStats_Passing");
            DropColumn("dbo.NFLPlayerStats_Receiving", "Rank");
            DropColumn("dbo.NFLPlayerStats_Receiving", "GamesPlayed");
            DropColumn("dbo.NFLPlayerStats_Receiving", "GamesStarted");
            DropColumn("dbo.NFLPlayerStats_Receiving", "CatchPercentage");
            DropColumn("dbo.NFLPlayerStats_Receiving", "YardsPerReception");
            DropColumn("dbo.NFLPlayerStats_Receiving", "FirstDowns");
            DropColumn("dbo.NFLPlayerStats_Receiving", "LongestReception");
            DropColumn("dbo.NFLPlayerStats_Receiving", "YardsPerTarget");
            DropColumn("dbo.NFLPlayerStats_Receiving", "ReceptionsPerGame");
            DropColumn("dbo.NFLPlayerStats_Receiving", "YardsPerGame");
            DropColumn("dbo.NFLPlayerStats_Receiving", "Fumbles");
            DropColumn("dbo.NFLPlayerStats_Rushing", "Rank");
            DropColumn("dbo.NFLPlayerStats_Rushing", "GamesPlayed");
            DropColumn("dbo.NFLPlayerStats_Rushing", "GamesStarted");
            DropColumn("dbo.NFLPlayerStats_Rushing", "FirstDowns");
            DropColumn("dbo.NFLPlayerStats_Rushing", "LongestRush");
            DropColumn("dbo.NFLPlayerStats_Rushing", "YardsPerAttempt");
            DropColumn("dbo.NFLPlayerStats_Rushing", "YardsPerGame");
            DropColumn("dbo.NFLPlayerStats_Rushing", "Fumbles");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NFLPlayerStats_Rushing", "Fumbles", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "YardsPerGame", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "YardsPerAttempt", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "LongestRush", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "FirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "GamesStarted", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "GamesPlayed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Rushing", "Rank", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "Fumbles", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "YardsPerGame", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "ReceptionsPerGame", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "YardsPerTarget", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "LongestReception", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "FirstDowns", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "YardsPerReception", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "CatchPercentage", c => c.Single(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "GamesStarted", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "GamesPlayed", c => c.Int(nullable: false));
            AddColumn("dbo.NFLPlayerStats_Receiving", "Rank", c => c.Int(nullable: false));
            RenameTable(name: "dbo.NFLPlayerStats_Passing", newName: "NFLPlayerStatsPassing");
        }
    }
}
