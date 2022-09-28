using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    class Venda
    {
        static void Main (string[] args)
        {
            double id1, id2, quantidade1, quantidade2, valor1, valor2, valorProduto1, valorProduto2, valorTotal;

            Console.WriteLine("Digite o ID do Prieiro Produto");
            id1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID do Segundo Produto");
            id2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade do primeiro Produto");
            quantidade1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade do segundo Produto");
            quantidade2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do primeiro produto");
            valor1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Valor do segundo produto");
            valor2 = Double.Parse(Console.ReadLine());


            valorProduto1 = valor1 * quantidade1;
            valorProduto2 = valor2 * quantidade2;
            valorTotal = valorProduto1 + valorProduto2;


            Console.WriteLine("Valor a pagar: " +valorTotal);
            
            
            


        }

    }
}