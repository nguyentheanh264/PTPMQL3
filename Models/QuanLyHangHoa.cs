using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL3.Models
{
    [Table("QuanLyHangHoas")]
    public class QuanLyHangHoa
    {
        [Key]
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public string PhanLoaiHH { get; set; }
        public int CanNang { get; set; }
        public DateTime NgayLayHang { get; set; }
        public DateTime NgayGiaoHang { get; set; }
    }
}