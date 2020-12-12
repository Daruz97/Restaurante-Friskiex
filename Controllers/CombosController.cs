using System;
using Restaurante_Friskiex;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurante_Friskiex.Controllers
{
    public class CombosController : Controller
    {
        // GET: Combos
        public ActionResult Index()
        {
            return View();
        }
       /*
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(CombosController combos)
        {
            
            db.Horarios.Add(combos);
            db.SaveChanges();
            return RedirectToAction("Index");

        }*/



    }
    
}