/*>>> CLASSE PRODUCTSERVICE - SERVICE <<< */
using System;
using System.Collections.Generic;
using Aula225._1_Exercicio.Entities;

namespace Aula225._1_Exercicio.Services
{
    class ProductService
    {
        /* Cria uma funcao "FilteredSum", recebendo como argumentos uma List ("list") do tipo "Product" e uma Func.
         * Esta Func, por sua vez, recebe um elemento tipo "Product" como entrada e retorna um "bool" como saida. 
         * O nome "criteria" foi dado a essa Func. */
        public double FilteredSum(List<Product> list, Func<Product, bool> criteria) 
        {
            double sum = 0.0; // Variavel auxiliar
            foreach (Product p in list) // Para cada produto da lista 
            {
                if (criteria.Invoke(p)) // Invoca as informacoes do produto
                {
                    sum += p.Price; // Soma os produtos
                }
            }
            return sum; // Retorna a soma
        }
    }
}
