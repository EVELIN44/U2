using System;

class Program
{
    static void Main(string[] args)
    {
        double distance, time;

        Console.WriteLine("Velocity Calculator");
        Console.WriteLine("");

        Console.Write("Enter distance (meters): ");
        distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (seconds): ");
        time = Convert.ToDouble(Console.ReadLine());

        double velocity = distance / time;
        Console.WriteLine($"The velocity is {velocity} m/s.");
    }
}



