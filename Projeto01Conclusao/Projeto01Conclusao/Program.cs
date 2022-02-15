// See https://aka.ms/new-console-template for more information
namespace Projeto01Conclusao
{
    class Program
    {
        static void Main()
        {
            //float media = 0;

            //Console.WriteLine("Olá, bem vindo ao programa de cálculo de média!");
            //Console.WriteLine("Por favor digite a sua primeira nota: ");
            //int.TryParse(Console.ReadLine(), out int nota1);
            //Console.WriteLine("Por favor digite a sua segunda nota: ");
            //int.TryParse(Console.ReadLine(), out int nota2);
            //Console.WriteLine("Por favor digite a sua terceira nota: ");
            //int.TryParse(Console.ReadLine(), out int nota3);

            //media = (nota1 + nota2 + nota3) / 3;

            //Console.WriteLine("Sua média é: {0}", media);

            //if (media >= 7 && media <= 10)
            //{
            //    Console.WriteLine("Parabéns você está aprovado!!");
            //} else if (media > 10 || media < 0)
            //{
            //    Console.WriteLine("Confira se digitou as notas corretamente");
            //} else
            //{
            //    Console.WriteLine("Não foi dessa vez, mas continue estudando!");
            //}

            bool opcao = true;

            Console.WriteLine("Olá, irei realizar a soma de numeros que você deseja até que decida parar");
            Console.WriteLine("Digite o valor inicial");
            float.TryParse(Console.ReadLine(), out float inicial);

            while(opcao == true)
            {
                Console.WriteLine("Digite o número que deseja somar ao número inicial");
                float.TryParse(Console.ReadLine(), out float n1);
                inicial = inicial + n1;
                Console.WriteLine("A soma até o momento é {0}", inicial);
                Console.WriteLine("Deseja continuar somando? 1 - Sim / 2 - Não");
                int.TryParse(Console.ReadLine(), out int saida);
                switch (saida)
                {
                    case 1:
                        Console.WriteLine("Saindo do Programa");
                        opcao = false;
                        break;
                    case 2:
                        Console.WriteLine("Continua a Soma");
                        break;
                    default:
                        Console.WriteLine("Opção inválida, Retornando para soma.");
                        break;
                }
            }
        }
    }
}
