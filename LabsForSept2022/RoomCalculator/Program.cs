// See https://aka.ms/new-console-template for more information
Console.WriteLine("Give me the length of the room");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("Give me the width of the room");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("Give me the height of the room");
double height = double.Parse(Console.ReadLine());

Console.WriteLine($"The perimeter of the room is {(length * 2) + (width * 2)}");
Console.WriteLine($"The area of the room is {length * width}");
Console.WriteLine($"The volume of the room is {length * width * height}");
Console.WriteLine($"The perimeter of the room is {2*(length*width+length*height+width*height)}");
Console.ReadKey();
