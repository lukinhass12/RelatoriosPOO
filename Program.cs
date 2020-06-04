using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensal mes = new Mensal();
            mes.MostrarRelatorio();
            System.Console.WriteLine("Digite a data do mês do Relatório:");
            mes.data = DateTime.Parse( Console.ReadLine() );
            

            Anual ano = new Anual();
            ano.MostrarRelatorio();
            System.Console.WriteLine("Digite a data do ano do relatório:");
            ano.data = DateTime.Parse( Console.ReadLine() );




        }
    }
}