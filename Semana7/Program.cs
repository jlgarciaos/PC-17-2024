using System;

public class EquivalenciaBilletesMonedas
{
    public static void Main(string[] args)
    {
        // Mostrar nombre y número de carné
        Console.WriteLine("Nombre:");
        Console.WriteLine("Número de carné:");

        // Solicitar la cantidad al usuario
        Console.Write("Ingrese la cantidad en quetzales: ");
        double cantidad = double.Parse(Console.ReadLine());

        // Validar la cantidad
        if (cantidad < 0 || cantidad > 999.99)
        {
            Console.WriteLine("Error: La cantidad debe estar entre 0 y 999.99.");
            return;
        }

        // Desglosar la cantidad en billetes y monedas
        int[] billetes = { 100, 50, 20, 10, 5 };
        int[] monedas = { 1, 25, 1 };

        // Calcular la cantidad de billetes y monedas
        for (int i = 0; i < billetes.Length; i++)
        {
            int cantidadBilletes = (int)(cantidad / billetes[i]);
            Console.WriteLine($"{cantidadBilletes} billetes de {billetes[i]} quetzales");
            cantidad -= cantidadBilletes * billetes[i];
        }

        for (int i = 0; i < monedas.Length; i++)
        {
            int cantidadMonedas = (int)(cantidad / monedas[i]);
            if (monedas[i] == 1)
            {
                Console.WriteLine($"{cantidadMonedas} monedas de {monedas[i]} quetzal");
            }
            else
            {
                Console.WriteLine($"{cantidadMonedas} monedas de {monedas[i]} centavos");
            }
            cantidad -= cantidadMonedas * monedas[i];
        }

        Console.WriteLine($"Cantidad restante: {cantidad:F2} quetzales");
    }
}