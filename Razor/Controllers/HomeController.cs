using Razor.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Variaveis()
        {
            return View();
        }

        public ActionResult Condicoes()
        {
            return View();
        }

        public ActionResult EntradaDeDados()
        {
            return View();
        }

        public ActionResult ViewBagViewData()
        {
            ViewData["DataAtual"] = DateTime.Now.ToLongDateString();
            ViewBag.HoraAtual = DateTime.Now.ToLongDateString();

            //Forma Incorreta de Transportar Objetos com Razor(ViewData e ViewBag)
            var conta = new Conta
            {
                IdConta = 1,
                NumeroConta = 001,
                NomeCliente = "João Paulo da Silva",
                SaldoAtual = 1535.00,
                LimiteChequeEspecial = 500.00,
                DataDeEntrada = DateTime.Now.Date
             };
               ViewData["Conta"] = conta;
               ViewBag.Conta = conta;

            return View();
        }

        public ActionResult StronglyTypedViews()
        {
            //Transportar Objetos com Razor(Strongly Typed Views)
            var conta = new Conta
            {
                IdConta = 2,
                NumeroConta = 002,
                NomeCliente = "Diogo S.O",
                SaldoAtual = 1.00000000,
                DataDeEntrada = DateTime.Now.Date
            };

            //passar como parâmetro para o método View um objeto do tipo esperado pela camada de apresentação
            return View(conta);
        }

        public ActionResult HtmlHelpers()
        {

            return View();
        }

        public ActionResult HtmlHelpersStronglyTypedHelpers()
        {

            return View();
        }

        public ActionResult Lista()
        {
            var tipos = new Collection<string>
            {
                "Conta Corrente",
                "Conta Poupança",
                "Conta Salário"
            };
            ViewBag.TiposDeConta = tipos;
            return View();
        }
    }
}