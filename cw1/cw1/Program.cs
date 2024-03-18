// See https://aka.ms/new-console-template for more information

using System.Xml.Serialization;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hej");
        Console.WriteLine("Modyfikacja1");
        Console.WriteLine("Modyfikacja2");
        Console.WriteLine("Modyfikacja3");
        
        Console.WriteLine("Z brancha feature average");
    }


    public static int Avg(int[] tab)
    {
        int sum = 0;
        foreach (int num in tab)
        {
            sum += num;
            
        }

        return sum / tab.Length;
    }


    public static int Max(int[] tab)
    {
        return Max(tab);
    }
}