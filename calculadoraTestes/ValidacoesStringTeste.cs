using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using calculadora.Services;
using Xunit;


namespace calculadoraTestes
{
    public class ValidacoesStringTeste
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTeste()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange
            string texto = "Ola";

            //Act
            int resultado = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(3, resultado);
        }

        [Fact]
        public void ContarLetrasDeWallace()
        {
            string nome = "Wallace";

            int resultado = _validacoes.ContarCaracteres(nome);

            Assert.Equal(7,resultado);
        }
    }
}