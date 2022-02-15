

using System.Collections.Generic;
using DevCar_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCar_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"انبارداری" ,"سیستم درخواست و کنترل و پیشبینی قطعات انبارها" , "project-1.jpg" , "TEMM_1" ) ,
                new Project(2,"کنترل و تولید" ,"سیستم کنترل و تولید آشیانه تعمیرات و مهندسی و خط پرواز ها" , "project-2.jpg" , "TEMM_2" ) ,
                new Project(3,"تداوم صلاحیت پروازی" ,"سیستم تداوم صلاحیت پروازی پارت ام" , "project-3.jpg" ,"TEMM_3" ) ,
                new Project(4,"پرسنل" ,"سیستم کنترل پرسنل و کنترل ورود و خروج و چیدمان" , "project-4.jpg" , "TEMM_4" ) ,
            };
            return View("_Projects", projects);
        }
    }
}
