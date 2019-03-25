using System;

namespace NotaFiscal
{
    public class ItensDaNotaFiscal : NotaFiscal
    {
        public string Produtos { get; set; }
        public int CodigoDoProduto { get; set; }    

        public void MostrarItens()
        {

            Console.WriteLine("\t------------------------------------");
            Console.WriteLine("\n\t\t  **ITENS**");
            Console.WriteLine("\n\tProduto: " + Produtos + "\n\tCódigo do produto: #" + CodigoDoProduto + "\n\tPreço unitário: R$" + PrecoUnitario + "\n\tQuantidade: " + Quantidade + " Unidades");
            Console.WriteLine("\t------------------------------------");

            Console.WriteLine("\n\t\t**NOTA FISCAL**");
            Console.WriteLine("\n\tCodigo do Cliente: @" + CodigoDoCliente + "\n\tValor de ICMS: R$" + GetValorDeICMS() + "\n\tValor total Dos Itens: R$" + GetValorTotalDosItens());
            Console.WriteLine("\t------------------------------------");
        }
        
    }    
}
