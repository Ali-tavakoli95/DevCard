using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
	public class ProjectsViewComponent : ViewComponent 
	{
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفرهای شهری", "project-1.jpg", "Atriya" ),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg","ZoodFood" ),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg","MONOP" ),
                new Project(4, "فضاپیما", "برنامه مدیریت فضاهای ناسا", "project-4.jpg","NASA" ),
            };
            return View("_Projects", projects);
        }
	}
}
