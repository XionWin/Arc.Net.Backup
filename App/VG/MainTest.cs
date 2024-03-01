namespace App.VG;

public static class MainTest
{
    static Context context = new Context();
    public static Vertex[] Test()
    {
        context.GetState().StrokeWidth = 50;
        context.GetState().LineCap = LineCap.Round;
        // context.BeginPath();
        // context.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        // context.AddCommand(new Command(CommandType.LineTo, 120, 100));
        // context.AddCommand(new Command(CommandType.LineTo, 120, 120));

        
        // context.BeginPath();
        // context.AddCommand(new Command(CommandType.MoveTo, 200, 200));
        // context.AddCommand(new Command(CommandType.LineTo, 220, 200));
        // context.AddCommand(new Command(CommandType.LineTo, 220, 220));

        
        var t = ((float)DateTime.Now.Second + (float)DateTime.Now.Millisecond / 1000f) / 60f * (Math.PI * 2);

        // context.BeginPath();
        // // context.AddCommand(new Command(CommandType.MoveTo, 430.9017f, 335.10565f));
        // context.AddCommand(new Command(CommandType.MoveTo, (float)(400 + 100f * Math.Cos(t)), (float)(240 + 100f * Math.Sin(t))));
        // context.AddCommand(new Command(CommandType.LineTo, 400, 240));
        // context.AddCommand(new Command(CommandType.LineTo, 400, 340));
        // // context.AddCommand(new Command(CommandType.Close));
        // return context.Stroke();


        
        context.BeginPath();
        context.AddCommand(new Command(CommandType.MoveTo, 100, 100));
        context.AddCommand(new Command(CommandType.LineTo, 200, 200));
        context.AddCommand(new Command(CommandType.LineTo, 400, 200));
        context.AddCommand(new Command(CommandType.LineTo, 400, 400));
        // context.AddCommand(new Command(CommandType.Close));
        return context.Stroke();


    }
}

