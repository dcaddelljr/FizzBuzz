namespace FizzBuzz;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input number");
        int num = int.Parse(Console.ReadLine());
        FizzBuzz(num);

        Console.WriteLine(FizzBuzz(num));

        /*for (var i = 0; i <= 100; i++)
        {
            Console.WriteLine($"{i}: {FizzBuzz}");
        }
        */
    }
    /*public static string FizzBuzz(int num)
    {
        if (num == null || num == 0)
        {
            return "Invalid input";
        }
        if (num % 3 == 0)
        {
            return "fizz";
        }
        if (num % 5 == 0)
        {
            return "buzz";
        }
        if (num % 3 == 0 && num % 5 == 0)
        {
            return "fizzbuzz";
        }
        else
        {
            return "No fizzbuss for you :(";
        }
    }*/
    public static string FizzBuzz(int num)
    {
        var answer = "";

        if (num % 3 == 0)
        {
            answer = "fizz";
        }
        if (num % 5 == 0)
        {
            answer += "buzz";
        }
        return answer;
    }

}