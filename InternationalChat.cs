using System;

//Rafael ganhou recentemente uma bolsa de estudos e está estudando fora do Brasil, onde conheceu várias pessoas de diversas nacionalidades. A língua nativa deste país é o inglês, e todas as pessoas que Rafael conheceu falam inglês como primeira ou segunda língua.

//Como aprender uma segunda língua é uma tarefa difícil e cansativa, algumas pessoas preferem falar em sua própria língua nativa sempre que possível. Uma exceção a essa regra é quando há duas pessoas no grupo que não têm o mesmo idioma nativo. Nesse tipo de situação, o idioma que eles falam é o inglês.

//Por exemplo, se houver um grupo com apenas brasileiros, o idioma falado será o português, mas se houver um espanhol entre eles, o idioma falado será o inglês.

//Rafael às vezes fica confuso sobre qual idioma deve ser falado em cada grupo de pessoas, e então ele pede sua ajuda.

//Entrada
//A primeira linha conterá um inteiro N , representando o número de casos de teste a seguir.

//Cada caso de teste começa com um inteiro K (2 ≤ K ≤ 100), representando o número de pessoas no grupo. A seguir, haverá K linhas, contendo uma string S cada, representando a língua nativa dessas K pessoas.

//Cada string conterá no mínimo 1 e no máximo 20 caracteres, apenas com letras minúsculas (az).

namespace InternationalChat
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdCases; i++)
            {
                int qtdPeople = int.Parse(Console.ReadLine());
                string[] lang = new string[qtdPeople];
                bool flagIsEnglish = false;
                for (int j = 0; j < qtdPeople; j++)
                {
                    lang[j] = Console.ReadLine();
                    if (j >= 1 && lang[j - 1].ToLower() != lang[j].ToLower()) flagIsEnglish = true;

                }
                Console.WriteLine(flagIsEnglish == true ? "inglês" : lang[0]);

        }
    }
    }
}
