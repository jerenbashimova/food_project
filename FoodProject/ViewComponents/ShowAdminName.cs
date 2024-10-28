﻿using FoodProject.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodProject.ViewComponents
{
    public class ShowAdminName:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var userName=User.Identity.Name;
            ViewBag.username = userName;
            return View();
        }
    }
}
