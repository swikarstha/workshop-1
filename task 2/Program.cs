class Circle
{
    const double PI = 3.14;

    public static void Main(string[] args)
    {
        PI = 3;
         Console.WriteLine(PI);
        

        Console.WriteLine(area(2));
        Console.WriteLine(perimeter(3));
    }

    static double area(double radius)
    {
        return PI * radius * radius;
    }

    static double perimeter(double radius)
    {
        return 2 * PI * radius;
    }


}