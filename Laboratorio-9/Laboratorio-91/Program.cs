internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Usuario, ingrese el precio del producto (se admiten decimales): ");
        decimal prodprecio;

        while (!decimal.TryParse(Console.ReadLine(), out prodprecio) || prodprecio <= 0)
        {
            Console.WriteLine("Por favor, ingrese un precio válido y mayor a 0.");
            Console.Write("Usuario, ingrese el precio del producto nuevamente: ");
        }

        Console.Write("Ingrese la forma de pago (efectivo (1) o tarjeta (2)): ");
        int formaPago;

        while (!int.TryParse(Console.ReadLine(), out formaPago) || (formaPago != 1 && formaPago != 2))
        {
            Console.WriteLine("Por favor, ingrese una opción válida (1 para efectivo o 2 para tarjeta).");
            Console.Write("Ingrese la forma de pago (efectivo (1) o tarjeta (2)): ");
        }

        if (formaPago == 2)
        {
            Console.Write("Ingrese el número de cuenta (16 dígitos): ");
            string numeroCuenta = Console.ReadLine();

            while (numeroCuenta.Length != 16 || !long.TryParse(numeroCuenta, out _))
            {
                Console.WriteLine("El número de cuenta debe tener exactamente 16 dígitos numéricos.");
                Console.Write("Ingrese el número de cuenta nuevamente: ");
                numeroCuenta = Console.ReadLine();
            }

            Console.WriteLine($"Precio del producto: {prodprecio:C}");
            Console.WriteLine("Forma de pago: Tarjeta");
            Console.WriteLine($"Número de cuenta: {numeroCuenta}");
        }
        else if (formaPago == 1)
        {
            Console.WriteLine($"Precio del producto: {prodprecio:C}");
            Console.WriteLine("Forma de pago: Efectivo");
        }

        Console.ReadLine();
    }
}
