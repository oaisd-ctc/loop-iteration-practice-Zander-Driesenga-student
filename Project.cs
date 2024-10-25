using System;


public class Program

{
   public static void Main(string[] args)
   {
      Write1ThroughN_While(1);
      Write1ThroughN_For(0);
      WriteNThrough1_While(0);
      WriteNThrough1_For(0);
      WriteEvensThrough100();
      FindSum(1);
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
   public static void WriteNThrough1_For(int n)
   {
      for (int i = 0; i < n; n--)
      {
         Console.WriteLine(n);
      }
   }
   public static void WriteEvensThrough100()
   {
      for (int i = 1; i < 101; i++)
      {
         int evenNumber = i % 2;
         if (evenNumber == 0)
         {
            Console.WriteLine();
         }
      }
   }
   public static void FindSum(int n)
   {
      int sum = 0;
      for (int i = 0; i < n; n--)
      {
         sum = n + sum;
      }
      Console.WriteLine(sum);
   }
}