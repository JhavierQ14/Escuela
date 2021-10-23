using Escuela.Dominio;
using Escuela.Models;
using Escuela.Servicio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
         private ICourse icourse;
        private IRollements irollements;

        public HomeController(ILogger<HomeController> logger,ICourse icourse, IRollements irollements)
        {
            this.irollements = irollements;
            this.icourse = icourse;
            _logger = logger;
        }

        public IActionResult Index()
            
        {
            Course course = new Course();
           
            course.Title = "update";
            course.Credits = 100;
            icourse.Insertar(course);

      
            return View();
        }

        public IActionResult Join()
        {
            var listado = irollements.UnionDeTablas();

            return View(listado);
        }

            public IActionResult NuevaVista()
        {
            return View();
        }

            public IActionResult GetALL()
        {
             var DandoFormatoJson = icourse.ListarCursos();


            return Json(new { data = DandoFormatoJson });
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
    }
}
