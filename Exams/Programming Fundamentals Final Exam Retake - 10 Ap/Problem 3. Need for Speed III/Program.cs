using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            for (int k = 0; k < n; k++)
            {
                string[] model = Console.ReadLine()
                    .Split("|")
                    .ToArray();

                string carName = model[0];
                int mileage = int.Parse(model[1]);
                int startedFuel = int.Parse(model[2]);

                cars.Add(carName, new List<int>());
                for (int c = 0; c < 1; c++)
                {
                    cars[carName].Add(mileage);
                    cars[carName].Add(startedFuel);
                }
            }

            string input = "";

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] command = input
                    .Split(" : ")
                    .ToArray();

                string car = "";
                int fuel = 0;
                int distance = 0;

                if (input.StartsWith("Drive"))
                {
                    car = command[1];
                    distance = int.Parse(command[2]);
                    fuel = int.Parse(command[3]);

                    int curFuel = cars[car][1] - fuel;
                    int carMileage = cars[car][0] + distance;

                    if (curFuel < 0)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else if (curFuel > 0)
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                    }
                    if (carMileage > 100000)
                    {
                        Console.WriteLine($"Time to sell the {car}!");
                        cars.Remove(car);
                    }
                }
                else if (input.StartsWith("Refuel"))
                {
                    car = command[1];
                    fuel = int.Parse(command[2]);

                    int curFuel = cars[car][1];
                    int maxFuel = 75;

                    if (curFuel + fuel > maxFuel)
                    {
                        int refueled = maxFuel - curFuel;
                        Console.WriteLine($"{car} refueled with {refueled} liters");
                        cars[car][1] += refueled;
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                        cars[car][1] += fuel;
                    }
                }
                else if (input.StartsWith("Revert"))
                {
                    car = command[1];
                    distance = int.Parse(command[2]);

                    int curDistance = cars[car][0];

                    curDistance -= distance;

                    if (curDistance > 10000)
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                        cars[car][0] -= distance;
                    }
                    else
                    {
                        cars[car][0] = 10000;
                    }
                }
            }

            foreach (var car in cars.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {string.Join("",car.Value[0])} kms, Fuel in the tank: {string.Join("",car.Value[1])} lt.");
            }
        }
    }
}
