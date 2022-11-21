namespace _21._11._2022_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter your car Brand : ");
            string brand=Console.ReadLine();
            Console.Write(" Enter your car Model : ");
            string model = Console.ReadLine();
            Console.Write(" Enter Current Fuel : ");
            double fuelnow =Convert.ToDouble( Console.ReadLine());
            Console.Write(" Enter fuel for 1 km : ");
            double fuelfor1 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Enter Millage : ");
            double millage = Convert.ToDouble(Console.ReadLine());
            Car car = new Car(brand, model, fuelnow, fuelfor1, millage);
            car.CarInfo();

            while (true)
            {
                
                Console.Write("\n Do you want to add Fuel ? Yes or No ?\n Answer : ");
                string addFuel = Console.ReadLine();
                if (addFuel == "Yes" | addFuel == "yes")
                {
                    Console.Write(" How much fuel dou you want to add ?\n Answer : ");
                    double fuel = Convert.ToDouble(Console.ReadLine());
                    car.AddFuel(fuel);
                    Console.WriteLine(" CurrentFuel : "+car.CurrentFuel+" litr");
                }

                Console.Write(" Enter km , you want to drive : ");
                int km = Convert.ToInt32(Console.ReadLine());
                if(km == 0)
                {
                    car.CarInfo();
                    break;
                }
                else
                {
                    car.Drive(km);
                }
                car.CarInfo();
            }
        }
    }
}