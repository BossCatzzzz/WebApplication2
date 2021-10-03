using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoaiSPController : Controller
    {
        Model2DataContext db = new Model2DataContext();
        // GET: LoaiSP
        public ActionResult Index()
        {
            
            List<LOAISANPHAM> list = db.LOAISANPHAMs.ToList();
            return View(list);
        }
        public ActionResult Details(int id)
        {
            
            LOAISANPHAM lsp = db.LOAISANPHAMs.FirstOrDefault(i => i.ID == id);
            return View(lsp);
        }
        public ActionResult SanPhams(int? IDloaisp)
        {
            if(IDloaisp==null)
            {
                return View(db.SANPHAMs.ToList());
            }
            List<SANPHAM> dssp = db.SANPHAMs.Where(i => i.ID_LOAI == IDloaisp).ToList();
            return View(dssp);
        }

        public ActionResult ThemLoaiSP()
        {
            if(Request.Form.Count>0)
            {
                String maloaisp = Request.Form["MALOAI"];
                String tenloai = Request.Form["TENLOAI"];

                LOAISANPHAM loaispmoi = new LOAISANPHAM();
                loaispmoi.MALOAI = maloaisp;
                loaispmoi.TENLOAI = tenloai;
                db.LOAISANPHAMs.InsertOnSubmit(loaispmoi);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}