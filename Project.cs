using System;


public class Program

{
   public static void Main(string[] args)
   {
      Write1ThroughN_While(1);
      Write1ThroughN_For(0);
      WriteNThrough1_While(4);
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
   public static void Write1ThroughN_For(int n)
   {
      for (int i = 0; i < n; i++)
      {
         Console.WriteLine(i);
      }
   }
   public static void WriteNThrough1_While(int n)
   {
      int counter = 0;
        while (counter < n)
      {
         Console.WriteLine(n);
         n--;
      }
   }
}