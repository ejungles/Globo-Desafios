namespace Globo.Questoes
{
    public static class Questao01
    {
        /*
         * Dado um array de números inteiros, retorne os índices dos dois números de forma que eles se somem a um alvo específico. 
         * Você pode assumir que cada entrada teria exatamente uma solução, e você não pode usar o mesmo elemento duas vezes
         * --------------------
         * Realizar um loop no array informado e verificar os elementos da lista para ver se a soma deles é igual ao alvo. Se for, retorne o resultado, se não, retorna -1.
         */

        public static void Executar()
        {
            int[] dados = { 9, 2, 8, 4, 5 };
            int alvo = 9;
            int[] resultado = Calcular(dados, alvo);
            Console.WriteLine($"Questão 01: Dados: [{String.Join(", ", dados)}] - Alvo: {alvo} - Resultado: {resultado[0]}, {resultado[1]}");
        }

        private static int[] Calcular(int[] dados, int alvo)
        {
            for (int i = 0; i < dados.Length; i++)
            {
                for (int j = i + 1; j < dados.Length; j++)
                {
                    if (dados[i] + dados[j] == alvo)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[] { -1, -1 };
        }
    }
}
