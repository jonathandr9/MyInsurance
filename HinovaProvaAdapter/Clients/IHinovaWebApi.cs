using System.Threading.Tasks;
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
        //[Get("/Api/Oficina?codigoAssociacao=601&cpfAssociado=")]
        [Get("/Api/Oficina")]
        Task<ConsultarOficinasGetResult> ConsultarOficinasAsync(
            int codigoAssociacao, 
            string cpfAssociado);
    }
}
