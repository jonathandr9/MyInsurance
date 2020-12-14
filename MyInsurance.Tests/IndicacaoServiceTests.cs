using Moq;
using MyInsurance.Application;
using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace MyInsurance.Tests
{
    public class IndicacaoServiceTests
    {
        [Fact]
        [Trait("IncluirIndicacao", "Indicacao")]
        public async Task IncluirIndicacao_Indicacao_Success()
        {
            //Arrange
            var indicacao = new Indicacao()
            {
                CodigoAssociacao = 601,
                DataCriacao = DateTime.Parse("2016-10-30"),
                CpfAssociado = "123123",
                EmailAssociado = "alksjd",
                NomeAssociado = "Teste",
                TelefoneAssociado = "asd",
                PlacaVeiculoAssociado = "asd",
                NomeAmigo = "asd",
                TelefoneAmigo = "asd",
                EmailAmigo = "asd"
            };

            var entradaIndicacao = new EntradaIndicacao()
            {
                Indicacao = indicacao,
                Remetente = "joao@email.com",
                Copias = new string[0]
            };

            var retornoIndicacaoExpected = new RetornoIndicacao()
            {
                Sucesso = "romulo.marques@hinovamobile.com.br",
                RetornoErro = new RetornoErro()
                {
                    retornoErro = null
                }
            };


            Moq.Mock<IHinovaAdapter> hinovaAdapterMoq = new Moq.Mock<IHinovaAdapter>();
            hinovaAdapterMoq.Setup(x => x.IncluirIndicacao(It.IsAny<EntradaIndicacao>())).ReturnsAsync(retornoIndicacaoExpected);
            IIndicacaoService indicacaoService = new IndicacaoService(hinovaAdapterMoq.Object);

            //Act
            var result = await indicacaoService.IncluirIndicacao(entradaIndicacao);

            //Assert
            Assert.True(result.Equals(retornoIndicacaoExpected));
        }
    }
}
