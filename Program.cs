

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ConsoleApp9.Model;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSerializeMethod();
        }

        static void JsonSerializeMethod()
        {
            
            List<Car> cars = new List<Car>
            {
                new Car { Model = "Priora", Marka = "Lada", Year = 2013 },
                new Car { Model = "2107", Marka = "Lada", Year = 2011 },
                new Car { Model = "2106", Marka = "Lada", Year = 1999 }
            };

            
            CarGalery galery = new CarGalery("Avtos", cars);

            
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true 
            };

            
            string jsonString = JsonSerializer.Serialize(galery, options);

            
            Console.WriteLine(jsonString);

            
            File.WriteAllText("cars.json", jsonString);
        }
    }
}
