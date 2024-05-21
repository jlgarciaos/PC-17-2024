using System;
using System.Collections.Generic;
using System.Linq;
//Juan Luis Garcia Osorio - 1307224
class Program
{
    public class Cuenta
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string DPI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Saldo { get; set; } = 2500;
        public List<string> Transacciones { get; set; } = new List<string>();
        public int AbonosRealizados { get; set; } = 0;
    }

    static void Main()
    {
        Cuenta cuenta = new Cuenta();
        InicializarCuenta(cuenta);

        int opcion = -1;
        do
        {
            MostrarMenu();
            opcion = LeerEntero("Seleccione una opción: ");
            switch (opcion)
            {
                case 1:
                    VerInformacionCuenta(cuenta);
                    break;
                case 2:
                    ComprarProductoFinanciero(cuenta);
                    break;
                case 3:
                    VenderProductoFinanciero(cuenta);
                    break;
                case 4:
                    AbonarCuenta(cuenta);
                    break;
                case 5:
                    SimularPasoTiempo(cuenta);
                    break;
                case 6:
                    ImprimirInformeTransacciones(cuenta);
                    break;
                case 7:
                    Console.WriteLine("Saliendo del sistema");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                    break;
            }
        } while (opcion != 10);
    }

    static void InicializarCuenta(Cuenta cuenta)
    {
        Console.WriteLine("Ingrese los datos de la cuenta:");
        cuenta.Tipo = LeerCadena("Tipo de cuenta (monetaria quetzales, monetaria dólares, ahorro quetzales, ahorro dólares): ");
        cuenta.Nombre = LeerCadena("Nombre: ");
        cuenta.DPI = LeerDPI("DPI (5 caracteres numéricos): ");
        cuenta.Direccion = LeerCadena("Dirección: ");
        cuenta.Telefono = LeerCadena("Número de teléfono: ");
    }

    static void MostrarMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Ver información de la cuenta");
        Console.WriteLine("2. Comprar producto financiero");
        Console.WriteLine("3. Vender producto financiero");
        Console.WriteLine("4. Abonar a cuenta");
        Console.WriteLine("5. Simular paso del tiempo");
        Console.WriteLine("6. Imprimir informe de transacciones");
        Console.WriteLine("7. Salir");
    }

    static void VerInformacionCuenta(Cuenta cuenta)
    {
        Console.WriteLine("\nInformación de la cuenta:");
        Console.WriteLine($"Tipo: {cuenta.Tipo}");
        Console.WriteLine($"Nombre: {cuenta.Nombre}");
        Console.WriteLine($"DPI: {cuenta.DPI}");
        Console.WriteLine($"Dirección: {cuenta.Direccion}");
        Console.WriteLine($"Teléfono: {cuenta.Telefono}");
        Console.WriteLine($"Saldo: Q{cuenta.Saldo:F2}");
        Console.WriteLine("Transacciones:");
        foreach (var transaccion in cuenta.Transacciones)
        {
            Console.WriteLine(transaccion);
        }
    }

    static void ComprarProductoFinanciero(Cuenta cuenta)
    {
        double decremento = cuenta.Saldo * 0.10;
        cuenta.Saldo -= decremento;
        string transaccion = $"[{DateTime.Now}] Compra de producto financiero: -Q{decremento:F2}";
        cuenta.Transacciones.Add(transaccion);
        Console.WriteLine(transaccion);
        Console.WriteLine($"Saldo actual: Q{cuenta.Saldo:F2}");
    }

    static void VenderProductoFinanciero(Cuenta cuenta)
    {
        if (cuenta.Saldo <= 500)
        {
            Console.WriteLine("Saldo insuficiente para realizar la venta.");
            return;
        }
        double incremento = cuenta.Saldo * 0.11;
        cuenta.Saldo += incremento;
        string transaccion = $"[{DateTime.Now}] Venta de producto financiero: +Q{incremento:F2}";
        cuenta.Transacciones.Add(transaccion);
        Console.WriteLine(transaccion);
        Console.WriteLine($"Saldo actual: Q{cuenta.Saldo:F2}");
    }

    static void AbonarCuenta(Cuenta cuenta)
    {
        if (cuenta.AbonosRealizados >= 2)
        {
            Console.WriteLine("No se pueden realizar más abonos este mes.");
            return;
        }
        cuenta.Saldo *= 2;
        cuenta.AbonosRealizados++;
        string transaccion = $"[{DateTime.Now}] Abono a cuenta: saldo duplicado";
        cuenta.Transacciones.Add(transaccion);
        Console.WriteLine(transaccion);
        Console.WriteLine($"Saldo actual: Q{cuenta.Saldo:F2}");
    }

    static void SimularPasoTiempo(Cuenta cuenta)
    {
        int dias = LeerEntero("Ingrese la cantidad de días a simular: ");
        int capitalizaciones = LeerEntero("Ingrese la cantidad de capitalizaciones al mes (1 o 2): ");
        double tasaInteres = 0.02;
        double interes = cuenta.Saldo * tasaInteres * dias / 360;
        cuenta.Saldo += interes;
        string transaccion = $"[{DateTime.Now}] Simulación de tiempo: +Q{interes:F2}";
        cuenta.Transacciones.Add(transaccion);
        Console.WriteLine(transaccion);
        Console.WriteLine($"Saldo actual: Q{cuenta.Saldo:F2}");
    }

    static void ImprimirInformeTransacciones(Cuenta cuenta)
    {
        Console.WriteLine("Informe de transacciones:");
        foreach (var transaccion in cuenta.Transacciones)
        {
            Console.WriteLine(transaccion);
        }
    }

    static string LeerCadena(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine();
    }

    static int LeerEntero(string mensaje)
    {
        int resultado;
        while (true)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out resultado))
            {
                return resultado;
            }
            Console.WriteLine("Entrada no válida. Inténtelo de nuevo.");
        }
    }

    static string LeerDPI(string mensaje)
    {
        string resultado;
        while (true)
        {
            Console.Write(mensaje);
            resultado = Console.ReadLine();
            if (resultado.All(char.IsDigit) && resultado.Length == 5)
            {
                return resultado;
            }
            Console.WriteLine("DPI no válido. Debe ser un número de 5 caracteres.");
        }
    }
}
