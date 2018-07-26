using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razor.Models
{
    public class Conta
    {
        [HiddenInput(DisplayValue = false)]
        public int IdConta { get; set; }
        public int NumeroConta { get; set; }
        public string TipoDeConta { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }
        public double SaldoAtual { get; set; }
        public double LimiteChequeEspecial { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataDeEntrada { get; set; }
        public bool IndicaAtivo { get; set; }

    }
}