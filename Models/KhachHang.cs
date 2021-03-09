using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PTPMQL3.Models
{[Table("KhachHangs")]
    public class KhachHang
    {
        [Key]
        public string KhachHangID { get; set; }
        public string TenKhachHang { get; set; }
        public string DiaChi { get; set; }
    }
}