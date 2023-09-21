using LinqKit;
using System.ComponentModel.Design;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Task6;
internal partial class Program
{
    private static void Main(string[] args)
    {
        var cars = Initialization();

        AddCar(cars, new Car()
        {
            Id = 5,

            Engine = new Engine()
            {
                HP = 400,
                Capacity = 6,
                Number = "PU23887B34411M",
                Type = "V6"
            },
            Chassis = new Chassis()
            {
                Number = "349323W2173323",
                PermissibleLoad = 2300,
                Wheels = 4
            },
            Transmission = new Transmission()
            {
                Gears = 5,
                Manufacturer = "Lotus",
                Type = "Awd"
            }
        });

        RemoveCar(cars,1);

        UpdateCar(cars, new Car()
        {
            Id = 5,

            Engine = new Engine()
            {
                HP = 300,
                Capacity = 8,
                Number = "AJ23117B22731X",
                Type = "V8"
            },
            Chassis = new Chassis()
            {
                Number = "127321M2186316",
                PermissibleLoad = 2700,
                Wheels = 4
            },
            Transmission = new Transmission()
            {
                Gears = 6,
                Manufacturer = "Audi",
                Type = "Rwd"
            }
        });

        GetAutoByParameter(cars, nameof(Car.Id), "1");

    }
    public static void AddCar(List<Car> cars, Car newCar)
    {
        var car = cars.FirstOrDefault(c => c.Engine.Number == newCar.Engine.Number);

        if (car == null)
        {
            cars.Add(newCar);
        }
        else
        {
            throw new AddAutoException();
        }
    }

    public static void RemoveCar(List<Car> cars, int id)
    {
        var car = cars.FirstOrDefault(c => c.Id == id);

        if (car != null)
        {
            cars.Remove(car);
        }
        else 
        {
            throw new RemoveAutoException();
        }
        
    }

    public static void UpdateCar(List<Car> cars, Car car)
    {
        var foundCar = cars.FirstOrDefault(c => c.Id == car.Id);

        if (foundCar == null)
        {
            throw new UpdateCarException();
        }
        else
        {
            foundCar.Engine = car.Engine;

            foundCar.Chassis = car.Chassis;

            foundCar.Transmission = car.Transmission;
        }
    }

    public static Car GetAutoByParameter(List<Car> cars, string parameter, string value) 
    {
       var properties = new Car().GetType().GetProperties();

       var property = properties.FirstOrDefault(p => p.Name == parameter);

       if (property == null)
        {
          throw new GetAutoByParameterException();    
        }
        else
        {
          return cars.FirstOrDefault(c => property.GetValue(c, null) == value);
        }
    }

    public static  List<Car> Initialization()
    {
        var cars = new List<Car>()
        {
            new Car()
            {
                Id = 1, 

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
            new Car()
            {
                Id = 2,

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
                    Wheels = 4
                },
                Transmission = new Transmission()
                {
                    Gears = 5,
                    Manufacturer = "BMW",
                    Type = "Rwd"
                }
            },
            new Car()
            {
                Id = 3,

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
            new Car()
            {
                Id = 4,   

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

        var wrongCars = cars.Where(c => c.Chassis.Wheels < 4)
        .ToList();

        if (wrongCars.Any())
        {
            throw new InitializationException();
        }

        return cars;
    }
};