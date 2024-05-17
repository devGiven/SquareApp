using System;

class Square
{
    private double side;

    public Square(double sideLength)
    {
        if (sideLength <= 0)
        {
            throw new ArgumentException("Side length must be greater than zero.");
        }

        side = sideLength;
    }

    public double Side
    {
        get { return side; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Side length must be greater than zero.");
            }
            side = value;
        }
    }

    public double Perimeter
    {
        get { return 4 * side; }
    }

    public double Area
    {
        get { return side * side; }
    }

    public double Diagonal
    {
        get { return Math.Sqrt(2 * side * side); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the side length of the square: ");
        if (double.TryParse(Console.ReadLine(), out double sideLength))
        {
            try
            {
                Square square = new Square(sideLength);
                Console.WriteLine($"Perimeter of your square is: {square.Perimeter} CM");
                Console.WriteLine($"Area of your square is: {square.Area} CM");
                Console.WriteLine($"Diagonal of your square is: {square.Diagonal} CM");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for the side length.");
        }
    }
}
