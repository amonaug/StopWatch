using System;
using System.ComponentModel.Design;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running) // Loop principal para manter o programa em execução até que seja explicitamente encerrado
            {
                Console.Clear(); // Limpa o console a cada iteração do loop para uma nova exibição de opções
                Console.WriteLine("S = Segundo = 10s = 10 segundos");
                Console.WriteLine("M = Minuto = 1m = 1 minuto");
                Console.WriteLine("0 = Sair");

                string data = Console.ReadLine().ToLower(); // Lê a entrada do usuário e converte para minúsculas para simplificar a lógica de verificação
                int num = int.Parse(data.Substring(0, data.Length - 1)); // Extrai o número da entrada do usuário
                char type = char.Parse(data.Substring(data.Length - 1, 1)); // Extrai o tipo (segundo ou minuto) da entrada do usuário

                if(type == 's' || type == 'm') // Verifica se o tipo é válido
                {
                    if(type == 's') // Se for segundo
                    {
                        Functions.Start(num); // Inicia o cronômetro com o número de segundos especificado
                    }
                    else // Se for minuto
                    {
                        Functions.Start(num*60); // Converte os minutos em segundos e inicia o cronômetro
                    }
                }
                else if(num == 0) // Se a entrada for '0', encerra o programa
                {
                    Console.WriteLine("Saindo..."); // Informa ao usuário que o programa está sendo encerrado
                    Thread.Sleep(500); // Aguarda meio segundo antes de encerrar
                    running = false; // Altera a variável de controle para encerrar o loop e, consequentemente, o programa
                }
                else // Se a entrada não for válida
                {
                    Console.WriteLine("Opção inválida"); // Informa ao usuário que a opção é inválida
                    Thread.Sleep(500); // Aguarda meio segundo antes de limpar o console e exibir novamente as opções
                }
            }
        }
        
    }
}
