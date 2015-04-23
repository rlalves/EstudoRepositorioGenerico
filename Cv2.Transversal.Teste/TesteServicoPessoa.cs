using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using Cv2.Dominio.Entidades;
using Cv2.Dominio.Interfaces.Repositorios;
using Cv2.Dominio.Servicos;

namespace Cv2.Transversal.Teste
{
    [TestClass]
    public class TesteServicoPessoa
    {
        [TestMethod]
        public void TestaIncluirPessoa()
        {
            //Arrange
            var moqRepositorio = new Mock<IRepositorioPessoa>();
            var serv = new ServicoPessoa(moqRepositorio.Object);
            Guid id = Guid.NewGuid();
            Pessoa p = new Pessoa { PessoaId = id, Nome = "teste" };

            //Act
            serv.Incluir(p);

            //Assert
            Assert.AreEqual(id, serv.ConsultarPorId(id).PessoaId);
        }

        [TestMethod]
        public void TestaAlterarPessoa()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void TestaExcluirPessoa()
        {
            //Arrange

            //Act

            //Assert
        }

        [TestMethod]
        public void TestaListarPorIdPessoa()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
