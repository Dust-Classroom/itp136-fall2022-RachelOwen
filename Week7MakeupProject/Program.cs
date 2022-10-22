using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;
using static ParkingLot.ParkingLot;
using static System.Console;
namespace ParkingLot
{
    class MainClass
    {
        static void Main(String[] args)
        {
            //so admittedly i overcomplicated the crap out of this because i wanted to automatically track the time when the car "punched in"
            //couldn't manage to figure out a better method for that, but it does what it's supposed to, relatively speaking, the problem is mostly that
            //it's built for execution from the command line more than anything
            //this is mostly just a proof of concept as a result but I think it's functional
            ParkingLot Lot1 = new ParkingLot();
            Parking Car1 = new Parking(0, "Ford", "Mustang", "B33-G335");
            Parking Car2 = new Parking(1, "Toyota", "Tacoma", "YOU-R5U5");
            Parking Car3 = new Parking(2, "Harley", "Fat Boy", "FGW-6889");
            Parking Car4 = new Parking(0, "Toyota", "Corolla", "RVT-9135");
            Lot1.Park(Car1);
            Lot1.Park(Car1);
            Lot1.Park(Car2);
            Lot1.Park(Car2);
            Lot1.Park(Car3);
            Lot1.Park(Car4);
            Lot1.Display(Lot1);
        }
    }
    class ParkingLot
    {
        const decimal CAR_RATE = 2.00M, TRUCK_RATE = 3.50M, BIKE_RATE = 1.50M;
        
        public List<Parking> vehicles = new List<Parking>();
        public List<Parking> isParked = new List<Parking>();
        public List<Parking> departures = new List<Parking>();
        public decimal parkedTotal = 0;
        public decimal departedTotal = 0;
        public void Park(Parking vehicle)
        {
            DateTime parkingTime = DateTime.Now;
            if (!vehicle.parked)
            {
                vehicles.Add(vehicle);
                isParked.Add(vehicle);
                vehicle.parked = true;
                vehicle.arrivalHour = parkingTime.Hour;
                vehicle.arrivalMinute = parkingTime.Minute;
                vehicle.parkingTime = parkingTime;
            }
            else
            {
                vehicle.parked = false;
                vehicle.departureHour = vehicle.arrivalHour + vehicle.hoursParked;
                if (vehicle.departureHour > 23)
                {
                    vehicle.departureHour = 23;
                }
                departures.Add(vehicle);
                isParked.Remove(vehicle);
            }
        }
        public decimal ParkingFee(Parking vehicle)
        {
            //0 for Cars, 1 for Trucks, 2 for Bikes
            //constants of the rates defined above, in decimal since it's cash
            decimal rate;
            decimal totalFee;
            switch (vehicle.vehicleType)
            {
                case 0:
                    rate = CAR_RATE;
                    break;
                case 1:
                    rate = TRUCK_RATE;
                    break;
                case 2:
                    rate = BIKE_RATE;
                    break;
                default:
                    rate = 0;
                    break;
            }
            if (rate == 0)
            {
                WriteLine("Invalid Vehicle Type");
                return 0;
            }
            else if (vehicle.parked)
            {
                totalFee = vehicle.hoursParked * rate;
            }
            else
            {
                totalFee = (vehicle.departureHour - vehicle.arrivalHour) * rate;
            }
            return totalFee;
        }
        public void FeeTotal(ParkingLot lot)
        {
            foreach (Parking vehicle in lot.isParked)
            {
                parkedTotal += ParkingFee(vehicle);
            }
            foreach (Parking vehicle in lot.departures)
            {
                departedTotal += ParkingFee(vehicle);
            }
        }
        public void Display(ParkingLot lot)
        {
            FeeTotal(lot);
            WriteLine("Lot Statistics");
            WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            foreach (Parking vehicle in lot.vehicles)
            {
                WriteLine("{0,-14} | Plate No. {1,5} | Parked At: {2,10} | Cumulative Hours Parked: {3} | Fee: {4,4:C2} | Parked?: {5}",vehicle.vehicleMake + " " + vehicle.vehicleModel,vehicle.licensePlate,vehicle.parkingTime,vehicle.hoursParked,ParkingFee(vehicle),vehicle.parked);
            }
            WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            WriteLine("Total for Parked Vehicles: {0:C2} | Total for Departed Vehicles: {1:C2}", lot.parkedTotal, lot.departedTotal);
        }
        public class Parking
        {
            public string vehicleMake, vehicleModel, licensePlate;
            public int vehicleType;
            public int arrivalHour = DateTime.Now.Hour;
            public int arrivalMinute = DateTime.Now.Minute;
            public bool parked = false;
            public int hoursParked;
            public int departureHour;
            public DateTime parkingTime;
            public Parking(int vehicleType, string vehicleMake, string vehicleModel, string licensePlate)
            {
                this.vehicleType = vehicleType;
                this.vehicleMake = vehicleMake;
                this.vehicleModel = vehicleModel;
                this.licensePlate = licensePlate;
                hoursParked = DateTime.Now.Hour - arrivalHour;
                if (DateTime.Now.Minute > 0)
                {
                    hoursParked++;
                }
            }
        }
    }
}

      