﻿namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateLinkPC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "Link");
        }
    }
}
