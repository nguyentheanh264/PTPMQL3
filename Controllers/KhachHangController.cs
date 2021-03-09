using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PTPMQL3.Models;

namespace PTPMQL3.Controllers
{
    public class KhachHangController : Controller
    {
        // khai báo  đối tượng kết nối tới database
        DemoDbcontext db = new DemoDbcontext();
        // GET: KhachHang
        public ActionResult Index()
        {
            return View();
        }
    }
}