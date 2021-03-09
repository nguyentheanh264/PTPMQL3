using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL3.Models
{
    [Table("QuanLyNhanViens")]
    public class QuanLyNhanVien
    {
        [Key]
        public string IDNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string ChucVu { get; set; }
        public int TienLuong { get; set; }
        public int PhuCap { get; set; }
    }
}