namespace App;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

#if KMS_MODE
        using (var window = new KMSWindow())
        window.Run();
#else
        using (var window = new Window(800, 480))
            window.Run();
#endif
    }
}
