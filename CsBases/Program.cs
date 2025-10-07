// See https://aka.ms/new-console-template for more information

using CsBases.Fundamentals;

class Program
{
    static void Main()
    {
        //declaracion explicita
        int quantity = 5;
        string message = "program";
        decimal price = 19.99m;
        Console.WriteLine($"Cantidad: {quantity}, Saludo: {message}, precio: {price:C}");
        var gretting = "hola";
        decimal porcentage = 20.3m;

        var laptop = new Product("Laptop", 1200);
        Console.WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct("Soporte tecnico", 300, 30);
        Console.WriteLine(soporte.GetDescription());


    }
}