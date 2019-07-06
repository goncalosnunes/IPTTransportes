namespace IPTTransportes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NomeEmpresa = c.String(maxLength: 50),
                        Pais = c.String(nullable: false, maxLength: 50),
                        Cidade = c.String(nullable: false, maxLength: 50),
                        Rua = c.String(nullable: false, maxLength: 50),
                        CodigoPostal = c.String(nullable: false, maxLength: 8),
                        NumPorta = c.String(nullable: false, maxLength: 4),
                        NIF = c.String(),
                        Contacto = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Gestors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Utilizadorfk = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadores", t => t.Utilizadorfk)
                .Index(t => t.Utilizadorfk);
            
            CreateTable(
                "dbo.Utilizadores",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 30),
                        Apelido = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Transportadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Utilizadorfk = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilizadores", t => t.Utilizadorfk)
                .Index(t => t.Utilizadorfk);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transportadors", "Utilizadorfk", "dbo.Utilizadores");
            DropForeignKey("dbo.Gestors", "Utilizadorfk", "dbo.Utilizadores");
            DropIndex("dbo.Transportadors", new[] { "Utilizadorfk" });
            DropIndex("dbo.Gestors", new[] { "Utilizadorfk" });
            DropTable("dbo.Transportadors");
            DropTable("dbo.Utilizadores");
            DropTable("dbo.Gestors");
            DropTable("dbo.Clientes");
        }
    }
}
