using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var article = new List<Article>
            {
                new Article(1, "آموزش ASP.NET Core mvc", "کاملترین پکیچ برنامه نویسی ASP.Net core mvc  به زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش Git & Github", "کاملترین پکیچ برنامه نویسی Git & Github  به زبان فارسی",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش Onion Architecture",
                    "کاملترین پکیچ برنامه نویسی Onion Architecture  به زبان فارسی",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش طراحی سایت", "کاملترین پکیچ برنامه نویسی طراحی سایت  به زبان فارسی",
                    "blog-post-thumb-card-4.jpg")
            };
            return View("_LatestArticles", article);
        }
    }
}