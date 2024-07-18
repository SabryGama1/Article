using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Article.core
{
    public class Category
    {
        [Key]
        [Required]
        [Display(Name ="المعرف")]
        public int Id { get; set; }
        [Required(ErrorMessage ="اسم الصنف مطلوب")]
        [Display(Name = "اسم الصنف")]
        [MaxLength(50,ErrorMessage ="اعلي قيمه للادخال  50 حرف")]
        [MinLength(2, ErrorMessage = "اصغر قيمه للادخال  50 حرف")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public virtual List<AuthorPost> AuthorPosts { get; set; }

    }
}
