using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImporter
{
    class CarImporter
    {
        List<Car> cars;
        public CarImporter()
        {
            this.cars = new List<Car>();
        }

        public override string ToString()
        {
            return GetStringOfCarsList(cars);
        }

        // GetStringOfCarsList is a static function that gets a list and returns a string of all cars
        public static string GetStringOfCarsList(List<Car> cars)
        {
            if (cars.Count == 0)
            {
                return "No cars in Stock";
            }
            string retStr = "";
            foreach (Car car in cars)
            {
                retStr += car.ToString() + "\n";
            }
            return retStr;
        }

        // AddCar is a function that adds a car to the importer's list
        public void AddCar(Car c)
        {
            cars.Add(c);
        }

        // RemoveCar is a function that removes a car from the importer's list. 
        // The function return true if car was removed successfully and false if not
        public bool RemoveCar(Car c)
        {
            return cars.Remove(c);

        }

        // PrintCarsWithRequiredEquipment is a function that prints all cars with the required equipment that are in stock
        public void PrintCarsWithRequiredEquipment(List<CAR_EQUIPMENT> requiredEquipment)
        {
            List<Car> sutibleCars = new List<Car>();
            foreach (Car c in this.cars)
            {
                if (c.HasAllEquipment(requiredEquipment))
                {
                    sutibleCars.Add(c);
                }
            }
            Console.WriteLine(GetStringOfCarsList(sutibleCars));
        }


        // PrintDirtyCars is a function that prints all the cars that need a wash.
        public void PrintDirtyCars()
        {
            List<Car> dirtyCars = new List<Car>();
            foreach (Car c in this.cars)
            {
                if (!c.IsClean())
                {
                    dirtyCars.Add(c);
                }
            }
            Console.WriteLine(GetStringOfCarsList(dirtyCars));
        }
            


    }
}
