using System;
 
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new MyClass();
            Console.WriteLine("Enter x to EXIT...");
            while(true)
            {
                var cmd = Console.ReadLine();
                if (cmd.ToLower() == "x")
                    return;
                Console.WriteLine($"{c1.ReturnMessage()}> {cmd}");
            }
        }
    }
}

