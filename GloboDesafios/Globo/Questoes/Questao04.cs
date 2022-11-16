namespace Globo.Questoes
{
    public static class Questao04
    {
        /*
         * Dados n inteiros não negativos representando um mapa de elevação onde a largura de cada barra é 1, calcule quanta água é capaz de reter após a chuva.
         * --------------------
         * A ideia é calcular a barra de altura máxima à esquerda e à direita de cada barra. 
         * A quantidade de água armazenada em cima de cada barra é igual ao mínimo entre a barra de início à esquerda e à direita menos a altura da barra atual.
         */

        public static void Executar(int[] dados)
        {
            int resultado = 0;

            for (int i = 0; i < dados.Length; i++)
            {
                int maximoEsquerda = 0;
                int maximoDireita = 0;

                for (int j = i; j >= 0; j--)
                {
                    maximoEsquerda = Math.Max(maximoEsquerda, dados[j]);
                }

                for (int j = i; j < dados.Length; j++)
                {
                    maximoDireita = Math.Max(maximoDireita, dados[j]);
                }

                resultado += Math.Min(maximoEsquerda, maximoDireita) - dados[i];
            }

            Console.WriteLine($"Questão 04: Dados: [{String.Join(", ", dados)}] Resultado: {resultado}");
        }
    }
}
