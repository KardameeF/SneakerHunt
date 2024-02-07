using SneakerHunt;
using System;

class Program
{
    static void Main(string[] args)
    {
        ArgumentNullException.ThrowIfNull(args);

        var sneakerRepository = new SneakerRepository();
        var sneakerService = new SneakerService(sneakerRepository);

        // Демо: Добавяне на маратонки
        sneakerRepository.Add(new Sneaker { Id = 1, Name = "Air Max", Brand = "Nike", Price = 199.99M });
        sneakerRepository.Add(new Sneaker { Id = 2, Name = "Classic", Brand = "Reebok", Price = 149.99M });

        // Демо: Показване на всички маратонки
        Console.WriteLine("Available Sneakers:");
        foreach (var sneaker in sneakerService.GetAllSneakers())
        {
            Console.WriteLine($"ID: {sneaker.Id}, Name: {sneaker.Name}, Brand: {sneaker.Brand}, Price: {sneaker.Price}");
        }
    }
}
