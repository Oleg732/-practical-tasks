using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using taskoop;

internal class Program
{
    private static void Main(string[] args)
    {
        var vehicles = new List<Vehicle>()
        {
            new Car()
            {
                Engine = new Engine()
                {
                    HP = 400,
                    Capacity = 3,
                    Number = "PJ12345U123456P",
                    Type = "WEngine"
                },
                Chassis = new Chassis()
                {
                    Number = "231000В0102526",
                    PermissibleLoad = 3000,
                    Wheels = 4
                },
                Transmission = new Transmission()
                {
                    Gears = 6,
                    Manufacturer = "Toyota",
                    Type = "Fwd"
                }
            },
            new Bike()
            {
                Engine = new Engine()
                {
                    HP = 200,
                    Capacity = 100,
                    Number = "SJ32345U123626V",
                    Type = "Two-stroke engine"
                },
                Chassis = new Chassis()
                {
                    Number = "860234S0113214",
                    PermissibleLoad = 2000,
                    Wheels = 2
                },
                Transmission = new Transmission()
                {
                    Gears = 4,
                    Manufacturer = "Suzuki",
                    Type = "Fwd"
                }
            },
            new Truck()
            {
                Engine = new Engine()
                {
                    HP = 800,
                    Capacity = 12,
                    Number = "AC12146Y631323V",
                    Type = "V12"
                },
                Chassis = new Chassis()
                {
                    Number = "110244S0225285",
                    PermissibleLoad = 5000,
                    Wheels = 6
                },
                Transmission = new Transmission()
                {
                    Gears = 12,
                    Manufacturer = "Ford",
                    Type = "Awd"
                }
            },
            new Bus()
            {
                Engine = new Engine()
                {
                    HP = 286,
                    Capacity = 6,
                    Number = "BY33233U298765L",
                    Type = "V6"
                },
                Chassis = new Chassis()
                {
                    Number = "90034769227721",
                    PermissibleLoad = 4500,
                    Wheels = 4
                },
                Transmission = new Transmission()
                {
                    Gears = 8,
                    Manufacturer = "Mercedec",
                    Type = "Awd"
                }
            } };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.Name);

            Console.WriteLine($"Engine: {vehicle.Engine.HP} {vehicle.Engine.Capacity} {vehicle.Engine.Number} {vehicle.Engine.Type}");

            Console.WriteLine($"Chassis: {vehicle.Chassis.Number} {vehicle.Chassis.PermissibleLoad} {vehicle.Chassis.Wheels}");

            Console.WriteLine($"Transmission: {vehicle.Transmission.Gears} {vehicle.Transmission.Manufacturer} {vehicle.Transmission.Type}");

        }
    }
}


