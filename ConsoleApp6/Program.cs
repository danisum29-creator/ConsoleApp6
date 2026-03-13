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

            public string DeterminarEstado()
            {
                if(CalcularPromedio()>=80)
                {
                    return "Optimo";
                }
                else if (CalcularPromedio()<80)
                {
                    return "necesita mantenimiento";
                }

            }
            public void MostrarDatos()
            {
                Console.WriteLine($" Nombre: {Nombre} | Prueba de rendimiento 1: {resultado1} | Prueba de rendimiento 2: {resultado2} | Prueba de rendimiento 3: {resultado3}");
            }
        }
    }
}
