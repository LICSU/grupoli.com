using GrupoLi.Models;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace GrupoLi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Detalles(string id)
        {
            if (id == "SomosUno")
            {
                ViewData["Producto"] = "Somos Uno";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
                ViewData["active"] = "active";
            }
            else if (id == "Heart_SomosUno")
            {
                ViewData["Producto"] = "Heart + Somos Uno";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
                ViewData["active"] = "active";
            }
            else if (id == "Heart")
            {
                ViewData["Producto"] = "Heart";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
            }
            else if (id == "Heart_SomosUno_Metabolismo")
            {
                ViewData["Producto"] = "Heart + Somos Uno + Metabolismo";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
            }
            else if (id == "Metabolismo")
            {
                ViewData["Producto"] = "Metabolismo";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
            }
            else if (id == "Psicosocial")
            {
                ViewData["Producto"] = "Estrés como riesgo Psicosocial";
                ViewData["Imagen"] = "../../images/slider/img_2.jpg";
            }
            else if (id == "SGSSTC")
            {
                ViewData["Producto"] = "SGSSTC";
                ViewData["Imagen"] = "../../images/slider/img_3.jpg";
            }
            else if (id == "Recognition_Hotel")
            {
                ViewData["Producto"] = "Recognition Hotel";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Transporte_publico_individual")
            {
                ViewData["Producto"] = "Transporte público individual";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Transporte_publico_masivo")
            {
                ViewData["Producto"] = "Transporte público masivo";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Big-bro")
            {
                ViewData["Producto"] = "Big-bro";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Ciudad_Segura")
            {
                ViewData["Producto"] = "Ciudad Segura";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Real_Li")
            {
                ViewData["Producto"] = "Real Li";
                ViewData["Imagen"] = "../../images/slider/img_4.jpg";
            }
            else if (id == "Empresas")
            {
                ViewData["Producto"] = "Empresas";
                ViewData["Imagen"] = "../../images/slider/img_5.jpg";
            }
            else if (id == "Academias")
            {
                ViewData["Producto"] = "Academias";
                ViewData["Imagen"] = "../../images/slider/img_5.jpg";
            }
            else if (id == "Power_Li")
            {
                ViewData["Producto"] = "Power Li";
                ViewData["Imagen"] = "../../images/slider/img_6.jpg";
            }
            return View();
        }

        [HttpPost]
        public ActionResult SendEmail(Email model)
        {
            string body = "" +
                "<h2> Informacion: </h2> <br/>" +
                "<h3> Nombre:   </h3>" + model.Nombre     + "<br/>" +
                "<h3> Email:    </h3>" + model.FromEmail   + "<br/>" +
                "<h3> Asunto:   </h3>" + model.Asunto     + "<br/>" +
                "<h3> Mensaje:   </h3><p>" + model.Mensaje+"</p>";

            MailMessage mail = new MailMessage()
            {
                From = new MailAddress("admin_sgsst@grupoli.com"),
                Body = body,
                Subject = "Formulario de Contacto",
                IsBodyHtml = true
            };

            mail.To.Add(new MailAddress("admin_sgsst@grupoli.com","Contacto"));

            // se define el smtp
            SmtpClient smtp = new SmtpClient()
            {
                Host = "webmail.licsu.com",
                Port = 25,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("admin_sgsst@grupoli.com", "@Licsu2017SgSst"),
                EnableSsl = false
            };

            try
            {
                smtp.Send(mail);
                mail.Dispose();
            }
            catch
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }
    }
}