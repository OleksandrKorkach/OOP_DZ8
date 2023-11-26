namespace OOP_HW8;

public class ThirdTask
{
    
}

class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

class Square : Rectangle
{
    private int side;

    public override int Width
    {
        get { return side; }
        set
        {
            side = value;
            base.Width = value;
            base.Height = value;
        }
    }

    public override int Height
    {
        get { return side; }
        set
        {
            side = value;
            base.Width = value;
            base.Height = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;
        Console.WriteLine(rect.GetRectangleArea());

        Square square = new Square();
        square.Width = 5;
        square.Height = 5;
        Console.WriteLine(square.GetRectangleArea());

        Console.ReadKey();
    }
}