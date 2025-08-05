using Web3DViewer.Models;

namespace Web3DViewer;

public static class Program
{
    public static void Main(string[] args)
    {
        var obj = ObjParser.Parse("simple_cube.obj");
        Console.WriteLine(obj);
        // var builder = WebApplication.CreateBuilder(args);
        //
        // var app = builder.Build();
        // app.MapGet("/", () => "Hello World!");
        // app.UseStaticFiles();
        //
        // app.Run();
    }
}
