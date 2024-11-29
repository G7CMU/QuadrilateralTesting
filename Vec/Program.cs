using Geometry;
using System;

Quadrilateral quadrilateral;
Point A, B, C, D;

while (true)
{
    Console.WriteLine("Nhap toa do 4 diem:");
    while (true)
    {
        try
        {
            Console.Write("A(x y): ");
            string[] inputA = Console.ReadLine().Split();
            A = new Point(double.Parse(inputA[0]), double.Parse(inputA[1]));
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

    quadrilateral = new Quadrilateral(A, B, C, D);

    if (quadrilateral.IsValid()) break;
    Console.WriteLine("4 diem da nhap khong the tao thanh tu giac loi");

}
Console.WriteLine($"S: {quadrilateral.Area()}");
