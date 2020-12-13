using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyInsurance.WebApplication.Controllers
{
    public class OficinaController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOficinaService _oficinaService;

        public OficinaController(ILogger<HomeController> logger,
            IOficinaService oficinaService)
        {
            _logger = logger;
            _oficinaService = oficinaService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            IEnumerable<Oficina> listaOficinasResult =
              await _oficinaService.ConsultarOficinas(601, "");

            return View(listaOficinasResult);
        }

        public async Task<IActionResult> Pesquisa(int codigoAssociacao, string cpfAssociado)
        {
            IEnumerable<Oficina> listaOficinasResult =
                 await _oficinaService.ConsultarOficinas(codigoAssociacao, cpfAssociado);

            return View(listaOficinasResult);

        }
    }
}
