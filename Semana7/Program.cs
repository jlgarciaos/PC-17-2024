class Program
{
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo proyecto");
            string sNombre;
            string sEdad;
            string sCarrera;
            string sCarnet;

            Console.WriteLine("Ingrese su nombre");
            sNombre=Console.ReadLine();

            Console.WriteLine("Ingrese su edad");
            sEdad=Console.ReadLine();

            Console.WriteLine("Ingrese su carnet");
            sCarnet=Console.ReadLine();

            Console.WriteLine("Ingrese su carrera");
            sCarrera=Console.ReadLine();

            Console.WriteLine("Soy " + sNombre + " tengo " + sEdad + " y estudio la carrera de " + sCarrera + " Mi numero de carnet es " + sCarnet);
        }
}