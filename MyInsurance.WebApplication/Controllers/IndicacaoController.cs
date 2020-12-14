using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System.Threading.Tasks;

namespace MyInsurance.WebApplication.Controllers
{
    public class IndicacaoController : Controller
    {
        private readonly ILogger<IndicacaoController> _logger;
        private readonly IIndicacaoService _indicacaoService;

        public IndicacaoController(ILogger<IndicacaoController> logger,
            IIndicacaoService indicacaoService)
        {
            _logger = logger;
            _indicacaoService = indicacaoService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EntradaIndicacao entradaIndicacao)
        {
            RetornoIndicacao retorno;

            if (ModelState.IsValid)
            {
                retorno = await _indicacaoService.IncluirIndicacao(entradaIndicacao);

            }

            return View();
        }
    }
}
