namespace Projeto-Final-ED2{

internal class Model_Contrato
{
    public int NumeroSequencial { get; set; }
    public DateTime DataSaida { get; set; }
    public DateTime DataRetorno { get; set; }
    public Equipamento Equipamento { get; set; }

    public Model_Contrato()
    {
        
    }

    public Model_Contrato(int numeroSequencial, DateTime dataSaida, DateTime dataRetorno, Equipamento equipamento)
    {
        NumeroSequencial = numeroSequencial;
        DataSaida = dataSaida;
        DataRetorno = dataRetorno;
        Equipamento = equipamento;
    }
  }
}