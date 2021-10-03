using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SanPhamController : Controller
    {
        Model2DataContext db = new Model2DataContext();
        // GET: SanPham
        public ActionResult Index(FormCollection cl)
        {
            List<SANPHAM> list = null;
            if (cl.Count == 0)
            {
                list = db.SANPHAMs.ToList();
            }
            else
            {
                double min = double.Parse(cl["txtMin"]);
                double max = double.Parse(cl["txtMax"]);
                list = db.SANPHAMs.Where(i => i.DONGIA >= min && i.DONGIA <= max).ToList();
            }
            return View(list);
        }

        //public ActionResult Index()                                       // này khi form là methol="get"
        //{
        //    List<SANPHAM> list = null;
        //    if (Request.QueryString.Count == 0)
        //    {
        //        list = db.SANPHAMs.ToList();
        //    }
        //    else
        //    {
        //        //double min = double.Parse(Request.QueryString["txtMin"]);
        //        //double max = double.Parse(Request.QueryString["txtMax"]);
        //        double min = double.Parse(collection["txtMin"]);
        //        double max = double.Parse(cl["txtMax"]);
        //        list = db.SANPHAMs.Where(i => i.DONGIA >= min && i.DONGIA <= max).ToList();
        //    }
        //    return View(list);
        //}

        public ActionResult Details(int id)
        {
            SANPHAM sp = db.SANPHAMs.FirstOrDefault(i => i.ID == id);
            return View(sp);
        }

        public ActionResult Them_SanPham()
        {
            if (Request.Form.Count > 0)
            {

                SANPHAM spmoi = new SANPHAM();
                spmoi.ID_LOAI= int.Parse(Request.Form["ID_LOAI"]);
                spmoi.TENSANPHAM= Request.Form["TENSANPHAM"];
                spmoi.MASANPHAM= Request.Form["MASANPHAM"];
                
                HttpPostedFileBase file = Request.Files["HINHANH"];
                if(file!=null)
                {
                    string serverpath = HttpContext.Server.MapPath("~/Images");
                    string filepath = serverpath + "/" + file.FileName;
                    file.SaveAs(filepath);
                    spmoi.HINHANH = file.FileName;
                }
                spmoi.DONGIA = int.Parse(Request.Form["DONGIA"]);
                db.SANPHAMs.InsertOnSubmit(spmoi);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Xoa(int id)
        {
            SANPHAM sp = db.SANPHAMs.FirstOrDefault(i => i.ID == id);
            db.SANPHAMs.DeleteOnSubmit(sp);
            db.SubmitChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            SANPHAM edit = db.SANPHAMs.FirstOrDefault(i => i.ID == id);

            if (Request.Form.Count == 0)
            {
                return View(edit);
            }
           
            edit.TENSANPHAM = Request.Form["TENSANPHAM"];
            edit.MASANPHAM = Request.Form["MASANPHAM"];
            edit.DONGIA = int.Parse(Request.Form["DONGIA"]);
            edit.ID_LOAI = int.Parse(Request.Form["ID_LOAI"]);
            HttpPostedFileBase file = Request.Files["HINHANH"];
            if (file != null && file.FileName != "")
            {
                String serverpath = HttpContext.Server.MapPath("~/Images");
                String filepath = serverpath + "/" + file.FileName;
                file.SaveAs(filepath);
                edit.HINHANH = file.FileName;
            }
            db.SubmitChanges();
            return RedirectToAction("Index");
        }


        //================================================================================

        public ActionResult LaySPTheoMa(string id)
        {
            LayMotSPResult sp = db.LayMotSP(id).FirstOrDefault();
            return View(sp);
        }

        public ActionResult LayAllSP()
        {
            List<LayAllSPResult> list = db.LayAllSP().ToList();
            return View(list);
        }

        public ActionResult ThemSanPham()
        {
            if(Request.Form.Count>0)
            {
                HttpPostedFileBase file = Request.Files["HINHANH"];
                string filename = null;
                if(file!=null)
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

        public ActionResult CapNhatGia(String id)
        {
            int gia_new = int.Parse(Request.Form["txtGia"]);
            db.CapNhatGia(id, gia_new);
            return RedirectToAction("Index");
        }

        public ActionResult XoaSP(string id)
        {
            db.XoaSP(id);
            return RedirectToAction("Index");
        }

    }
}