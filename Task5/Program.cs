using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Linq;
using Task5;
using Microsoft.VisualBasic;
using System.Net.Http.Headers;
using System.Reflection;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var vehicles = new List<Vehicle>()
        {
            new Car()
            {
                Engine = new Engine()
                {
                    HP = 250,
                    Capacity = 6,
                    Number = "AJ65217U12344P",
                    Type = "V6"
                },
                Chassis = new Chassis()
                {
                    Number = "908125C0162316",
                    PermissibleLoad = 2500,
                    Wheels = 4
                },
                Transmission = new Transmission()
                {
                    Gears = 5,
                    Manufacturer = "Honda",
                    Type = "Awd"
                }
            },
            new Bike()
            {
                Engine = new Engine()
                {
                    HP = 250,
                    Capacity = 200,
                    Number = "CW83205H163622M",
                    Type = "four-stroke V-twin"
                },
                Chassis = new Chassis()
                {
                    Number = "219252S1720213",
                    PermissibleLoad = 1500,
                    Wheels = 2
                },
                Transmission = new Transmission()
                {
                    Gears = 5,
                    Manufacturer = "BMW",
                    Type = "Rwd"
                }
            },
            new Truck()
            {
                Engine = new Engine()
                {
                    HP = 900,
                    Capacity = 12,
                    Number = "PC81252P735323V",
                    Type = "V12"
                },
                Chassis = new Chassis()
                {
                    Number = "842355S0905236",
                    PermissibleLoad = 5500,
                    Wheels = 6
                },
                Transmission = new Transmission()
                {
                    Gears = 12,
                    Manufacturer = "Mack",
                    Type = "Awd"
                }
            },
            new Bus()
            {
                Engine = new Engine()
                {
                    HP = 400,
                    Capacity = 8,
                    Number = "RD32211U298765L",
                    Type = "V8"
                },
                Chassis = new Chassis()
                {
                    Number = "38534329186690",
                    PermissibleLoad = 5000,
                    Wheels = 4
                },
                Transmission = new Transmission()
                {
                    Gears = 9,
                    Manufacturer = "Volvo",
                    Type = "Awd"
                }

            }
        };

        var model = new Info
        {
            Vehicles = new List<Vehicle>(),
            Engines = new List<EngineInfo>(),
            GroupedVehicleInfosByTransmission = new List<GroupedVehicleInfoByTransmission>()
        };

        model.Vehicles = vehicles
        .Where(v => v.Engine.Capacity > 1.5)
        .ToList();

        model.Engines = vehicles
        .Where(v => v is Bus || v is Truck)
        .Select(v => new EngineInfo { Engine = v.Engine })
        .ToList();

        model.GroupedVehicleInfosByTransmission = vehicles
        .GroupBy(v => v.Transmission.Type)
        .Select(v => new GroupedVehicleInfoByTransmission {TransmissionName = v.Key, Vehicles = v.ToList() }).ToList();

        var mySerializer = new XmlSerializer(typeof(Info));

        var myWriter = new StreamWriter("E:/Test/myFileName.xml");

        mySerializer.Serialize(myWriter, model);
        myWriter.Close();

    }
}