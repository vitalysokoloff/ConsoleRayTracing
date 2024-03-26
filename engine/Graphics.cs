namespace ConsoleRT;

public class Graphics
{
    public GraphicsContext Context { get; }
  
    public Graphics(int width, int height)
    {
        Context = new GraphicsContext(width, height);
        Context.Reset();
    }

    public void Begin()
    {
        Context.Reset();
        Console.SetCursorPosition(0,0);
    }

    public void End()
    {
        Console.WriteLine(Context.PixelBuffer);
    }        
}