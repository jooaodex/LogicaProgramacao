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
        static void Main(string[] args)
        {
            /* Double id1, id2, quantidade1, quantidade2, valor1, valor2, valorProduto1, valorProduto2, valorTotal;

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

             Console.WriteLine($"Medida com oito casas decimais: {medida.ToString("F8")}");
             Console.WriteLine($"Arredondado 3 casas decimais: {medida.ToString("F3")}");
             Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}") ;


            // Exercicios  estrutura sequencial  Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma mensagem explicativa, conforme exemplos// 

            int valorUm;
            int valorDois;
            int resultado;

            Console.WriteLine("Digite o primeiro valor");
            valorUm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            valorDois = int.Parse(Console.ReadLine());

            resultado = valorUm + valorDois;


            Console.WriteLine("Soma:" + resultado) ;

           

            //Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).//

           

            int a;
            int b;
            int c;
            int d;
            int diferenca;

            Console.WriteLine("Primeiro valor:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Terceiro valor:");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine("Quarto valor:");
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);

            Console.WriteLine("Diferença:" + diferenca);


            //Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário.A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            int numFunc, hrTrab;
            double valorHr, salarioFunc;

            Console.WriteLine("Informe o número do Funcionário:");
            numFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora informe as horas trabalhadas desse funcionário:");
            hrTrab = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto esse funcionário recebe por hora?");
            valorHr = double.Parse(Console.ReadLine());

            salarioFunc = valorHr * hrTrab;

            Console.WriteLine("Número funcionário:" + numFunc);
            Console.WriteLine("Salário funcionário:" + salarioFunc.ToString("F2", CultureInfo.InvariantCulture)); */

            // Desafio While//

            int valor1, valor2;

            Console.WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            valor2 = int.Parse(Console.ReadLine());


            if (valor1 > valor2) 
            {
                Console.WriteLine("Valor 1 é o valor maior:" + valor1);
            }
            else
            {
                Console.WriteLine("valor 2 é o valor maior" + valor2);
            }

        }

    }
}