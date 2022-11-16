namespace Globo.Questoes
{
    public static class Questao02
    {
        /*
         * Um bracket é considerado qualquer um dos seguintes caracteres: (, ), {, }, [ ou ]. 
         * Dois brackets são considerados um par combinado se o bracket de abertura (isto é, (, [ou {) ocorre à esquerda de um bracket de fechamento (ou seja,),] ou} do mesmo tipo exato. 
         * Existem três tipos de pares de brackets : [ ], { } e ( ). 
         * Um par de brackets correspondente não é balanceado se o de abertura e o de fechamento não corresponderem entre sí. 
         * Por exemplo, {[(])} não é balanceado porque o conteúdo entre o {e} não é balanceado. 
         * O primeiro bracket inclui o de abertura, (, e o segundo inclui um bracket de fechamento desbalanceado].
         * Dado as sequencias de caracteres, determine se cada sequencia de brackets é balanceada. Se uma string estiver balanceada, retorne SIM. Caso contrário, retorne NÃO.
         * --------------------
         * A ideia é colocar todos os colchetes/chaves/parenteses de abertura na pilha. 
         * Sempre que você houver um colchetes/chaves/parenteses de fechamento, verificar se o topo da pilha é o colchete de abertura da mesma natureza. 
         * Caso positivo, abrir a pilha e continuar a iteração.
         * No final, se a pilha estiver vazia, significa que todos os colchetes/chaves/parenteses estão bem formados. 
         * Caso contrário, eles não são equilibrados.
         */

        public static void Executar(string[] expressao)
        {
            if (BracketsBalanceados(expressao))
            {
                Console.WriteLine($"Questão 02: Dados: {string.Join("", expressao)} - Resultado: SIM");
            }
            else
            {
                Console.WriteLine($"Questão 02: Dados: {string.Join("", expressao)} - Resultado: NÃO");
            }
        }

        private static Boolean BracketsBalanceados(string[] expressao)
        {
            Stack<String> pilha = new();

            for (int i = 0; i < expressao.Length; i++)
            {
                if (expressao[i] == "{" || expressao[i] == "[" || expressao[i] == "(")
                {
                    pilha.Push(expressao[i]);
                }
                if (expressao[i] == "}" || expressao[i] == "]" || expressao[i] == ")")
                {
                    if (pilha.Count == 0)
                    {
                        return false;
                    }
                    else if (!ChecarParzinho(pilha.Pop(), expressao[i]))
                    {
                        return false;
                    }
                }
            }

            if (pilha.Count() == 0)
            {
                return true;
            }

            return false;
        }

        private static Boolean ChecarParzinho(string valor1, string valor2)
        {
            if (valor1 == "(" && valor2 == ")")
            {
                return true;
            }
            else if (valor1 == "{" && valor2 == "}")
            {
                return true;
            }
            else if (valor1 == "[" && valor2 == "]")
            {
                return true;
            }
            return false;
        }

    }
}
