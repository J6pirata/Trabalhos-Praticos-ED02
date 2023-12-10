
namespace  Projeto-Final-ED2{


internal class Model_Equip
{
    public string IdentificacaoPatrimonio { get; set; }
    public string Avaria { get; set; }
    public decimal ValorDiarioLocacao { get; set; }

    public Model_Equip()
    {

    }

    public Model_Equip(string identificacaoPatrimonio, string avaria, decimal valorDiarioLocacao)
    {
        IdentificacaoPatrimonio = identificacaoPatrimonio;
        Avaria = avaria;
        ValorDiarioLocacao = valorDiarioLocacao;
    }
 }
}