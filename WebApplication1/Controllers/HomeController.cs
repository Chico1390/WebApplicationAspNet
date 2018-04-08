using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            ProdutoModel p = new ProdutoModel();

            var sel = new SelectList(
                new []
                {
                    new {id =1, nome="abc1"},
                    new {id =2, nome="abc2"},
                    new {id =3, nome="abc3"},
                    new {id =4, nome="abc4"},
                    new {id =5, nome="abc5"}
                }, "id", "nome", 0
                );
            ViewBag.sel = sel;
            return View("EditProduto" , p);
        }
        public ActionResult APIView()
        {
            return View();
        }
    }
}
