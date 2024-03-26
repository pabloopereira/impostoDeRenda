

using impostoDeRenda;

namespace Testeimposto
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            float salario = 8000;

            var impostoDeRenda = new impostoLeao();

            float resultado = impostoDeRenda.CalculoImposto(salario);
            Assert.AreEqual(6696, resultado);
        }
    }
}