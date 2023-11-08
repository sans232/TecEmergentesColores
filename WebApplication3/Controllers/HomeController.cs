using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication3.Models;
using CapaEntidad;
using CapaNegocio;
using CapaDatos;
using System.Net;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private string mensajeresp;
        public int idMensaje;
        public int idColorfondo;
        public int idColortexto;
        public string dispositivo = "Desconocido";
        public string ubicacion = "Desconocido";

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            CambiarColor();
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        
        public ActionResult CambiarColor()
        {
            List<Colorfondo> color = new CN_Colorfondo().Listar();
            if (color != null && color.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(color.Count);

                Colorfondo colorAleatorio = color[index];

                ViewBag.ColorFondo = colorAleatorio.color;
             
                ViewBag.IdColorfondo = colorAleatorio.id;
                idColorfondo = colorAleatorio.id;
                TempData["idColorfondo"] = colorAleatorio.id;

            }

            List<Colortexto> color2 = new CN_Colortexto().Listar();
            if (color2 != null && color2.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(color2.Count);

                Colortexto colorAleatorio2 = color2[index];

                ViewBag.ColorFondo = colorAleatorio2.color;

                ViewBag.IdColorTexto = colorAleatorio2.id;
                idColortexto = colorAleatorio2.id;
                TempData["idColortexto"] = colorAleatorio2.id;

            }

            List<Colorcuadro> color3 = new CN_Colorcuadro().Listar();
            if (color3 != null && color3.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(color3.Count);

                Colorcuadro colorAleatorio3 = color3[index];

                ViewBag.ColorCuadro = colorAleatorio3.color;

                ViewBag.IdColorTexto = colorAleatorio3.id;
                idColortexto = colorAleatorio3.id;
                TempData["idColorcuadro"] = colorAleatorio3.id;

            }

            List<Mensaje> mensaje = new CN_Mensaje().Listar();
            if (mensaje != null && mensaje.Count > 0)
            {
                Random random = new Random();
                int index = random.Next(mensaje.Count);

                Mensaje mensajeAleatorio = mensaje[index];

                ViewBag.MensajeAleatorio = mensajeAleatorio.moraleja;
                ViewBag.IdMensaje = mensajeAleatorio.id;
                idMensaje=mensajeAleatorio.id;
                TempData["idMensaje"] = mensajeAleatorio.id;
            }

            
            
          


            return View();


            
        }





        [HttpPost]
        public ActionResult ResultadoPositivo()
        {
          

                Evaluador evaluador = new Evaluador();
                string resultadoeval = evaluador.Evaluar((int)TempData["idMensaje"], (int)TempData["idColorfondo"], (int)TempData["idColortexto"], (int)TempData["idColorcuadro"], true);

                string userAgent = Request.Headers["User-Agent"];


            if(userAgent != null)
            {
                if (userAgent.Contains("Windows"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("MacOS"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("Linux"))
                {
                    dispositivo = "Movil";
                }
                else if (userAgent.Contains("ChromeOS"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("Android"))
                {
                    dispositivo = "Movil";
                }
                else if (userAgent.Contains("iOS"))
                {
                    dispositivo = "Movil";
                }
                else
                {
                    dispositivo = "Computadora";
                }

            }

            string userIP = HttpContext.Connection.RemoteIpAddress.ToString();


                string apiKey = "4105717432ce11"; // Reemplaza con tu clave de API de ipinfo.io.

                string url = $"http://ipinfo.io/{userIP}/json?token={apiKey}";

                
                    using (WebClient client = new WebClient())
                    {
                        string response = client.DownloadString(url);
                        dynamic locationInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(response);

                        string country = locationInfo.country;
                        string city = locationInfo.city;

                        ubicacion = $"{country}, {city}";

                        ViewBag.Location = ubicacion;
                    }
                
                

                ResultadoNuevo oResultado = new ResultadoNuevo();
                oResultado.id = 0;
                oResultado.colorfondoid = (int)TempData["idColorfondo"];
                oResultado.colortextoid = (int)TempData["idColortexto"];
            oResultado.colorcuadroid = (int)TempData["idColorcuadro"];
                oResultado.mensajeid = (int)TempData["idMensaje"];
                oResultado.hora = DateTime.Now;
                oResultado.respuesta = true;
                oResultado.direcip = userIP;
                oResultado.ubicacionip = ubicacion;
                oResultado.dispositivo = dispositivo;
                oResultado.evaluacion = resultadoeval;

                
                    int resultado = new CN_ResultadoNuevo().Registrar(oResultado, out mensajeresp);
                
                
                return Json(new { mensaje = mensajeresp });
            }
           
            





        
        [HttpPost]
        public ActionResult ResultadoNegativo()
        {
            Evaluador evaluador = new Evaluador();
            string resultadoeval = evaluador.Evaluar((int)TempData["idMensaje"], (int)TempData["idColorfondo"], (int)TempData["idColortexto"], (int)TempData["idColorcuadro"], false);

            string userAgent = Request.Headers["User-Agent"];


            if (userAgent != null)
            {
                if (userAgent.Contains("Windows"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("MacOS"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("Linux"))
                {
                    dispositivo = "Movil";
                }
                else if (userAgent.Contains("ChromeOS"))
                {
                    dispositivo = "Computadora";
                }
                else if (userAgent.Contains("Android"))
                {
                    dispositivo = "Movil";
                }
                else if (userAgent.Contains("iOS"))
                {
                    dispositivo = "Movil";
                }
                else
                {
                    dispositivo = "Computadora";
                }

            }
            var remoteIpAddress = HttpContext.Connection.RemoteIpAddress;

            string userIP = remoteIpAddress.ToString(); 


            string apiKey = "4105717432ce11"; // Reemplaza con tu clave de API de ipinfo.io.

            string url = $"http://ipinfo.io/{userIP}/json?token={apiKey}";


            using (WebClient client = new WebClient())
            {
                string response = client.DownloadString(url);
                dynamic locationInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(response);

                string country = locationInfo.country;
                string city = locationInfo.city;

                ubicacion = $"{country}, {city}";

                ViewBag.Location = ubicacion;
            }



            ResultadoNuevo oResultado = new ResultadoNuevo();
            oResultado.id = 0;
            oResultado.colorfondoid = (int)TempData["idColorfondo"];
            oResultado.colortextoid = (int)TempData["idColortexto"];
            oResultado.colorcuadroid = (int)TempData["idColorcuadro"];
            oResultado.mensajeid = (int)TempData["idMensaje"];
            oResultado.hora = DateTime.Now;
            oResultado.respuesta = false;
            oResultado.direcip = userIP;
            oResultado.ubicacionip = ubicacion;
            oResultado.dispositivo = dispositivo;
            oResultado.evaluacion = resultadoeval;


            int resultado = new CN_ResultadoNuevo().Registrar(oResultado, out mensajeresp);


            return Json(new { mensaje = mensajeresp });

        }
    }
}