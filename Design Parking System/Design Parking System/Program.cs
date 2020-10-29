using System;

namespace Design_Parking_System
{
    //https://leetcode.com/problems/design-parking-system/
    class Program
    {
        static void Main(string[] args)
        {
            ParkingSystem parkingSystem = new ParkingSystem(0,0,2);
            bool test = parkingSystem.AddCar(1);
            Console.WriteLine(test);
            test = parkingSystem.AddCar(2);
            Console.WriteLine(test);
            test = parkingSystem.AddCar(3);
            Console.WriteLine(test);
           

        }
    }

    public class ParkingSystem
    {
        int big,small,medium;
        public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    big--;
                    return  big >=0;
                    break;
                case 2:
                    medium--;
                    return  medium  >= 0;
                    break;
                case 3:
                    small--;
                    return small  >= 0;
                    break;
                default:
                    return false;
            }
        }
    }
}
