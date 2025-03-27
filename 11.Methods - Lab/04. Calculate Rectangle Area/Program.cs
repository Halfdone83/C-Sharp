int width = int.Parse(Console.ReadLine());
int length  = int.Parse(Console.ReadLine());



Console.WriteLine(ReactangleArea(width, length));


static int ReactangleArea(int width, int height)
{

    int area = width * height;
    return area;

}