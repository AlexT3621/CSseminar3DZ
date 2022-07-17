/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.*/
Console.WriteLine("Введите координату x первой точки");
double a_x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
double a_y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
double a_z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки");
double b_x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
double b_y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
double b_z = Convert.ToDouble(Console.ReadLine());
double distance(double a_x, double a_y, double a_z, double b_x,double b_y, double b_z)
    {
        double res = (b_x - a_x)*(b_x - a_x) + (b_y - a_y)*(b_y - a_y)+ (b_z - a_z)*(b_z - a_z);
        return Math.Sqrt(res);
    } 
    Console.WriteLine("Расстояие меду точками a и b равно  " + distance(a_x, a_y, a_z, b_x, b_y,  b_z));