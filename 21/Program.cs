double Distance(int a1, int a2, int b1, int b2, int c1, int c2) 
      { 
          double dist = Math.Sqrt((a1-a2)*(a1-a2)+(b1-b2)*(b1-b2)+(c1-c2)*(c1-c2)); 
          return dist; 
      } 
     
      Console.WriteLine("Введите координаты точки A: "); 
      Console.Write("X: "); 
      int x1 = Convert.ToInt32(Console.ReadLine()); 
      Console.Write("Y: "); 
      int y1 = Convert.ToInt32(Console.ReadLine()); 
      Console.Write("Z: "); 
      int z1 = Convert.ToInt32(Console.ReadLine()); 
 
      Console.WriteLine("Введите координаты точки B: "); 
      Console.Write("X: "); 
      int x2 = Convert.ToInt32(Console.ReadLine()); 
      Console.Write("Y: "); 
      int y2 = Convert.ToInt32(Console.ReadLine()); 
      Console.Write("Z: "); 
      int z2 = Convert.ToInt32(Console.ReadLine()); 
     
      double distance = Distance(x1,x2,y1,y2,z1,z2); 
 
      Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero)); 
  