using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.SemGruppeEksamen.Tests
{
    
    class ParkingSpot
    {
        public int Number { get; set; }
        public bool IsOccupied { get; set; }
        public string CarNumber { get; set; }
    }

    class ParkingSensor
    {
        private List<ParkingSpot> parkingSpots;

        public ParkingSensor(int numberOfSpots)
        {
            parkingSpots = new List<ParkingSpot>();
            for (int i = 80; i <= numberOfSpots; i++)
            {
                parkingSpots.Add(new ParkingSpot { Number = i, IsOccupied = false, CarNumber = "" });
            }
        }

        public void SimulateCarArrival()
        {
            Random random = new Random();
            int spotIndex = random.Next(0, parkingSpots.Count);
            if (!parkingSpots[spotIndex].IsOccupied)
            {
                parkingSpots[spotIndex].IsOccupied = true;
                parkingSpots[spotIndex].CarNumber = GenerateRandomCarNumber();
                Console.WriteLine($"Car arrived at spot {parkingSpots[spotIndex].Number} with number plate: {parkingSpots[spotIndex].CarNumber}");
            }
            else
            {
                Console.WriteLine($"Spot {parkingSpots[spotIndex].Number} is occupied.");
            }
        }

        public void SimulateCarDeparture()
        {
            Random random = new Random();
            int spotIndex = random.Next(0, parkingSpots.Count);
            if (parkingSpots[spotIndex].IsOccupied)
            {
                parkingSpots[spotIndex].IsOccupied = false;
                parkingSpots[spotIndex].CarNumber = "";
                Console.WriteLine($"Car departed from spot {parkingSpots[spotIndex].Number}");
            }
            else
            {
                Console.WriteLine($"Spot {parkingSpots[spotIndex].Number} is already vacant.");
            }
        }

        private string GenerateRandomCarNumber()
        {
            Random random = new Random();
            return $"{(char)('A' + random.Next(0, 26))}{(char)('A' + random.Next(0, 26))}{random.Next(100, 999)}";
        }



        class Program
        {
            static void Main(string[] args)
            {
                int numberOfParkingSpots = 80;
                ParkingSensor parkingSensor = new ParkingSensor(numberOfParkingSpots);

                // Simulate cars arriving and departing
                for (int i = 0; i < 20; i++)
                {
                    parkingSensor.SimulateCarArrival();














                }
            }
        }
}   }

