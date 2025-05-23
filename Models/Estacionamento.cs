using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal PrecoInicial { get; set; }
        public decimal PrecoHora { get; set; }
        public List<string> Veiculos { get; set; } = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            PrecoInicial = precoInicial;
            PrecoHora = precoHora;
        }

        public void AdicinarVeiculo(string placa)
        {
            Veiculos.Add(placa);
        }

        public void RemoverVeiculo(string placa)
        {
            Veiculos.Remove(placa);
        }

        public void ListarVeiculos()
        {
            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }

        public decimal CalcularPrecoEstacionamento(int horas)
        {
            return PrecoInicial + PrecoHora * horas;
        }

    }
}