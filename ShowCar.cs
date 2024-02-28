namespace CarImporter
{
    internal class ShowCar : Car
    {
        private readonly DateTime _ArrivalDate;
        private int _odometer;

        public ShowCar(string manufacturer, string color, string modelName, DateTime manufacturingDate, string engineType, int horsePower, List<CAR_EQUIPMENT> carEquipmentLst, DateTime ArrivalDate, int odometer)
            : base(manufacturer,color, modelName, manufacturingDate, engineType, horsePower, carEquipmentLst)
        {
            this._ArrivalDate = ArrivalDate;
            this._odometer = odometer;
        }
        // GetInternalCarTypeString is a function that prints the internal string of the derived class (the type of car), in this case show car
        public override string GetInternalCarTypeString()
        {
            return "Show Car";
        }

        public DateTime GetArrivalDate()
        {
            return this._ArrivalDate;
        }

        public int GetOdometer()
        {
            return this._odometer;
        }

        public void SetOdometer(int odometer)
        {
            this._odometer = odometer;
        }
    }
}