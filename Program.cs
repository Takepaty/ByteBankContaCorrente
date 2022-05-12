using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGuilherme = new ContaCorrente(345, 25454654);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Número da Agencia: " + contaGuilherme.Agencia);
            Console.WriteLine("Número da Conta Corrente: " + contaGuilherme.Numero);


            ContaCorrente contaDaGabriela = new ContaCorrente(345, 25454655);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



            Console.WriteLine("Número da Agencia: " + contaDaGabriela.Agencia);
            Console.WriteLine("Número da Conta COrrente: " + contaDaGabriela.Numero);


            Console.ReadLine();
        }
    }
}
