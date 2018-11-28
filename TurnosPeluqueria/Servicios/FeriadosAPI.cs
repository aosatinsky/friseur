using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using TurnosPeluqueria.Models;

namespace TurnosPeluqueria.Servicios
{
    public class FeriadosAPI
    {
        public bool EsFeriado()
        {
            var json = new WebClient().DownloadString("http://nolaborables.com.ar/api/v2/feriados/"+DateTime.Now.Year);
            List<Feriado> feriados = JsonConvert.DeserializeObject<List<Feriado>>(json);
            //feriados.Add(new Feriado
            //{
            //    Id = "asda",
            //    Dia = 28,
            //    Mes = 11,
            //    Motivo = "",
            //    Tipo = ""
            //});
            if (feriados.Find(u => u.Dia == DateTime.Today.Day && u.Mes == DateTime.Now.Month) != null)
            {
                return true;
            }return false;
        }
    }
}