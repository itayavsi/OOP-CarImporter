namespace CarImporter
{
    // class that represents a SoldCar
    internal class SoldCar : Car
    {
        private string _customerName;
        private int _price;
        private string _agent;
       
        public SoldCar(string  manufacturer, string color, string modelName, DateTime manufacturingDate, string engineType,
            int horsePower, List<CAR_EQUIPMENT> carEquipmentLst, string customerName, int price, string agent)
            : base(manufacturer, color, modelName, manufacturingDate, engineType, horsePower, carEquipmentLst)
        {
            this._customerName = customerName;
            this._price = price;
            this._agent = agent;
        }
        // GetInternalCarTypeString is a function that prints the internal string of the derived class (the type of car), in this case sold car
        public override string GetInternalCarTypeString()
        {
            return "Sold Car";
        }

        public int GetPrice()
        {
            return this._price;
        }

        public void SetPrice(int price)
        {
            this._price = price;
        }

        public string GetCustomerName()
        {
            return _customerName;
        }

        public void SetCustomerName(string customerName)
        {
            _customerName = customerName;
        }

        public string GetAgent()
        {
            return _agent;
        }

        public void SetAgent(string agent)
        {
            _agent = agent;
        }
    }
}