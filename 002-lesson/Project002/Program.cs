namespace SecondProject {
  internal class Program {
    static void Main(string[] args) {

      bool complete = false;
      char gender = 'F';
      string name = "Lennon Ximenes";
      object obj1 = "Dinamite";
      object obj2 = 10.5f;
      byte x1 = 125;
      int x2 = 1000;
      int x3 = 2147483647;
      long x4 = 2147483648L;
      float x5 = 4.5f;
      double x6 = 4.5;
      int n1 = int.MinValue;
      int n2 = int.MaxValue;
      sbyte n3 = sbyte.MinValue;
      decimal n4 = decimal.MaxValue;

      x1++;

      Console.WriteLine(complete);
      Console.WriteLine(gender);
      Console.WriteLine(name);
      Console.WriteLine(obj1);
      Console.WriteLine(obj2);
      Console.WriteLine(x1);
      Console.WriteLine(x2);
      Console.WriteLine(x3);
      Console.WriteLine(x4);
      Console.WriteLine(x5);
      Console.WriteLine(x6);
      Console.WriteLine(n1);
      Console.WriteLine(n2);
      Console.WriteLine(n3);
      Console.WriteLine(n4);

    }
  }
}