using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnosPeluqueria.Datos;
using TurnosPeluqueria.Servicios;

namespace TurnosPeluqueria.Controllers
{
    public class HomeController : Controller
    {
        private PeluqueriaContexto db = new PeluqueriaContexto();
        // GET: Home
        public ActionResult Index()
        {
            return View(db.Servicios.ToList());
        }

    }
}