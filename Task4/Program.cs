using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using Task4;

internal class Program
{
    private static void Main(string[] args)
    {
        var items = new List<IFlyable>() { new Bird(), new Plane(), new Drone() };

        Console.WriteLine("Введите расстояние в км");
        
        var distance = int.Parse(Console.ReadLine());

        foreach (var item in items)
        {
            var time = item.GetFlyTime(new Coordinate() { X = distance });

            item.FlyTo(new Coordinate() { X = distance });

            Console.WriteLine($"Прилетел в {item.Position.X} За время {time}");
        }

    }
}


