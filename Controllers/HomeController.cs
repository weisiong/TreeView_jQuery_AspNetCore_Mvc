using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TreeView_jQuery_AspNetCore_Mvc.Data;
using TreeView_jQuery_AspNetCore_Mvc.Models;
using TreeView_jQuery_MVC_AspNetCore.Models;

namespace TreeView_jQuery_AspNetCore_Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Home
        public ActionResult Index()
        {
            List<TreeViewNode> nodes = new List<TreeViewNode>();
            ApplicationDbContext entities = _context;

            //Loop and add the Parent Nodes.
            foreach (VehicleType type in entities.VehicleTypes)
            {
                nodes.Add(new TreeViewNode { id = type.Id.ToString(), parent = "#", text = type.Name });
            }

            //Loop and add the Child Nodes.
            foreach (VehicleSubType subType in entities.VehicleSubTypes)
            {
                nodes.Add(new TreeViewNode { id = subType.VehicleTypeId.ToString() + "-" + subType.Id.ToString(), parent = subType.VehicleTypeId.ToString(), text = subType.Name });
            }

            //Serialize to JSON string.
            ViewBag.Json = JsonConvert.SerializeObject(nodes);
            return View();
        }

        [HttpPost]
        public ActionResult Index(string selectedItems)
        {            
            List<TreeViewNode> items = JsonConvert.DeserializeObject<List<TreeViewNode>>(selectedItems);
            return RedirectToAction("Index");
        }

    }
}
