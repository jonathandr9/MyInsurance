using Moq;
using MyInsurance.Application;
using MyInsurance.Domain.Adapters;
using MyInsurance.Domain.Models;
using MyInsurance.Domain.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace MyInsurance.Tests
{
    public class OficinaServiceTests
    {
        [Fact]
        [Trait("ConsultarOficinas","Oficina")]
        public async Task ConsultarOficinas_Oficina_Success()
        {
            //Arrange
            Oficina oficina = new Oficina()
            {
                Id = 1,
                Nome = "Oficina Gecar",
                Descricao = "A oficina Gecar presta serviços em Betim a mais de 30 anos",
                DescricaoCurta = "Lanternagem e pintura",
                Endereco = "Rua Ignês Maria",
                Latitude = "-19.9622435",
                Longitude = "-44.175102",
                Foto = "iVBORw0KGgoAAAANSUhEUgAAAQAAAABfCAYAAAAH3RnwAAAABmJLR0QA/wD/AP+/n57X3Oufe+++9O5yz9/",
                AvaliacaoUsuario = 0,
                CodigoAssociacao = 601,
                Email = "contato@email.com",
                Telefone1 = "31 35353535",
                Telefone2 = "",
                Ativo = true,
            };

            List<Oficina> oficinasExpected = new List<Oficina>();
            oficinasExpected.Add(oficina);

            Moq.Mock<IHinovaAdapter> sqlAdapterMoq = new Moq.Mock<IHinovaAdapter>();
            sqlAdapterMoq.Setup(x => x.ConsultarOficinas(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(oficinasExpected);
            IOficinaService saleService = new OficinaService(sqlAdapterMoq.Object);

            //Act
            var result = await saleService.ConsultarOficinas(601,"");

            //Assert
            Assert.True(result.Equals(oficinasExpected));
        }
    }
}
