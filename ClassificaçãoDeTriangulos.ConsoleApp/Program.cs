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

                int X;
                int Y;
                int Z;
                // tryparse é tentar converter
                while(true)
                {
                    Console.WriteLine("Informe o valor de X");
                    bool ConseguiuConverter = int.TryParse(Console.ReadLine(), out X);

                    if (ConseguiuConverter)
                        break;
                }

                while(true)
                {
                    Console.WriteLine("Informe o valor de Y");
                    bool ConseguiuConverter = int.TryParse(Console.ReadLine(), out Y);

                    if (ConseguiuConverter)
                        break;
                }

                while(true)
                {
                    Console.WriteLine("Informe o valor de Z");
                    bool ConseguiuConverter = int.TryParse(Console.ReadLine(), out Z);

                    if (ConseguiuConverter)
                        break;
                }




                

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Valores Digitados");
                Console.WriteLine($"Lado X: {X}");
                Console.WriteLine($"Lado Y: {Y}");
                Console.WriteLine($"Lado Z: {Z}");
                Console.WriteLine("---------------------------------------");

                // Validacao Triangulo
                bool MedidasValidas = X + Y > Z && X + Z > Y && Y + Z > X;


                if (MedidasValidas == true)
                {
                    bool trianguloEquilatero = X == Z && X == Y;
                    bool trianguloEscaleno = X != Z && X != Y && Y != Z;

                    Console.WriteLine("Triangulo Valido");
                    string triangulo;
                    if(trianguloEquilatero)
                    {
                        triangulo = "Equilatero";
                    }

                  
                    else if (trianguloEscaleno)
                    {
                        triangulo = "Escaleno";
                    }

                    else 
                    {
                        triangulo = "Isosceles";
                    }

                    Console.WriteLine($"O triangulo é {triangulo} \nTecle ENTER para continuar");
                    Console.ReadLine();



                }

                else
                {
                    Console.WriteLine("Os valores Informados não formam um triangulo valido");
                }












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
