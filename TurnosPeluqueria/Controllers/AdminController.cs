using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnosPeluqueria.Datos;

namespace TurnosPeluqueria.Controllers
{
    public class AdminController : Controller
    {
        private PeluqueriaContexto db = new PeluqueriaContexto();

        // GET: Admin
        public ActionResult Turnos()
        {
            return View(db.Turnos.ToList());
        }
    }
}