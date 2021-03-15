using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ShopBridgeMvc.Models;

namespace ShopBridgeMVC.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            IEnumerable<mvcItem> ItemList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Items").Result;
            ItemList = response.Content.ReadAsAsync<IEnumerable<mvcItem>>().Result;
            return View(ItemList);
        }
        public ActionResult Add(int id = 0)
        {
            return View(new mvcItem());
        }
        [HttpPost]
        public ActionResult Add(mvcItem itm)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Items", itm).Result;
            TempData["SuccessMessage"] = "Saved successfully.";
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Items/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Record Deleted successfully.";
            return RedirectToAction("Index");
        }
    }
}