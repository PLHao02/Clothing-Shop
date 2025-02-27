namespace WebBanHangOnline.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateEveryThing : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Wishlists", newName: "tb_Wishlist");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.tb_Wishlist", newName: "Wishlists");
        }
    }
}
