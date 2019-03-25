using System;
using System.Collections.Generic;

namespace NotaFiscal
{
    public class GerarComponentesDaNotaFiscal
    {
        private List<ItensDaNotaFiscal> Lista = new List<ItensDaNotaFiscal>();
        private ItensDaNotaFiscal Itens;
        
        public void CadastrarNovoProduto()
        {
            Itens = new ItensDaNotaFiscal();

            Console.WriteLine("\t\tInsira o nome de um novo produto: ");
            Console.Write("\t\t");
            Itens.Produtos = Console.ReadLine();

            Console.WriteLine("\t\tInsira Preço do Produto: ");
            Console.Write("\t\t");
            Itens.PrecoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\t\tInsira A quantidade De produtos: ");
            Console.Write("\t\t");
            Itens.Quantidade = Convert.ToInt32(Console.ReadLine());
            
            int[] codigoCliente = new int[1];
            Random random = new Random();
            for (int i = 0; i < codigoCliente.Length; i++)
            {
                codigoCliente[i] = random.Next(2000000, 10000000);
                Itens.CodigoDoCliente = codigoCliente[i];
                Console.WriteLine("\t\tCodigo do cliente: " + codigoCliente[i]);
            }

            int[] CodigoProduto = new int[1];
            Random codigoAleatorio = new Random();

            for (int i = 0; i < CodigoProduto.Length; i++)
            {
                CodigoProduto[i] = codigoAleatorio.Next(200000, 1000000);
                Itens.CodigoDoProduto = CodigoProduto[i];
                Console.WriteLine("\t\tCodigo do Produto: " + CodigoProduto[i]);
            } 

            if (ChecarCodigoDoProduto(Itens.CodigoDoProduto) == null) 
            { 
              Lista.Add(Itens); 
              Console.WriteLine("\t\tCadastro efetuado com sucesso!");                
            } 
            else 
            { 
              Console.WriteLine("\t\tCódigo do produto repetido!"); 
            } 
            Console.ReadKey(); 
        } 

        public void MostrarCadastrosEfetuados() 
        { 
            foreach (ItensDaNotaFiscal item in Lista) 
            {
                item.MostrarItens();               
            } 
            Console.ReadKey(); 
        }  

        private ItensDaNotaFiscal ChecarCodigoDoProduto(int Codigo)
        {
            foreach(ItensDaNotaFiscal item in Lista)
            {
                if (item.CodigoDoProduto == Codigo)
                {
                    return item;
                }
            }
            return null;
        }  
    }
}
