using System;

namespace Geometry;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap toa do 4 diem:");
        Point A, B, C, D;

        
        while(true) {
            try
            {
                Console.Write("A(x y): ");
                string[] inputA = Console.ReadLine().Split();
                A = new Point(double.Parse(inputA[0]), double.Parse(inputA[1]));
                break;
            }
            catch {
                Console.WriteLine("Nhap sai, nhap lai!\n");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("B (x y): ");
                string[] inputB = Console.ReadLine().Split();
                B = new Point(double.Parse(inputB[0]), double.Parse(inputB[1]));
                break;
            }
            catch
            {
                Console.WriteLine("Nhap sai, nhap lai!\n");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("C (x y): ");
                string[] inputC = Console.ReadLine().Split();
                C = new Point(double.Parse(inputC[0]), double.Parse(inputC[1]));
                break;
            }
            catch
            {
                Console.WriteLine("Nhap sai, nhap lai!\n");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("D (x y): ");
                string[] inputD = Console.ReadLine().Split();
                D = new Point(double.Parse(inputD[0]), double.Parse(inputD[1]));
                break;
            }
            catch
            {
                Console.WriteLine("Nhap sai, nhap lai!\n");
            }
        }

        Quadrilateral quadrilateral = new Quadrilateral(A, B, C, D);
        Console.WriteLine($"S: {quadrilateral.Area()}");
    }
}
