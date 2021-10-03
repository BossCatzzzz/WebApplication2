using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Windows;
using WebTinTuc.Models;

namespace WebTinTuc.Controllers
{
    public class TheLoaiController : Controller
    {
        TinTucModelDataContext db = new TinTucModelDataContext();
        public ActionResult Index()
        {
            List<TheLoaiTin> list = db.TheLoaiTins.ToList();

            return View(list);
        }
        public ActionResult Details(int id)
        {
            TheLoaiTin lsp = db.TheLoaiTins.FirstOrDefault(i => i.MaLoai == id);
            return View(lsp);
        }



        public ActionResult Edit(int id)
        {
            if (Request.Form.Count > 0)
            {
                if (Request.Form["TenTheLoai"].Trim() == "")
                {
                    var result = System.Windows.MessageBox.Show("Không được để trống");
                    return View();
                }
                TheLoaiTin theloaitin = db.TheLoaiTins.FirstOrDefault(tl => tl.MaLoai == id);
                theloaitin.TenTheLoai = Request.Form["TenTheLoai"];
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Create()
        {
            if (Request.Form.Count > 0)
            {
                string s = Request.Form["TenTheLoai"].Trim();
                string tentl = db.TheLoaiTins.FirstOrDefault(i => i.TenTheLoai == s).TenTheLoai;
                if (tentl!=null )
                {
                    var result = System.Windows.MessageBox.Show("Không được trùng");
                    return View();
                }
                String TenP = Request.Form["TenTheLoai"];
                TheLoaiTin pb = new TheLoaiTin();

                pb.TenTheLoai = TenP;
                db.TheLoaiTins.InsertOnSubmit(pb);
                db.SubmitChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            TheLoaiTin nvv = db.TheLoaiTins.FirstOrDefault(x => x.MaLoai == id);
            if (nvv != null)
            {
                db.TheLoaiTins.DeleteOnSubmit(nvv);

                db.SubmitChanges();
            }
            return RedirectToAction("Index");
        }



    }
        
}