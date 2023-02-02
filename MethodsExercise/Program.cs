using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string? name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string? color = Console.ReadLine();
            Console.WriteLine("what is your favorite animal");
            string? animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string? band = Console.ReadLine();
            Console.WriteLine("Here is your profile");
            Console.WriteLine("********************");

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

        }

    }
}
                     //Excercise 2

internal class Exercise
{
    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Subtract(int num1, int num2)
    {
        return num1 - num2;
    }
    public static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    public static int Divide(int num1, int num2)
    {
        return num1 / num2;
    }

  static void Main(string[] args)
    {
        int myReturn = Exercise.Add(10, 5);
        Console.WriteLine(myReturn);
        int myReturns = Exercise.Subtract(15, 5);
        Console.WriteLine(myReturns);
        int myReturnm = Exercise.Multiply(10, 5);
        Console.WriteLine(myReturnm);
        int myReturnd = Exercise.Divide(5, 5);
        Console.WriteLine(myReturnd);

    }
    
       


    









}




