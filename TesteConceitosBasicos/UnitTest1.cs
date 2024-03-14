using BasicsConcepts;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class CalculadoraIMCTeste
    {
        [TestMethod]
        public void CalcularTeste()
        {
            //cen�rios
            float peso = 80f;
            float altura = 2f;
            CalculadoraIMC calculadora = new CalculadoraIMC();
            //a��o
            float imc = calculadora.Calcular(peso, altura);
            //separar os m�todos calcular imc e obter status na classe CalcularIMC
            //assistir o video sobre principios solid do felipe deschamps

            //verifica��o
            Assert.AreEqual(20, imc);
        }
        [TestMethod]
        public void CalcularTesteStatus()
        {
            //cen�rios
            float imc = 25;
            //a��o
            CalculadoraIMC calculadoraStatus = new CalculadoraIMC();
            String status = calculadoraStatus.Status(imc);
            //verifica��o
            Assert.AreEqual("sobrepeso", status);
        }

        [TestMethod]
        public void ObterClassificacaoComPesoEAltura()
        {
            //cen�rios
            float peso = 100f;
            float altura = 2f;
            //a��o
            CalculadoraIMC calculadoraStatusComPesoEAltura = new CalculadoraIMC();
            String statusNovo = calculadoraStatusComPesoEAltura.StatusComPesoEAltura(peso,altura);
            //verifica��o
            Assert.AreEqual("sobrepeso", statusNovo);
        }
    }
}