using System;
using System.Collections.Generic;

namespace Projeto-Final-ED2{

internal class ContratoController
{
    private Estoque estoque;
    private Stack<Model_Contrato> itensLiberados;

    public ContratoController(Estoque estoque)
    {
        this.estoque = estoque;
        this.itensLiberados = new Stack<Model_Equip>();
    }

    public void LiberarItens(Model_Contrato contrato)
    {
        Console.WriteLine($"Liberação de itens para o Contrato {contrato.NumeroSequencial}:");

        foreach (var equipamento in contrato.Model_Equip)
        {
            if (estoque.Equipamentos.Contains(equipamento))
            {
                estoque.Equipamentos.Remove(equipamento);
                itensLiberados.Push(equipamento);
                Console.WriteLine($"- {equipamento.IdentificacaoPatrimonio}");
            }
            else
            {
                Console.WriteLine($"- {equipamento.IdentificacaoPatrimonio} não disponível no estoque");
            }
        }
    }

    public void DevolverItens(Model_Contrato contrato)
    {
        Console.WriteLine($"Devolução de itens para o Contrato {contrato.NumeroSequencial}:");

        while (itensLiberados.Count > 0)
        {
            var equipamento = itensLiberados.Pop();
            Console.WriteLine($"- {equipamento.IdentificacaoPatrimonio}");

    
        }

        decimal valorDevido = contrato.Equipamento.Count * contrato.Equipamento[0].ValorDiarioLocacao;
        Console.WriteLine($"Valor devido: R$ {valorDevido}");

        Console.WriteLine($"Contrato {contrato.NumeroSequencial} removido dos controles da empresa");
    }
  }
}
