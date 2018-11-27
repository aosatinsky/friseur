using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnosPeluqueria.Datos;
using TurnosPeluqueria.Models;

namespace TurnosPeluqueria.Controllers
{
    public class AdminController : Controller
    {
        PeluqueriaContexto db = new PeluqueriaContexto();
        // GET: Admin
        public ActionResult Turnos()
        {
            if (Session["PeluqeroId"] != null)
            {
 
                    return View(db.Turnos.Where(p => DbFunctions.TruncateTime(p.Horario) == DateTime.Today.Date).ToList());
                
            }
            else
            {
                return RedirectToAction("Login");
            }

        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Peluquero peluquero)
        {
            using (PeluqueriaContexto db = new PeluqueriaContexto())
            {
                var usr = db.Peluqueros.Where(u => u.Usuario == peluquero.Usuario && u.Passw == peluquero.Passw).FirstOrDefault();

                if (usr != null)
                {
                    Session["PeluqeroId"] = peluquero.Id.ToString();
                    Session["Peluquero"] = peluquero.Usuario.ToString();
                    return RedirectToAction("Turnos");
                }
                else
                {
                    ModelState.AddModelError("", "Nombre de usuario o contraseña incorrecta");
                }
            }
            return View();
        }
    }
}