using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnosPeluqueria.Datos;
using TurnosPeluqueria.Models;
using PagedList;
using TurnosPeluqueria.Servicios;

namespace TurnosPeluqueria.Controllers
{

    public class TurnosController : Controller
    {
        private PeluqueriaContexto db = new PeluqueriaContexto();

        // GET: Turnos
        public ActionResult Index(int? page)
        {
            if (Session["UserId"] != null)
            {
                var hoy = DateTime.Today;
               
                    var usuario = Session["User"].ToString();
                    var misTurnos = db.Turnos.Where(u => u.Cliente.User == usuario).OrderByDescending(i => i.Horario);
                    ViewBag.turnosHoy = db.Turnos.Where(u => DbFunctions.TruncateTime(u.Horario) == hoy.Date).ToList();
                    var peluqueros = db.Peluqueros.ToList();
                    var listaPeluqueros = new SelectList(peluqueros, "ID", "Nombre");
                    ViewData["listaPeluqueros"] = listaPeluqueros;
                int pageNumber = (page ?? 1);
                return View(misTurnos.ToPagedList(pageNumber, 3));
                   
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
                    Session["UserId"] = usr.Id.ToString();
                    Session["User"] = usr.User.ToString();
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
        
        [HttpGet]
        public ActionResult NuevoTurno(int horario, int userID, int peluqueroID)
        {
            var FeriadosAPI = new FeriadosAPI();


            var usuario = Session["User"].ToString();
            if (Session["UserId"] != null && Session["UserId"].ToString() == userID.ToString())
            {
                using (PeluqueriaContexto db = new PeluqueriaContexto())
                {
                  
                    var misTurnos = db.Turnos.Where(u => u.Cliente.User == usuario
            && DbFunctions.TruncateTime(u.Horario) == DateTime.Today.Date).ToList();
                    var feriado = FeriadosAPI.EsFeriado();
                    if (misTurnos.Count() == 0 &&  feriado == false)
                    {
                        var cliente = db.Clientes.Where(u => u.Id == userID).First();
                        var peluquero = db.Peluqueros.Where(u => u.Id == peluqueroID).First();
                        Turno turno = new Turno
                        {
                            Cliente = cliente,
                            Peluquero = peluquero,
                            Horario = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, horario, 0, 0)
                        };
                        db.Turnos.Add(turno);
                        db.SaveChanges();
                        var email = db.Clientes.Where(u => u.User == usuario).First().Email;
                        var nombre = db.Clientes.Where(u => u.User == usuario).First().Nombre;

                       EmailAPI.EnviarEmailAsync(email, nombre, turno.Horario,peluquero.Nombre);
                        
                        return RedirectToAction("Index");
                    }
                    else if (feriado)
                    {
                        TempData["feriado"] = "si";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["error"] = "si";
                        return RedirectToAction("Index");
                    }
                   
                    
                }
                
                
            }
            else
            {
                return RedirectToAction("Login");
            }

        }
    }
}