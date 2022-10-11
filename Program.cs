using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace desafioss
{
    class desafios
    {
        static void Main (string[] args)
        {
            Double id1, id2, quantidade1, quantidade2, valor1, valor2, valorProduto1, valorProduto2, valorTotal;

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


            Console.WriteLine("Valor a pagar: " + valorTotal); 


            // Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro casas decimais // 


            Double raio, area, pi;   
            

            Console.WriteLine("Digite o raio do circulo");
            raio = Double.Parse(Console.ReadLine());

            pi = 3.14159;
            area = pi * (raio* raio);

            

            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();



              string produto1 = "Computador";
              string produto2 = "Mesa de escritório";

              byte idade = 30;
              int codigo = 5290;
              char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"{produto1} cujo preço é {preco1.ToString("F2")}");
            Console.WriteLine($"{produto2} cujo preço é {preco2.ToString("F2")}");

            Console.WriteLine($"Registro: {idade} anos de idade, codigo {codigo} e gênero: {genero}");

            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado 3 casas decimais: {medida.ToString("F3")}");
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}") ;

            


        }

    }

    
}