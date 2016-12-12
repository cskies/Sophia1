using SophiaTest.DAO;
using SophiaTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SophiaTest.Controllers
{
    public class RegistroController : Controller
    {
        // GET: Registro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form()
        {
            //var registrosDAO = new RegistrosDAO();

            //ViewBag.Registros = registrosDAO;

            return View();
            
        }

        //[HttpPost]
        public ActionResult Adiciona(Registro registro)
        {
            //var dao = new RegistrosDAO();
            //dao.Adiciona(registro);

            //return RedirectToAction("IncluirContato");

            return View("IncluirContato");
            
        }
    }
}