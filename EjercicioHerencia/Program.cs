// See https://aka.ms/new-console-template for more information

using EjercicioHerencia;

Desktop desktop1 = new Desktop("HP", "Pavilion", 16, 900, "Torre Grande", true, 5);
Laptop laptop1 = new Laptop("Dell", "Inspiron", 8, 700, 2.5, 15.6, 8);

// Mostrar información de las clases hijas en la consola
Console.WriteLine("Información de la Computadora de Escritorio:");
desktop1.Info();

Console.WriteLine("\nInformación de la Laptop:");
laptop1.Info();