using PagedList;
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
        public ActionResult Turnos(int? page)
        {
            if (Session["PeluqeroId"] != null)
            {
                var turnos = db.Turnos.Where(p => DbFunctions.TruncateTime(p.Horario) == DateTime.Today.Date).OrderByDescending(i => i.Horario); ;

                int pageNumber = (page ?? 1);
                return View(turnos.ToPagedList(pageNumber, 10));
                
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

        public ActionResult Logout()
        {
            if (Session["PeluqeroId"] != null)
            {
                Session.Clear();
                Session.Abandon();
                return RedirectToAction("Login");
            }
            else
            {
                return RedirectToAction("Login");
            }

        }


    }
}