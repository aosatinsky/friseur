using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;

namespace TurnosPeluqueria.Servicios
{
   static public class EmailAPI
    {
        static public async System.Threading.Tasks.Task EnviarEmailAsync(string email, string nombre, DateTime horario, string peluquero)
        {
            var imagenHTML = @"<img src='http://friseur.azurewebsites.net/img/logo.png' style ='width:300px;height:300px;' > ";

            MailjetClient client = new MailjetClient("7ae7ed62b20c4df07110d474410769ae", "889c023b436e6922b67fd16ffa8fb1cc");
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.FromEmail, "turnos@friseur.azurewebsites.net")
            .Property(Send.FromName, "Friseur Barber Shop")
            .Property(Send.Subject, "Gracias por sacar un turno con nostros!")
            .Property(Send.TextPart, "Hola "+nombre+"! Este es tu turno para cortate el pelo: "+ horario.ToString())
            .Property(Send.HtmlPart, imagenHTML +
            "<h3>Hola " + nombre + "!</h3><br />Este es tu turno para cortate el pelo: " + horario.ToString() + "<br /> Peluquero: "+ peluquero)
            .Property(Send.To, nombre + " <"+email+">");
            MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(string.Format("Total: {0}, Count: {1}\n", response.GetTotal(), response.GetCount()));
                Console.WriteLine(response.GetData());
            }
            else
            {
                Console.WriteLine(string.Format("StatusCode: {0}\n", response.StatusCode));
                Console.WriteLine(string.Format("ErrorInfo: {0}\n", response.GetErrorInfo()));
                Console.WriteLine(string.Format("ErrorMessage: {0}\n", response.GetErrorMessage()));
            }
        }
    }
}