
namespace ClassificaçãoDeTriangulos.ConsoleApp
{
    public class Triangulo
    {
        public static bool MedidasFormamTrianguloValido(int X, int Y, int Z)
        {
            bool MedidasValidas = X + Y > Z && X + Z > Y && Y + Z > X;
            return MedidasValidas;
        }
        public static string ClasssificarTriangulo(int X, int Y, int Z)
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
