using Biblioteca_Recetas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Biblioteca_Recetas.Controllers
{
    public class RecetasController : Controller
    {
        public ActionResult ObtenerPaises()
        {
            return View(Datos.ObtenerPaisesConRecetas());
        }

        public ActionResult ObtenerRecetas(int id)
        {
            return View(Datos.ObtenerPaisesConRecetas().FirstOrDefault(x => x.Id == id)?.Recetas);

        }

        public ActionResult ObtenerTodas()
        {
            return View(Datos.ObtenerPaisesConRecetas());
        }

        // GET: Acciones/Create
        public IActionResult CrearPais()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CrearPais(Pais modelo)
        {
            int lastId = Datos.ObtenerPaisesConRecetas().Max(p => p.Id);
            if (ModelState.IsValid)
            {
                var pais = new Pais
                {
                    Id = lastId + 1,
                    Nombre = modelo.Nombre,
                    Bandera = modelo.Bandera,
                };

                Datos.CrearPais(pais);

                return RedirectToAction("ObtenerPaises");
            }

            return View(modelo);
        }

        public IActionResult CrearReceta()
        {
            ViewData["Id"] = new SelectList(Datos.ObtenerPaisesConRecetas(), "Id", "Nombre");
            return View();
        }
        [HttpPost]
        public ActionResult CrearReceta(Receta modelo)
        {
            ViewData["Id"] = new SelectList(Datos.ObtenerPaisesConRecetas(), "Id", "Nombre", modelo.PaisId);

            if (ModelState.IsValid)
            {
                Guid id = Guid.NewGuid();
                var receta = new Receta
                {
                    Id = id.ToString(),
                    Nombre = modelo.Nombre,
                    Descripcion = modelo.Descripcion,
                    Imagen = modelo.Imagen,
                    PaisId = modelo.PaisId
                };

                Datos.CrearReceta(receta);

                return RedirectToAction("ObtenerPaises");
            }

            return View(modelo);
        }

    }
}
