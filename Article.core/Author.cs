using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.core
{
    public class Author
    {
        [Required]
        [Display(Name ="المعرف")]
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "المعرف المستخدم")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "اسم المستخدم المستخدم")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "الاسم الكامل للمستخدم")]
        public string FullName { get; set; }
        [Display(Name = "صوره المستخدم")]
        public string ProfileImage { get; set; }
        [Display(Name = "السيره الذاتيه")]
        public string Bio { get; set; }
        [Display(Name = "فيسبوك المستخدم")]
        public string FaceBook { get; set; }
        [Display(Name = "انستجرام المستخدم")]
        public string Instagram { get; set; }
        [Display(Name = "تويتر المستخدم")]
        public string Twitter { get; set; }
        public virtual List<AuthorPost> AuthorPosts { get; set; }

    }
}
