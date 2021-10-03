using Lab02_ThucHanh.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02_ThucHanh.Controllers
{
    public class BookController : Controller
    {
        public ActionResult ListBook()
        {
            List<string> list = new List<string>();
            list.Add("truyện ");
            list.Add("truyện 1");
            list.Add("truyện 2");
            list.Add("truyện 3");
            list.Add("truyện 4");
            ViewBag.BookList = list;
            return View();
        }



        public ActionResult ListBookModel()
        {
            /*************************/
            List<Book> list = new List<Book>();
            list.Add(new Book(01,"Sách 1","By me","/Images/sach1.png"));
            list.Add(new Book(02, "Sách 2", "By me", "/Images/sach2.jpg"));
            list.Add(new Book(03, "Sách 3", "By me", "/Images/sach3.jpg"));
            /*************************/
            return View(list);
        }





        public ActionResult Edit(int id)
        {
            /*************************/
            List<Book> list = new List<Book>();
            list.Add(new Book(01, "Sách 1", "By me", "/Images/sach1.png"));
            list.Add(new Book(02, "Sách 2", "By me", "/Images/sach2.jpg"));
            list.Add(new Book(03, "Sách 3", "By me", "/Images/sach3.jpg"));
            /*************************/
            Book here = new Book();
            foreach (Book item in list)
            {
                if (item.Id == id)
                {
                    here = item;
                }
            }

            if (here == null)
            {
                return HttpNotFound();
            }
            return View(here);
        }

        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Edit")]
        public ActionResult Edit(int id,string Title, string Author, string Image_cover)
        {
            /*************************/
            List<Book> list = new List<Book>();
            list.Add(new Book(01, "Sách 1", "By me", "/Images/sach1.png"));
            list.Add(new Book(02, "Sách 2", "By me", "/Images/sach2.jpg"));
            list.Add(new Book(03, "Sách 3", "By me", "/Images/sach3.jpg"));
            /*************************/
            HttpPostedFileBase file = Request.Files["fileImage"];
            if (file.FileName!="")
            {
                string serverpath = HttpContext.Server.MapPath("~/Images");
                string filepath = serverpath + "/" + file.FileName;
                file.SaveAs(filepath);
                Image_cover = "/Images/" + file.FileName;
            }
            if (id==null)
            {
                return HttpNotFound();
            }
            foreach (Book item in list)
            {
                if (item.Id == id)
                {
                    item.Title = Title;
                    item.Author = Author;
                    item.Image_cover = Image_cover;
                }
            }
            return View("ListBookModel",list);
        }




        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create([Bind(Include = "id,title,author,image_cover")]Book book)
        {
            /*************************/
            List<Book> list = new List<Book>();
            list.Add(new Book(01, "Sách 1", "By me", "/Images/sach1.png"));
            list.Add(new Book(02, "Sách 2", "By me", "/Images/sach2.jpg"));
            list.Add(new Book(03, "Sách 3", "By me", "/Images/sach3.jpg"));
            /*************************/
            HttpPostedFileBase file = Request.Files["fileImage"];
            if (file.FileName != "")
            {
                string serverpath = HttpContext.Server.MapPath("~/Images");
                string filepath = serverpath + "/" + file.FileName;
                file.SaveAs(filepath);
                book.Image_cover = "/Images/" + file.FileName;
            }

            try
            {
                if(ModelState.IsValid)
                {
                    list.Add(book);
                }
            }
            catch
            {
                ModelState.AddModelError("", "Lỗi khi thêm");
            }
            return View("ListBookModel", list);
        }


        public ActionResult Details(int id)
        {
            List<Book> list = new List<Book>();
            list.Add(new Book(01, "Sách 1", "By me", "/Images/sach1.png"));
            list.Add(new Book(02, "Sách 2", "By me", "/Images/sach2.jpg"));
            list.Add(new Book(03, "Sách 3", "By me", "/Images/sach3.jpg"));
            /*************************/
            Book here = new Book();
            foreach (Book item in list)
            {
                if (item.Id == id)
                {
                    here = item;
                }
            }

            if (here == null)
            {
                return HttpNotFound();
            }
            return View(here);
        }


    }
}