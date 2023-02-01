namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
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
