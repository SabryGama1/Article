using Article.core;
using Article.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System;
using System.Linq;

namespace Article.Pages
{
    [Authorize]
    public class AdminIndexModel : PageModel
    {
        private readonly IDataHelper<AuthorPost> dataHelper;

        public AdminIndexModel(IDataHelper<AuthorPost> dataHelper)
        {
            this.dataHelper = dataHelper;
        }

        public int AllPost { get; set; }
        public int PostLastMouth { get; set; }
        public int PostThisYear { get; set; }
        public void OnGet()
        {
            var datem = DateTime.Now.AddMonths(-1);
            var datey = DateTime.Now.AddYears(-1);
            var userid = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            AllPost = dataHelper.GetDataByUser(userid).Count;
            PostLastMouth = dataHelper.GetDataByUser(userid).Where(x => x.AddedDate >= datem).Count();
            PostThisYear = dataHelper.GetDataByUser(userid).Where(x => x.AddedDate >= datey).Count();
        }
    }
}
