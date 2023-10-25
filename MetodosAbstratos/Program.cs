using MetodosAbstratos.Enums;
using MetodosAbstratos.Entities;

List<Shape> list = new List<Shape>();

Console.WriteLine("Enter the number of shapes");
int n = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= n; i++)
{
    Console.WriteLine($"Shapes #{i}");
    Console.WriteLine($"Rectangle or Circle (r/c)? ");
    char resp = char.Parse(console.ReadLine()!);
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<color>(Console.ReadLine()!);
    if (resp == 'r')
    {
        Console.Write("Width: ");
        double widht = double.Parse(Console.ReadLine());
        Console.Write("Hight: ");
        double hight = double.Parse(Console.ReadLine());

        list.Add(new Retangle(color, widht, hight));
    }
    else 
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());

        list.Add(new Circle(radius, color));
    }    
}

Console.WriteLine();
Console.WriteLine("SHAPE AREAS:");
foreach(Shape shape in list)
{
    Console.WriteLine(shape.Area().ToString("F2"));
}

Console.ReadKey();