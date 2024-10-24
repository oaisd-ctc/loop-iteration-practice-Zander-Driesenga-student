using System;


public class Program

{
   public static void Main(string[] args)
   {
      Write1ThroughN_While(4);
   }
   public static void Write1ThroughN_While(int n)
   {
      int counter = 1;
        while (counter < n)
      {
         Console.WriteLine(counter);
         counter++;
      }
   }
}
