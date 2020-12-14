using System.Threading.Tasks;
using MyInsurance.Domain.Models;
using Refit;

namespace HinovaProvaAdapter.Clients
{
    public interface IHinovaWebApi
    {
        /// <summary>
        ///     Consulta os dados de oficinas mecânicas vinculadas
        /// </summary>
        /// <param name="codigoAssociacao">
        ///     Código da associação que o associado faz parte.
        /// </param>
        /// <param name="cpfAssociado">
        ///     Cpf do associado.
        /// </param>
        /// <returns>
        ///     Retorna as oficinas.
        /// </returns>        
        [Get("/Api/Oficina")]
        Task<ConsultarOficinasGetResult> ConsultarOficinasAsync(
            int codigoAssociacao, 
            string cpfAssociado);

        /// <summary>
        ///     Inclui uma indicação de um amigo
        /// </summary>
        /// <param name="EntradaIndicacao">
        ///     Objeto contendo os dados da indicação.
        /// </param>
        /// <returns>
        ///     Retorna o status da inclusão da indicação.
        /// </returns>        
        [Post("/api/Indicacao")]
        Task<IncluirIndicacaoPostResult> IncluirIndicacaoAsync(
            [Body]EntradaIndicacao entradaIndicacao);
    }
}
