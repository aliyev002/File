using ConsoleApp9.Model;

using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
void JsonSerializeMethod()
{
    new Car { Model = "Priora", Marka = "Lada", Year = 2013 };
    new Car { Model = "2107", Marka = "Lada", Year = 2011 };
    new Car { Model = "2106", Marka = "Lada", Year = 1999 };

    List<Car> cars = new List<Car>();
    foreach (Car car in cars)
    {
        cars.Add(car);
    }
    CarGalery galery = new CarGalery("Avtos", cars);




    
    JsonSerializerOptions options = new JsonSerializerOptions
    {
        WriteIndented = true 
    };

    
    string jsonString = JsonSerializer.Serialize(galery, options);

    
    Console.WriteLine(jsonString);

    
    File.WriteAllText("cars.json", jsonString);
}
