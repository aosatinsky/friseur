using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnosPeluqueria.Datos;
using TurnosPeluqueria.Models;

namespace TurnosPeluqueria.Controllers
{
    public class TurnosController : Controller
    {
        // GET: Turnos
        public ActionResult Index()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else return RedirectToAction("Login");
        }

        public ActionResult Registro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registro(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                using (PeluqueriaContexto db = new PeluqueriaContexto())
                {
                    var usr = db.Clientes.Where(u => u.User == cliente.User).FirstOrDefault();

                    if (usr == null)
                    {
                        db.Clientes.Add(cliente);
                        db.SaveChanges();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Elija otro nombre de usuario");
                        return View();
                    }
                    
                }
                ModelState.Clear();
                return RedirectToAction("Login");
            }
            return View();

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Cliente cliente)
        {
           
                using (PeluqueriaContexto db = new PeluqueriaContexto())
                {
                var usr = db.Clientes.Where(u => u.User == cliente.User && u.Passw == cliente.Passw).FirstOrDefault();

                if (usr != null)
                {
                    Session["UserId"] = cliente.Id.ToString();
                    Session["User"] = cliente.User.ToString();
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Nombre de usuario o contrasena incorrecta");
                }
            }
            return View();

        }

        public ActionResult Logout()
        {
                if (Session["UserId"] != null)
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