using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Model
{
    public class CarGalery
    {
        public CarGalery(string name, List<Car> cars)
        {
            Name = name;
            Cars = cars;
        }

        public string Name { get; set; }
        public List<Car> Cars { get; set; }
    }
}
