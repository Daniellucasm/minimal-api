using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class VeiculoTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo();

        veiculo.Id = 1;
        veiculo.Nome = "teste@teste.com";
        veiculo.Marca = "1234";
        veiculo.Ano = 12/04/2024;

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("teste@teste.com", veiculo.Nome);
        Assert.AreEqual("1234", veiculo.Marca);
        Assert.AreEqual(12/04/2024, veiculo.Ano);
    }
}