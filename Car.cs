namespace CarImporter
{
    enum CAR_EQUIPMENT
    {
        E_SEAT_HEATER,
        E_PANORAMIC_ROOF,
        E_ELECTRIC_TAILGATE,
        E_ENTERTAINMENT_SYSTEM,
        E_FORWARD_ELECTRIC_SEATS,
        E_DIGITAL_DRIVER_DISPLAY,
        E_REAR_AC,
    }

    // We are going to define an abstract class that will represent a generic Car.
    // Than sub class like ShowCar and SoldCar will inhert from this class
    internal abstract class Car
    {
        protected readonly string manufacturer;
        protected string color;
        protected readonly string modelName;
        protected readonly DateTime manufacturingDate;
        protected string engineType;
        protected int horsePower;
        protected List<CAR_EQUIPMENT> carEquipmentLst;
        protected DateTime washDate;

        protected Car(string manufacturer, string color, string modelName, DateTime manufacturingDate, string engineType, int horsePower, List<CAR_EQUIPMENT> carEquipmentLst)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.modelName = modelName;
            this.manufacturingDate = manufacturingDate;
            this.engineType = engineType;
            this.horsePower = horsePower;
            this.carEquipmentLst = carEquipmentLst;
            UpdateWashDate();
        }


        public override string ToString()
        {
            return this.manufacturer + ", " + this.modelName + ", " + this.GetInternalCarTypeString() + ", " + this.engineType + ", " + this.horsePower + " hp" + ", " + this.washDate.ToString("d");
        }

        // GetInternalCarTypeString is a function that prints the internal string of the derived class (the type of car)
        public abstract string GetInternalCarTypeString();
        public string GetManufacturer()
        {
            return this.manufacturer;
        }

        // HasAllEquipment is a function that checks if a car has all the equipment in the requiredEquipment list
        public bool HasAllEquipment(List<CAR_EQUIPMENT> requiredEquipment)
        {
            foreach(CAR_EQUIPMENT equipmentType in requiredEquipment)
            {
                if (!this.carEquipmentLst.Contains(equipmentType))
                {
                    return false;
                }
            }
            return true;
        }

        // the function sets the next wash date to 30 days later.
        public void UpdateWashDate()
        {
            this.washDate = DateTime.Now.AddDays(30);
        }

        // SetDirtyCar is a function that changes the washdate to min.
        // This means the car is dirty and needs a wash...
        public void SetDirtyCar()
        {
            this.washDate = DateTime.MinValue;
        }

        // IsClean is a function that checks if a car is clean.
        public bool IsClean()
        {
            return this.washDate > DateTime.Now;
        }

        public string GetColor()
        {
            return this.color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetModelName()
        {
            return this.modelName;
        }

        public DateTime GetManufacturingDate()
        {
            return this.manufacturingDate;
        }

        public string GetEngineType()
        {
            return this.engineType;
        }

        public void SetEngineType(string engineType)
        {
            this.engineType = engineType;
        }

        public int GetHorsePower()
        {
            return this.horsePower;
        }

        public void SetHorsePower(int horsePower)
        {
            this.horsePower = horsePower;
        }

        public List<CAR_EQUIPMENT> GetCarEquipmentLst()
        {
            return this.carEquipmentLst;
        }
    }
}