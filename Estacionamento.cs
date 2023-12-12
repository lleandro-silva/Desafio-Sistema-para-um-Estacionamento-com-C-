using System;
using System.Collections.Generic;

class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo(string placa)
    {
        veiculos.Add(placa);
        Console.WriteLine($"Veículo de placa {placa} adicionado ao estacionamento.");
    }

    public void RemoverVeiculo(string placa)
    {
        if (veiculos.Contains(placa))
        {
            Console.Write($"Informe a quantidade de horas que o veículo {placa} permaneceu no estacionamento: ");
            int horasEstacionado = int.Parse(Console.ReadLine());

            decimal valorCobrado = CalcularValorCobrado(horasEstacionado);
            Console.WriteLine($"Valor cobrado para o veículo {placa}: R${valorCobrado}");

            veiculos.Remove(placa);
        }
        else
        {
            Console.WriteLine($"Veículo de placa {placa} não está estacionado.");
        }
    }

    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var placa in veiculos)
            {
                Console.WriteLine(placa);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }

    private decimal CalcularValorCobrado(int horasEstacionado)
    {
        return precoInicial + (precoPorHora * horasEstacionado);
    }
}