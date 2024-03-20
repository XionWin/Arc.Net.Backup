namespace App;

enum StartupType
{
    Desktop,
    KMS
}



class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Hello, World!");

        var type = Enum.Parse<StartupType>(args.First());
        Console.WriteLine($"Mode: {type}");
        if(type is StartupType.Desktop)
        {
            using (var window = new Window(800, 480))
                window.Run();
        }
        else if(type is StartupType.KMS)
        {
            KMSSurface.Run();
        }
    }
}
