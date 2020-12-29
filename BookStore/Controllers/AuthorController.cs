using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autor")]
    public class AuthorController : Controller
    {
        // GET: Autor
        [Route("listar")]
        public ActionResult Index()
        {
            return View();
        }
        [Route("criar")]

        public ActionResult Create()
        {
            return View();
        }
        [Route("editar/{id:int}")]

        public ActionResult Edit()
        {
            return View();
        }
        [Route("deletar/{id:int}")]

        public ActionResult Delete()
        {
            return View();
        }
    }
}