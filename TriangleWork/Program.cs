using System;
using Triangles;

namespace TriangleWork
{
  class Program
  {
    static double SetPoint(string msg)
    {
      Console.WriteLine(msg);
      return Convert.ToDouble(Console.ReadLine());
    }

    static void Main(string[] args)
    {
      double a, b, c;
      a = SetPoint("Введите точку а");
      b = SetPoint("Введите точку b");
      c = SetPoint("Введите точку c");

      TriangleUtils utils = new TriangleUtils();
      TriangleUtils.TriangleType type = utils.GetTriangleType(a, b, c);

      Console.WriteLine("Тип треугольника: " + type);
      Console.ReadKey();
    }
  }
}
