namespace Projeto-Final-ED2{
internal class Model_Estoque
{
    public List<Model_Equip> Equipamentos { get; set; }

    public Model_Equip()
    {
        Equipamentos = new List<Model_Equip>();
    }

 
    public Model_Equip CadastrarEquipamento(string identificacaoPatrimonio, string avaria, decimal valorDiarioLocacao)
    {
        Model_Equip novoEquipamento = new Model_Equip(identificacaoPatrimonio, avaria, valorDiarioLocacao);
        Equipamentos.Add(novoEquipamento);
        return novoEquipamento;
    }
 }
}