namespace Area_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalArea = RectArea(1500, 2500) + CircleArea(375 / 2) + TriangleArea(750, 500);
            Console.WriteLine($"The total floor area is {Math.Round(totalArea, 2)} m2 in Teotihuacan");

            double costVar = Math.Round(totalArea * 180, 2);
            Console.WriteLine($"The total cost for the wood is {costVar} Mexican pesos to build the Teotihuacan floor!");

            double TMarea = RectArea(90.5, 90.5) - 2 * RectArea(24, 24);
            Console.WriteLine($"The total floor area is {TMarea} m2 in Taj Mahal");
            double costTM = Math.Round(TMarea * 180, 2);
            Console.WriteLine($"The total cost is {costTM} Mexican pesos for all the wood to build the Taj Mahal floor!");
        }
        static double RectArea(double length, double width)
        {
            return length * width;
        }

        static double CircleArea(double radius)
        {
            return Math.PI * (Math.Pow(radius, 2));
        }

        static double TriangleArea(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

    }
}