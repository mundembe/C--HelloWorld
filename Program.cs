namespace HelloWorld;

public class HelloWorld {
    public static void Main(string[] args){
        Console.WriteLine("Hello World");
        promptUserDetails();
    }

    public static void promptUserDetails(){
        Console.WriteLine("Please Enter Your Name:");
        var name = Console.ReadLine();
        var date = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello {name}, on {date:d} at {date:t}");
        Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey();
    }
}
