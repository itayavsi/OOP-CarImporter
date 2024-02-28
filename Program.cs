using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarImporter
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating tesla equipment list
            List<CAR_EQUIPMENT> teslaEquipment = new List<CAR_EQUIPMENT>();
            teslaEquipment.Add(CAR_EQUIPMENT.E_SEAT_HEATER);
            teslaEquipment.Add(CAR_EQUIPMENT.E_PANORAMIC_ROOF);
            teslaEquipment.Add(CAR_EQUIPMENT.E_ELECTRIC_TAILGATE);
            teslaEquipment.Add(CAR_EQUIPMENT.E_ENTERTAINMENT_SYSTEM);
            teslaEquipment.Add(CAR_EQUIPMENT.E_FORWARD_ELECTRIC_SEATS);
            teslaEquipment.Add(CAR_EQUIPMENT.E_DIGITAL_DRIVER_DISPLAY);
            // creating skoda equipment list
            List<CAR_EQUIPMENT> skodaEquipment = new List<CAR_EQUIPMENT>();
            skodaEquipment.Add(CAR_EQUIPMENT.E_DIGITAL_DRIVER_DISPLAY);
            skodaEquipment.Add(CAR_EQUIPMENT.E_ENTERTAINMENT_SYSTEM);
            skodaEquipment.Add(CAR_EQUIPMENT.E_REAR_AC);
            // creating ford equipment list 
            List<CAR_EQUIPMENT> fordEquipment = new List<CAR_EQUIPMENT>();
            fordEquipment.Add(CAR_EQUIPMENT.E_ENTERTAINMENT_SYSTEM);
            fordEquipment.Add(CAR_EQUIPMENT.E_ELECTRIC_TAILGATE);
            fordEquipment.Add(CAR_EQUIPMENT.E_DIGITAL_DRIVER_DISPLAY);
            // creating the requested cars 
            SoldCar tesla = new SoldCar("Tesla", "Black", "Model 3",DateTime.Now.AddDays(-30), "Electric Engine",
             204, teslaEquipment, "Yuval", 200000, "Yossi");
            ShowCar skoda = new ShowCar("Skoda", "Red", "Octavia", DateTime.Now.AddMonths(-4), "Petrol Engine", 158, skodaEquipment, DateTime.Now, 5054);
            SoldCar ford = new SoldCar("Ford", "Blue", "Focus", DateTime.Now.AddDays(-76), "Hybrid Engine",
             143, fordEquipment, "David", 200000, "Yossi");
            ShowCar kia = new ShowCar("Kia", "Grey", "ev6", DateTime.Now.AddDays(-247), "Electric Engine", 234, new List<CAR_EQUIPMENT>(), DateTime.Now.AddDays(-5), 3250);
            // Car importer creation
            CarImporter carImporter = new CarImporter();
            carImporter.AddCar(skoda);
            carImporter.AddCar(ford);
            carImporter.AddCar(tesla);
            carImporter.AddCar(kia);
            kia.SetDirtyCar();
            carImporter.PrintDirtyCars();
            kia.UpdateWashDate();
            carImporter.PrintDirtyCars();


        }    
    }
}
