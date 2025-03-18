namespace ClassificaçãoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Classificao de Triangulos");
                Console.WriteLine("---------------------------------------");


                Console.WriteLine("Informe o valor de X");
                int X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor de Y");
                int Y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o valor de Z");
                int Z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Valores Digitados");
                Console.WriteLine($"Lado X: {X}");
                Console.WriteLine($"Lado Y: {X}");
                Console.WriteLine($"Lado Z: {X}");
                Console.WriteLine("---------------------------------------");













                Console.WriteLine("Deseja Continuar (S/N)");
                string continuar = Console.ReadLine()!.ToUpper();
            

                if (continuar != "S")
                {
                    break;
                }
            }
        }
    }
}
