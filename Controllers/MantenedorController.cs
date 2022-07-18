using Microsoft.AspNetCore.Mvc;
using CRUDCORE.Datos;
using CRUDCORE.Models;


namespace CRUDCORE.Controllers
{
    public class MantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //LA VISTA MUESTRA UNA LISTA DE CONTACTOS
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //RECIBE UN OBJETO Y LO ALMANCENA EN LA BASE DE DATOS
            var respuesta = _ContactoDatos.Guardar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Editar(int IdContacto)
        {
            //EDITAR UN USUARIO CREADO
            var ocontacto = _ContactoDatos.Obtener(IdContacto);

            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            //EDITAR UN USUARIO CREADO
            if (!ModelState.IsValid)
            {
                return View();
            }

            //RECIBE UN OBJETO 
            var respuesta = _ContactoDatos.Editar(oContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int IdContacto)
        {
            //EDITAR UN USUARIO CREADO
            var ocontacto = _ContactoDatos.Obtener(IdContacto);

            return View(ocontacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            //RECIBE UN OBJETO 
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);

            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }
    }
}
