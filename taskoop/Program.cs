using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;
using taskoop;

internal class Program
{
    private static void Main(string[] args)
    {
        var vechicles = new List<Vehicle>()
        {
            new Car()
            {
                Engine = new Engine()
                {
                    HP = 400,
                    Capacity = 3,
                    EngineNumber = "PJ12345U123456P",
                    EngineType = "WEngine"
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "231000В0102526",
                    permissibleLoad = 3000,
                    wheels = 4
                },
                transmission = new Transmission()
                {
                    gears = 6,
                    manufacturer = "Toyota",
                    transmissionType = "Fwd"
                }
            },
            new Bike()
            {
                Engine = new Engine()
                {
                    HP = 200,
                    Capacity = 100,
                    EngineNumber = "SJ32345U123626V",
                    EngineType = "Two-stroke engine"
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "860234S0113214",
                    permissibleLoad = 2000,
                    wheels = 2
                },
                transmission = new Transmission()
                {
                    gears = 4,
                    manufacturer = "Suzuki",
                    transmissionType = "Fwd"
                }
            },
            new Truck()
            {
                Engine = new Engine()
                {
                    HP = 800,
                    Capacity = 12,
                    EngineNumber = "AC12146Y631323V",
                    EngineType = "V12"
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "110244S0225285",
                    permissibleLoad = 5000,
                    wheels = 6
                },
                transmission = new Transmission()
                {
                    gears = 12,
                    manufacturer = "Ford",
                    transmissionType = "Awd"
                }
            },
            new Bus()
            {
                Engine = new Engine()
                {
                    HP = 286,
                    Capacity = 6375,
                    EngineNumber = "BY33233U298765L",
                    EngineType = "V6"
                },
                Chassis = new Chassis()
                {
                    chassisnumber = "90034769227721",
                    permissibleLoad = 4500,
                    wheels = 4
                },
                transmission = new Transmission()
                {
                    gears = 8,
                    manufacturer = "Mercedec",
                    transmissionType = "Awd"
                }
            } };


        foreach (var vechicle in vechicles)
        {
            Console.WriteLine(vechicle.Name);

            Console.WriteLine($"Engine: {vechicle.Engine.HP} {vechicle.Engine.Capacity} {vechicle.Engine.EngineNumber} {vechicle.Engine.EngineType}");

            Console.WriteLine($"Chassis: {vechicle.Chassis.chassisnumber} {vechicle.Chassis.permissibleLoad} {vechicle.Chassis.wheels}");

            Console.WriteLine($"Transmission: {vechicle.transmission.gears} {vechicle.transmission.manufacturer} {vechicle.transmission.transmissionType}");

        }
    }
}


