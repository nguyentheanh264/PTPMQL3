namespace PTPMQL3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_QuanLyHangHoa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanLyHangHoas",
                c => new
                    {
                        MaHangHoa = c.String(nullable: false, maxLength: 128),
                        TenHangHoa = c.String(),
                        PhanLoaiHH = c.String(),
                        CanNang = c.Int(nullable: false),
                        NgayLayHang = c.DateTime(nullable: false),
                        NgayGiaoHang = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaHangHoa);
            
            CreateTable(
                "dbo.QuanLyNhanViens",
                c => new
                    {
                        IDNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        TienLuong = c.Int(nullable: false),
                        PhuCap = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDNhanVien);
            
            AddColumn("dbo.KhachHangs", "SoDienThoai", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.KhachHangs", "SoDienThoai");
            DropTable("dbo.QuanLyNhanViens");
            DropTable("dbo.QuanLyHangHoas");
        }
    }
}
