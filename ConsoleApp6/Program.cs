namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<dispositivo> dispos = new List<dispositivo>();
            Console.WriteLine("cuantos dispositivos desea ingresar?");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<= n ; i++)
            {
                dispositivo d = new dispositivo();
                Console.WriteLine("nombre: ");
                d.Nombre = Console.ReadLine();
                Console.WriteLine("prueba 1: ");
                d.resultado1 = double.Parse(Console.ReadLine());
                Console.WriteLine("prueba 2: ");
                d.resultado2 = double.Parse(Console.ReadLine());
                Console.WriteLine("prueba 3: ");
                d.resultado3 = double.Parse(Console.ReadLine());
                dispos.Add(d);

                Console.WriteLine("\n---LISTADO DE DISPOSITIVOS---");
                foreach(dispositivo d in dispos)
                {
                    d.MostrarDatos();
                    if(d.CalcularPromedio()>=80)
                    {
                        Console.WriteLine("optimo");

                    }
                    else if(d.CalcularPromedio()<80)
                    {
                        Console.WriteLine("necesita mantenimiento");
                    }
                }
            }
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
