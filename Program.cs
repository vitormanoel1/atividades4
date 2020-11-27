using System;

namespace atividades3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaValida;
            int escolha;
            int contador = 0;
            string resposta;

            //dados
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string[5];

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("--- Sistema de Passagens ---");
            Console.WriteLine("----------------------------");

            //login
            do {
            Console.WriteLine("Digite a senha para prosseguir: ");
            string senha = Console.ReadLine();
            senhaValida = EfetuarLogin(senha);
            } while(!senhaValida);

            //menu
            do {
                Console.WriteLine("Menu principal");
                Console.WriteLine();
                Console.WriteLine("Selecione uma opção para continuar");
                Console.WriteLine("[1] - Cadastrar Passagem(ens)");
                Console.WriteLine("[2] - Mostrar Passagem(ens)");
                Console.WriteLine("[0] - Sair");
                Console.WriteLine();
                escolha = int.Parse(Console.ReadLine());

                switch(escolha)
                {
                    case 1:
                        Console.WriteLine("Cadastro de passageiro");
                        do {
                            if(contador < 5) {
                                Console.WriteLine($"Digite o nome do {contador+1}° passageiro: ");
                                nome[contador] = Console.ReadLine();
                                Console.WriteLine("Digite o destino: ");
                                destino[contador] = Console.ReadLine();
                                Console.WriteLine("Digite a origem:");
                                origem[contador] = Console.ReadLine();
                                Console.WriteLine("Digite uma data de voo");
                                data[contador] = Console.ReadLine();
                                contador++;
                            } else {
                                Console.WriteLine("Limite excedido! Tente novamente!");
                                break;
                            }
                            Console.WriteLine("Você gostaria de adicionar um novo passageiro? s/n");
                            resposta = Console.ReadLine();
                        
                        } while(resposta.ToUpper() == "S");
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Listar Passagens");
                        for (var i = 0; i < contador; i++)
                        {
                            Console.WriteLine($"Passageiro(a) {nome[i]}, Origem {origem[i]}, Destino {destino[i]}, data {data[i]}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Muito obrigado pela confiança!");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!");
                        break;
                }
            } while(escolha != 0);

            // Funçao
            bool EfetuarLogin(string senha) {
                if(senha == "123456") {
                    Console.WriteLine("Sua senha foi aceita!");
                    return true;
                } else {
                    Console.WriteLine("Sua senha não foi aceita. Tente novamente");
                    return false;
                }
            }
        }
    }
}
