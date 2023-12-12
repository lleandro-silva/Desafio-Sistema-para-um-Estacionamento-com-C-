using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento(precoInicial: 5.0m, precoPorHora: 2.0m);

        int opcao;
        do
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Remover veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Encerrar");
            Console.Write("Escolha uma opção (1-4): ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite a placa do veículo: ");
                    string placaCadastro = Console.ReadLine();
                    estacionamento.AdicionarVeiculo(placaCadastro);
                    break;

                case 2:
                    Console.Write("Digite a placa do veículo a ser removido: ");
                    string placaRemocao = Console.ReadLine();
                    estacionamento.RemoverVeiculo(placaRemocao);
                    break;

                case 3:
                    estacionamento.ListarVeiculos();
                    break;

                case 4:
                    Console.WriteLine("Encerrando o programa.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 4);
    }
}