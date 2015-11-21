namespace _02LaptopShop
{
    public class Battery
    {
        private string batteryName;
        private double batteryLife;

        public Battery() : this(null, 0)
        {
        }

        public Battery(string batteryName, double batteryLife)
        {
            this.batteryName = BatteryName;
            this.batteryLife = BatteryLife;
        }

        public string BatteryName
        {
            get
            {
                return this.batteryName;
            }
            set
            {
                if (value != "")
                {
                    batteryName = value;
                }
                else
                {
                    throw new System.ArgumentException("Battery name cannot be an empty string!");
                }
            }
        }

        public double BatteryLife
        {
            get
            {
                return this.batteryLife;
            }
            set
            {
                if (value >= 0)
                {
                    batteryLife = value;
                }
                else
                {
                    throw new System.ArgumentException("Battery life cannot be a negative number!");
                }
            }
        }
    }
}
