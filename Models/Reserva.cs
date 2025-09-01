using System;
using System.IO;
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
            DiasReserva.dos = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            try
            {
                // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                // *IMPLEMENTE AQUI*
                if (Hospedes >= Suite.Capacidade)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    // *IMPLEMENTE AQUI*
                    throw new ArgumentException("Capacidade Máxima Atingida");

                }

            }catch(Exception e) {
                throw new Arguments("Erro detectado: " + e);
            }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return QuantidadeHospedes;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = DiasReservados*Suite.ValorDiaria;
            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*
            if (DiasReservados>=10)
            {
                valor = (DiasReservados*Suite.ValorDiaria)-0.10;  
            }

            return valor;
        }
    }
}