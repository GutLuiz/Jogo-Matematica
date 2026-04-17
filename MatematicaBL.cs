using System;
using System.Collections.Generic;
using System.Text;

namespace Jogo_de_Matematica
{
    internal class MatematicaBL
    {
        /*
            - Você precisa criar um jogo que consista em perguntar ao jogador qual é o resultado de uma questão
            - matemática (ex: 9 x 9 = ?), coletar as respostas e adicionar um ponto em caso de resposta correta.
            
            - Um jogo precisa ter pelo menos 5 perguntas.

            - As divisões devem resultar APENAS em números inteiros e os dividendos devem variar de 0 a 100.
            - Exemplo: Seu aplicativo não deve apresentar a divisão 7/2 ao usuário, pois ela não resulta em um número inteiro.

            - Os usuários devem visualizar um menu para escolher uma operação.

            - Você deve registrar os jogos anteriores em uma lista e deve haver uma opção no menu para o usuário visualizar o histórico dos jogos anteriores.
            
            - Não é necessário registrar os resultados em um banco de dados. Assim que o programa for fechado, os resultados serão apagados.

            passo a passo:
             1 - usuario abre o console
             2 - usuario escolhe operacao de soma
             3 - usuario escreve respota de soma, vem a respota certa ou nao. volta pro menu.
             3 - usuario pode acessar os jogos anteriores 
         */


        public class Jogo
        {
            private List<string> _historico = new List<string>();
            Random random = new Random();
            public void Menu()
            {
                Console.WriteLine("Bem vindo ao jogo de matematica!!");
                Console.WriteLine("Escolha uma opcao:");
                Console.WriteLine("1 - Para operacoes de soma. ");
                Console.WriteLine("2 - Para operacoes de subtracao.");
                Console.WriteLine("3 - Para operacoes de multiplicacao.");
                Console.WriteLine("4 - Para operacoes de divisao.");
                Console.WriteLine("5 - Visualizar historicos dos jogos.");

                int escolha = int.Parse(Console.ReadLine());

                Operacoes(escolha);
            }
            public void Operacoes(int escolha)
            {
                if (escolha == 1)
                {
                    OperacaoSoma();
                }
                else if (escolha == 2)
                {
                    OperacaoSubtracao();
                }
                else if (escolha == 3)
                {
                    OperacaoMultiplicacao();
                }
                else if (escolha == 4)
                {
                    OperacaoDivisao();
                }
                else if (escolha == 5)
                {
                    foreach(string lista in _historico)
                    {
                        Console.WriteLine(lista);
                    }
                }
            }
            public void OperacaoSoma()
            {
                for (int i = 0; i < 5; i++)
                {
                    int numero1 = random.Next(0, 101);
                    int numero2 = random.Next(0, 101);

                    int resultado = numero1 + numero2;

                    Console.WriteLine($"Quanto é {numero1} + {numero2}?");
                    int respostaUsuario = int.Parse(Console.ReadLine());

                    string historico = "";
                    if (respostaUsuario == resultado)
                    {
                        historico = $"Operacao soma: {i} - Certa resposta!";
                        Console.WriteLine("Certa resposta");
                    }
                    else
                    {
                        historico = $"Operacao soma: {i} - Resposta errada!";
                        Console.WriteLine("Resposta errada!");
                    }
                    _historico.Add(historico);
                }
                Menu();
            }
            public void OperacaoSubtracao()
            {
                for (int i = 0; i < 5; i++)
                {
                    int numero1 = random.Next(0, 101);
                    int numero2 = random.Next(0, 101);

                    int resultado = numero1 - numero2;

                    Console.WriteLine($"Quanto é {numero1} + {numero2}?");
                    int respostaUsuario = int.Parse(Console.ReadLine());

                    string historico = "";
                    if (respostaUsuario == resultado)
                    {
                        historico = $"Operacao Subtracao: {i} - Certa resposta!";
                        Console.WriteLine("Certa resposta");
                    }
                    else
                    {
                        historico = $"Operacao Subtracao: {i} - Resposta errada!";
                        Console.WriteLine("Resposta errada!");
                    }
                    _historico.Add(historico);
                }
                Menu();
            }
            public void OperacaoDivisao()
            {
                for (int i = 0; i < 5; i++)
                {
                    int divisor = random.Next(1, 11);
                    int resultado = random.Next(0, 11);

                    int dividendo = divisor * resultado;

                    Console.WriteLine($"Quanto é {dividendo} ÷ {divisor}?");
                    int respostaUsuario = int.Parse(Console.ReadLine());

                    string historico = "";
                    if (respostaUsuario == resultado)
                    {
                        historico = $"Operacao Divisao: {i} - Certa resposta!";
                        Console.WriteLine("Certa resposta");
                    }
                    else
                    {
                        historico = $"Operacao Divisao: {i} - Resposta errada!";
                        Console.WriteLine("Resposta errada!");
                    } 
                    _historico.Add(historico);
                }
                Menu();
            }
            public void OperacaoMultiplicacao()
            {
                for (int i = 0; i < 5; i++)
                {
                    int numero1 = random.Next(0, 101);
                    int numero2 = random.Next(0, 101);

                    int resultado = numero1 * numero2;

                    Console.WriteLine($"Quanto é {numero1} x {numero2}?");
                    int respostaUsuario = int.Parse(Console.ReadLine());

                    string historico = "";
                    if (respostaUsuario == resultado)
                    {
                        historico = $"Operacao Multiplicacao: {i} - Certa resposta!";
                        Console.WriteLine("Certa resposta");
                    }
                    else
                    {
                        historico = $"Operacao Multiplicacao: {i} - Resposta errada!";
                        Console.WriteLine("Resposta errada!");
                    }
                    _historico.Add(historico);
                }
                Menu();
            }
        }
    }
}