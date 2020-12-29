using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("teste")]
    public class TesteController : Controller
    {
        public ViewResult Dados(int Id)
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Luiz Felipe Carvalho Libertino"
            };

            ViewBag.Categoria = "Produtos de Limpeza";
            ViewData["Categoria"] = "Produtos de informática";
            TempData["Categoria"] = "Produto de Escritório";
            Session["Categoria"] = "Móveis";
            return View(autor);
        }
        public string Index()
        {
            return "teste";
        }
        public JsonResult UmaAction(int? id, string nome)
        {
            var autor =  new Autor
            {
                Id = 0,
                Nome=nome
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Autor autor)
        {

            return Json(autor);
        }
        [Route("minharouta/{id?}")]
        public string MinhaAction(int? id)
        {
            return "OK! Cheguei na rota";
        }
        [Route("rota/{categoria:minlength(3)}")]
        public string MinhaAction3(string categoria)
        {
            return "OK! Cheguei na rota! " + categoria;
        }
    }


}