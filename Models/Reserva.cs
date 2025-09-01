using System;
using System.IO;
using System.Collections.Generic;
namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try
            {
                // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                // *IMPLEMENTE AQUI*
                if (Hospedes == null)
                    Hospedes = new List<Pessoa>();
                if (hospedes.Count <= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                    Console.WriteLine("Hóspedes cadastrados com sucesso!");
                }
                else
                {
                    throw new ArgumentException("Capacidade máxima da suíte atingida.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Erro detectado: " + e.Message);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Console.WriteLine("Suite Cadastrada");
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            Hospedes.ForEach(delegate (Pessoa pessoa) { Console.WriteLine($"Hospede:{pessoa.NomeCompleto}"); });
            return Hospedes.Count;

        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados * Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados >= 10)
            {
                decimal Deconto = valor * 0.09m;
                valor = valor - Deconto;
            }

            return valor;
        }
    }
}