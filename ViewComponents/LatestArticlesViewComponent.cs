

using System.Collections.Generic;
using DevCar_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCar_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1 , "دوره مدیریت مهندسی تعمیر و نگهداری هواپیما" , "این دوره مخصوص معاونت های مهندسی و تعمیرات هر سازمان می باشد که البته تمامی علاقه مندان می توانند شرکت کنند." ,
                    "blog-post-thumb-1.jpg"),
                new Article(2 , "مقاله بهینه سازی تعمیر و نگهداری هواپیما" , "این دوره مخصوص معاونت های مهندسی و تعمیرات هر سازمان می باشد که البته تمامی علاقه مندان می توانند شرکت کنند." ,
                    "blog-post-thumb-2.jpg"),
                new Article(3 , "مقاله کنترل و تولید آشیانه تعمیرات" , "این دوره مخصوص معاونت های مهندسی و تعمیرات هر سازمان می باشد که البته تمامی علاقه مندان می توانند شرکت کنند." ,
                    "blog-post-thumb-3.jpg"),
                new Article(4 , "مقاله بهسازی فرایند های سرویس دهی " +
                                "ایستگاههای تعمیرات" , "این دوره مخصوص معاونت های مهندسی و تعمیرات هر سازمان می باشد که البته تمامی علاقه مندان می توانند شرکت کنند." ,
                    "blog-post-thumb-4.jpg"),
                new Article(5 , "مقاله مانیتورینگ موتورهای توربین گازی" , "این دوره مخصوص معاونت های مهندسی و تعمیرات هر سازمان می باشد که البته تمامی علاقه مندان می توانند شرکت کنند." ,
                    "blog-post-thumb-5.jpg")
            };
            return View("_LatestArticles" , articles);
        }
    }
}
