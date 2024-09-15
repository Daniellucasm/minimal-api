using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var adm = new Administrador();

        adm.Id = 1;
        adm.Email = "teste@teste.com";
        adm.Senha = "1234";
        adm.Perfil = "Adm";

        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("1234", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}