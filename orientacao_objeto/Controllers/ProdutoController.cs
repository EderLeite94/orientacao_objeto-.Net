using Microsoft.AspNetCore.Mvc;
using orientacao_objeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orientacao_objeto.Controllers
{
    public class ProdutoController : Controller
    {
        public static List<Produtos> lsProduto = new List<Produtos>();
        public IActionResult Index()
        {
            return View(lsProduto);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Salvar (Produtos item)
        {
            lsProduto.Add(item);
            return RedirectToAction("Index");
        }
    }
}
