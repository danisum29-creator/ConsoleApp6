namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        class dispositivo
        {
            public string Nombre;
            public double resultado1;
            public double resultado2; 
            public double resultado3;

            public double CalcularPromedio()
            {
                return ((resultado1+ resultado2+resultado3)/3);
            }
        }
    }
}
