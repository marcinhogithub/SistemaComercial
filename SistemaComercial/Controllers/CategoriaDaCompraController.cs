using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SistemaComercial.Controllers
{
    public class CategoriaDaCompraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}