namespace ClassificaçãoDeTriangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                ExibirCabecalho();

                int X = LerLados("X");
                int Y = LerLados("Y");
                int Z = LerLados("Z");

                ExibirValoresInformados(X, Y, Z);

                // Validacao Triangulo
                

                if (MedidasFormamTrianguloValido(X, Y, Z))
                {

                    string triangulo = ClasssificarTriangulo(X, Y, Z);
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

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Classificao de Triangulos");
            Console.WriteLine("---------------------------------------");
        }

         public  static int LerLados(string nomelado)
        {
            int Valor;
            while (true)
            {
                Console.WriteLine($"Informe o valor de {nomelado}");
                bool ConseguiuConverter = int.TryParse(Console.ReadLine(), out Valor);

                if (ConseguiuConverter)
                    break;
            }
            return Valor;
        }

        public static void ExibirValoresInformados(int X, int Y, int Z)
        {

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Valores Digitados");
            Console.WriteLine($"Lado X: {X}");
            Console.WriteLine($"Lado Y: {Y}");
            Console.WriteLine($"Lado Z: {Z}");
            Console.WriteLine("---------------------------------------");

        }

        public static bool MedidasFormamTrianguloValido(int X, int Y, int Z)
        {
            bool MedidasValidas = X + Y > Z && X + Z > Y && Y + Z > X;
            return MedidasValidas;
        }

        public static string ClasssificarTriangulo(int X,int  Y, int Z)
        {
            bool trianguloEquilatero = X == Z && X == Y;
            bool trianguloEscaleno = X != Z && X != Y && Y != Z;

            string triangulo;
            if (trianguloEquilatero)
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

            return triangulo;
        }
    }
}
