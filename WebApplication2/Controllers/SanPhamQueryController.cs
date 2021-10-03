using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class SanPhamQueryController : Controller
    {
        Model2DataContext db = new Model2DataContext();
        public ActionResult Index()
        {
            List<LayAllSPResult> list = db.LayAllSP().ToList();
            return View(list);
        }

        public ActionResult LaySPTheoMa(string id)
        {
            LayMotSPResult sp = db.LayMotSP(id).FirstOrDefault();
            return View(sp);
        }

        //public ActionResult LayAllSP()
        //{
        //    List<LayAllSPResult> list = db.LayAllSP().ToList();
        //    return View(list);
        //}

        public ActionResult ThemSanPham()
        {
            if (Request.Form.Count > 0)
            {
                HttpPostedFileBase file = Request.Files["HINHANH"];
                string filename = null;
                if (file != null)
                {
                    string serverPath = HttpContext.Server.MapPath("~/Images");
                    String filepath = serverPath + "/" + file.FileName;
                    file.SaveAs(filepath);
                    filename = file.FileName;
                }
                db.ThemSP(Request.Form["MASANPHAM"], Request.Form["TENSANPHAM"], int.Parse(Request.Form["ID_LOAI"]), filename, int.Parse(Request.Form["DONGIA"]));
                return RedirectToAction("Index");

            }
            return View();
        }

        public ActionResult CapNhatGia(String id, int gia)
        {
            db.CapNhatGia(id, gia);
            return RedirectToAction("Index");
        }

        public ActionResult XoaSP(string id)
        {
            db.XoaSP(id);
            return RedirectToAction("Index");
        }
    }
}