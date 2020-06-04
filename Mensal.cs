namespace Aula10Polimorfismo
{
    public class Mensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            System.Console.WriteLine("Mostrando relatório por mês.");
        }
    }
}