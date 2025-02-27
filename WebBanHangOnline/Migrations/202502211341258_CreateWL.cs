namespace WebBanHangOnline.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class CreateWL : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.tb_Wishlist", newName: "Wishlists");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.Wishlists", newName: "tb_Wishlist");
        }
    }
}
