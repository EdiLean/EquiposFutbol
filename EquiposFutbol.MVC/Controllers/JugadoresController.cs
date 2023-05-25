using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EquiposFutbol.UAPI;
using EquiposFutbol.Modelos;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EquiposFutbol.MVC.Controllers
{
    public class JugadoresController : Controller       
    {
        private Crud<Modelos.Jugador> jugadores = new Crud<Modelos.Jugador>();
        private string Url = "https://localhost:7060/api/Jugadores";
        // GET: JugadoresController
        public ActionResult Index()
        {
            var datos = new Crud<Jugador>().Select(Url);
            return View(datos);
        }

        // GET: JugadoresController/Details/5
        public ActionResult Details(int id)
        {
            var datos = new Crud<Jugador>().Select_ById(Url, id.ToString());
            return View(datos);
        }

        // GET: JugadoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JugadoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Jugador datos)
        {
            try
            {
                jugadores.Insert(Url, datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: JugadoresController/Edit/5
        public ActionResult Edit(int id)
        {
            var datos= jugadores.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: JugadoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Jugador datos)
        {
            try
            {
                jugadores.Update(Url, id.ToString(), datos);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }

        // GET: JugadoresController/Delete/5
        public ActionResult Delete(int id)
        {
            var datos = jugadores.Select_ById(Url, id.ToString());
            return View(datos);
        }

        // POST: JugadoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Jugador datos)
        {
            try
            {
                jugadores.Delete(Url,id.ToString());
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(datos);
            }
        }
    }
}
