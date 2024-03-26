namespace ConsoleRT;

public class App
{
    Graphics graphics;
    Renderer renderer;
    IHitable hitable;

    public App(string path)
    {
        int width = 100;
        int height = 40;        
        graphics = new Graphics(width, height);
        renderer = new Renderer(graphics.Context);

        // Только на Windows
        Console.SetWindowSize(width, height);

        if (path == null)
        {
            hitable = new Sphere();
        }
        else
        {
            hitable = new Sphere();
        }        
    }

    public void Run()
    {
        Draw();
    }

    public void Draw()
    {        
        graphics.Begin();
        renderer.Calculate(hitable);
        graphics.Context.DrawString("Заебись", new Point(5, 38));
        graphics.End();
        Console.ReadKey();
    }
}