using System;


public class Program

{
   public static void Main(string[] args)
   {
      Write1ThroughN_While(0);
      Write1ThroughN_For(0);
      WriteNThrough1_While(0);
      WriteNThrough1_For(0);
      WriteEvensThrough100();
      FindSum(100);
      FindSumOfEvenNumbers(-25);
      FindSumOfOddNumbers(-25);
      OutputRightTriangle(0);
   }
   public static void OutOfRangeMessage(int n)
   {
      Console.WriteLine($"{n} is out of range");
   }
   public static void Write1ThroughN_While(int n)
   {
      int counter = 1;
      if (n < 1)
      {
         OutOfRangeMessage(n);
      }
      while (counter <= n)
      {
         Console.WriteLine(counter);
         counter++;
      }
   }
   public static void Write1ThroughN_For(int n)
   {
      if (n < 1)
      {
         OutOfRangeMessage(n);
      }
      else 
      {
      for (int i = 0; i < n; i++)
      {
         Console.WriteLine(i);
      }
      }
   }
   public static void WriteNThrough1_While(int n)
   {
      int counter = 0;
      if (n < 1)
      {
         OutOfRangeMessage(n);
      }
      else
      {
      while (counter < n)
      {
         Console.WriteLine(n);
         n--;
      }
      }
   }
   public static void WriteNThrough1_For(int n)
   {
      if (n < 1)
      {
         OutOfRangeMessage(n);
      }
      else
      {
      for (int i = 0; i < n; n--)
      {
         Console.WriteLine(n);
      }
      }
   }
   public static void WriteEvensThrough100()
   {
      for (int i = 1; i < 101; i++)
      {
         int evenNumber = i % 2;
         if (evenNumber == 0)
         {
            Console.WriteLine(i);
         }
      }
   }
   public static void FindSum(int n)
   {
      int sum = 0;
      if (n < 0)
      {
         for (int i = 0; i > n; n++)
         {
            sum = n + sum;
         }
         Console.WriteLine(sum);
      }
      else
      {
         for (int i = 0; i < n; n--)
         {
            sum = n + sum;
         }
         Console.WriteLine(sum);
      }
   }
   public static void FindSumOfEvenNumbers(int n)
   {
      int sum = 0;
      if (n < 0)
      {

         for (int i = 0; i > n; n++)
         {
            int evenNumber = n % 2;
            if (evenNumber == 0)
            {
               sum = n + sum;
            }
         }
         Console.WriteLine(sum);
      }
      else
      {
         for (int i = 0; i < n; n--)
         {
            int evenNumber = n % 2;
            if (evenNumber == 0)
            {
               sum = n + sum;
            }
         }
         Console.WriteLine(sum);
      }
   }
   public static void FindSumOfOddNumbers(int n)
   {
      int sum = 0;
      if (n < 0)
      {

         for (int i = 0; i > n; n++)
         {
            int evenNumber = n % 2;
            if (evenNumber != 0)
            {
               sum = n + sum;
            }
         }
         Console.WriteLine(sum);
      }
      else
      {
         for (int i = 0; i < n; n--)
         {
            int evenNumber = n % 2;
            if (evenNumber != 0)
            {
               sum = n + sum;
            }
         }
         Console.WriteLine(sum);
      }
   }
   public static void OutputRightTriangle(int n)
   {
      if (n < 0)
      {
         for (int i = 0; i < -n; i++)
         {
            // Console.Write("*");
            for (int j = -n; j > i; j--)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }
      }
      else
      {
         for (int i = 0; i < n; i++)
         {
            Console.Write("*");
            for (int j = 0; j < i; j++)
            {
               Console.Write("*");
            }
            Console.WriteLine();
         }
      }
   }
}