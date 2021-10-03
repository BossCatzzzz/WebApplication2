using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab02_ThucHanh.Models
{
    public class Book
    {
        int id;
        string title;
        string author;
        string image_cover;

        public Book(int id, string title, string author, string image_cover)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.image_cover = image_cover;
        }

        public Book()
        {

        }

        [Required(ErrorMessage = "ID không được trống")]
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage ="Tiêu đề không được trống")]
        [StringLength(100,ErrorMessage ="Tiêu đề ít hơn 100 ký tự")]
        //[Display(Name ="Tiêu đề")]
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Image_cover { get => image_cover; set => image_cover = value; }
    }
}