using BancoDeDados;
using System;
using System.Web.Mvc;

namespace PizzariaRumo.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Pedidos()
        {
            ViewBag.Message ="Cadastro de pedidos";

            ViewBag.Cadastro = new Cadastros().Pedidos();

            return View();
        }

        public ActionResult Cozinha()
        {
            ViewBag.Message = "Pedidos realizados - Pizzas";

            ViewBag.Cadastro = new Cadastros().Pedidos();

            return View();
        }

        public ActionResult Copa()
        {
            ViewBag.Message = "Pedidos realizados - bebidas";

            ViewBag.Cadastro = new Cadastros().Pedidos();

            return View();
        }

        [HttpPost]
        public void Criar()
        {
            var pedidos = new Cadastros();
             = Convert.ToInt32(row["Pedido"]);
             = Convert.ToInt32(row["Mesa"]);
             = (char)row["Pizza"];
             = Convert.ToInt32(row["qtdPizza"]);
             = (char)row["ObservacaoPizza"];
             = (char)row["Bebida"];
             = Convert.ToInt32(row["qtdBebida"]);
             = (char)row["Mesa"];
            Response.Redirect("/Home");
        }
    }
}