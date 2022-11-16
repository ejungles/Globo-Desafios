using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Globo.Questoes
{
    public static class Questao03
    {
        /*
         * Digamos que você tenha um array para o qual o elemento i é o preço de uma determinada ação no dia i. 
         * Se você tivesse permissão para concluir no máximo uma transação (ou seja, comprar uma e vender uma ação), crie um algoritmo para encontrar o lucro máximo.
         * --------------------
         * Realizar o loop no array informado e encontrar o valor mínimo entre o valor de [I] e o conteúdo de "valorMinimo", 
         * bem como o valor máximo da diferença entre o conteúdo de "lucroMaximo" e o valor de [I] - valorMinimo
         */

        public static void Executar(int[] dados)
        {
            Console.WriteLine($"Questão 03: Dados: [{String.Join(", ", dados)}] Resultado: {CalcularLucroMaximoAcoes(dados)}");
        }

        private static int CalcularLucroMaximoAcoes(int[] valores)
        {
            int lucroMaximo = 0;
            int valorMinimo = int.MaxValue;

            for (int i = 0; i < valores.Length; i++)
            {
                valorMinimo = Math.Min(valores[i], valorMinimo);
                lucroMaximo = Math.Max(lucroMaximo, valores[i] - valorMinimo);
            }

            return lucroMaximo;
        }
    }
}
