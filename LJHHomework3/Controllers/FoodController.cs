using LJHHomework2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LJHHomework2.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult FoodApp()
        {
            return View();
        }

        public JsonResult GetCountryList()
        {
            DataFromDB data = new DataFromDB();
            string jsonData = JsonConvert.SerializeObject(data.GetCountryAll());
            return Json(jsonData);
        }

        public JsonResult GetStoreList(int countryId)
        {
            DataFromDB data = new DataFromDB();
            string jsonData = JsonConvert.SerializeObject(data.GetStoreList(countryId));
            return Json(jsonData);
        }

        public JsonResult GetStoreDetail(int countryId, int storeId)
        {
            DataFromDB data = new DataFromDB();
            string jsonData = JsonConvert.SerializeObject(data.GetStore(countryId, storeId));
            return Json(jsonData);
        }
    }
}
