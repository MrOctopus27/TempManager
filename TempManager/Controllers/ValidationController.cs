using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TempManager.Models;

namespace TempManager.Controllers
{
    public class ValidationController : Controller
    {
        private TempManagerContext store { get; set; }
        public ValidationController(TempManagerContext ctx) => store = ctx;
        public JsonResult CheckDate(string date)
        {
            DateTime dt = DateTime.Parse(date);
            Temp temp = store.Temps.FirstOrDefault(t => t.Date == dt);

            if (temp == null)
                return Json(true);
            else
                return Json($"The date {date} is in the database.");
        } 
    }
}
