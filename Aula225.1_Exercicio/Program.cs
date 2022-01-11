/* Exercicio 
 * 
 * Fazer um programa que, a partir de uma lista de produtos, calcule a soma dos preços somente dos produtos 
 * cujoS nomeS comecem com "T". 
 */

/* >>>PROGRAMA PRINCIPAL <<< */
using System;
using System.Collections.Generic;
using System.Globalization;
using Aula225._1_Exercicio.Services;
using Aula225._1_Exercicio.Entities;

namespace Aula225._1_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria lista Product e preenche
            List<Product> list = new List<Product>(); 
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Instancia variavel "ps" tipo "ProductService"
            ProductService ps = new ProductService(); // Instancia "ps" do tipo "ProductService", sem argumentos 

            /* Executa a funcao "FilteredSum", recebendo os argumentos "list" (lista de produdos), "p", tipo "Product"
             * (o tipo e automaticamente detectado e incutido pelo C#), onde a letra do nome do produto seja na posicao
             * 0 seja a letra "T" */
            double sum = ps.FilteredSum(list, p => p.Name[0] == 'T');

            Console.WriteLine("Sum = " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
