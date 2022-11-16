using Globo.Questoes;

Questao01.Executar();

Console.WriteLine("\r");

string[] dados1Questao2 = { "{", "[", "(", ")", "]", "}" };
string[] dados2Questao2 = { "{", "[", "(", "]", ")", "}" };
string[] dados3Questao2 = { "{", "{", "[", "[", "(", "(", ")", ")", "]", "]", "}", "}" };
Questao02.Executar(dados1Questao2);
Questao02.Executar(dados2Questao2);
Questao02.Executar(dados3Questao2);

Console.WriteLine("\r");

int[] dadosQuestao3 = { 7, 1, 5, 3, 6, 4 };
Questao03.Executar(dadosQuestao3);

Console.WriteLine("\r");

int[] dadosQuestao4 = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
Questao04.Executar(dadosQuestao4);

Console.WriteLine("\r\n");