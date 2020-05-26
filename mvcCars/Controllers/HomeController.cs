using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcCars.Models;

namespace mvcCars.Controllers
{
    public class HomeController : Controller
    {
        private List<Auto> listaAuta = new List<Auto>();
        public JsonResult Index(int id = 0)
        {
            if (id == 0)
            {
                return Json(listaAuta);
            }
           else
           {
                Auto a1 = listaAuta.SingleOrDefault(a=>a.AutoId == id);
                if (a1 !=null)
                {
                    return Json(a1);
                }
                else
                {
                    return Json(new Auto());
                }
           }

        }
        
        public HomeController()
        {
            Auto a1 = new Auto{AutoId = 1, Proizvodjac = "BMW", Model = "E60", Boja = "crna", Stanje = "novo"};
            Auto a2 = new Auto{AutoId = 2, Proizvodjac = "Chevrolet", Model = "Lacetti", Boja = "siva", Stanje = "novo"};
            Auto a3 = new Auto{AutoId = 3, Proizvodjac = "Toyota", Model = "Avensis", Boja = "crna", Stanje = "novo"};
            Auto a4 = new Auto{AutoId = 4, Proizvodjac = "Skoda", Model = "Fabia", Boja = "siva", Stanje = "polovno"};
            Auto a5 = new Auto{AutoId = 5, Proizvodjac = "BMW", Model = "E46", Boja = "bijela", Stanje = "polovno"};
            Auto a6 = new Auto{AutoId = 6, Proizvodjac = "Renoult", Model = "Megane", Boja = "crvena", Stanje = "polovno"};

            listaAuta.Add(a1);
            listaAuta.Add(a2);
            listaAuta.Add(a3);
            listaAuta.Add(a4);
            listaAuta.Add(a5);
            listaAuta.Add(a6);
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
