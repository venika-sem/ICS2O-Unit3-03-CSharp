// Created by: Venika Sem
// Created on: Apr 2022
//
// This program finds the volume of a sphere

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the volume of a sphere
        double radiusOfSphere;
        double volume;

        // input
        Console.WriteLine("This program calculates the volume of a sphere.");
        Console.WriteLine("");
        Console.WriteLine("The formula is: V = (4 / 3)π x r³");
        Console.WriteLine("");
        Console.WriteLine("Please enter the measurement (cm).");

        Console.WriteLine("");
        Console.Write("Input the measurement for radius: ");
        radiusOfSphere = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        volume = (4.0 / 3.0) * Math.PI * Math.Pow(radiusOfSphere, 3);

        // output
        Console.WriteLine("The volume of the sphere is: " + volume.ToString("0.00") + " " + "cm³.");

        Console.WriteLine("\nDone.");
    }
}