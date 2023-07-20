namespace KafeOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminDBs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.SiparislerDBs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MasaNo = c.Int(nullable: false),
                        Siparis = c.String(),
                        Fiyat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SiparislerDBs");
            DropTable("dbo.AdminDBs");
        }
    }
}
