using BasicsConcepts;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class CalculadoraIMCTeste
    {
        [TestMethod]
        public void CalcularTeste()
        {
            //cenários
            float peso = 80f;
            float altura = 2f;
            CalculadoraIMC calculadora = new CalculadoraIMC();
            //ação
            float imc = calculadora.Calcular(peso, altura);
            //separar os métodos calcular imc e obter status na classe CalcularIMC
            //assistir o video sobre principios solid do felipe deschamps

            //verificação
            Assert.AreEqual(20, imc);
        }
        [TestMethod]
        public void CalcularTesteStatus()
        {
            //cenários
            float imc = 25;
            //ação
            CalculadoraIMC calculadoraStatus = new CalculadoraIMC();
            String status = calculadoraStatus.Status(imc);
            //verificação
            Assert.AreEqual("sobrepeso", status);
        }
    }
}