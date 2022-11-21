

namespace _21._11._2022_3
{
    internal class Car
    {
        public Car(string brand, string model, double currentfuel, double fuelFor1, double millage)
        {
            this.Brand = brand;
            this.Model = model;
            this.CurrentFuel = currentfuel;
            this.FuelFor1Km = fuelFor1;
            this.Millage = millage;
        }

        public string Brand;
        public string Model;
        public double CurrentFuel;
        public double FuelFor1Km;
        public double Millage;


        public void Drive(int km)
        {
            if (km * this.FuelFor1Km <= this.CurrentFuel)
            {
                Console.WriteLine($"\n {this.Brand}-{this.Model} can driving for {km} km .");
                this.Millage += km;
                this.CurrentFuel -= km * this.FuelFor1Km;
                Console.WriteLine($"\n Millage : {this.Millage} \n CurrentFuel : {this.CurrentFuel}");
            }
            else
            {
                Console.WriteLine($"\n {this.Brand}-{this.Model} cann`t driving for {km} km .");
                Console.WriteLine($" You need {km*this.FuelFor1Km-this.CurrentFuel} litr fuel");
            }
        }
        public void CarInfo()
        {
            Console.WriteLine($"\n Your car information : \n Car_Name : {this.Brand}-{this.Model}\n CurrentFuel : {this.CurrentFuel} litr ");
            Console.WriteLine($" Fuel for 1 km : {this.FuelFor1Km}\n Millage : {this.Millage}");
        }

        public void AddFuel(double fuel)
        {
            
            this.CurrentFuel += fuel;
        }
    }
}
