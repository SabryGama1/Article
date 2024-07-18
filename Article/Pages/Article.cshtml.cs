using Article.core;
using Article.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Article.Pages
{
    public class ArticleModel : PageModel
    {
        private readonly IDataHelper<AuthorPost> dataHelperForPost;
        public AuthorPost authorPost;

        public ArticleModel(IDataHelper<core.AuthorPost> dataHelperForPost)

        {
            this.dataHelperForPost = dataHelperForPost;
            authorPost = new AuthorPost();
        }



        public void OnGet()
        {
            var id = HttpContext.Request.RouteValues["id"];
            authorPost = dataHelperForPost.Find(Convert.ToInt32(id));
        }
    }
}
