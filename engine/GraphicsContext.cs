namespace ConsoleRT;

public class GraphicsContext
{
    public char[] PixelBuffer { get; protected set;}
    public int Width { get; }
    public int Height { get; }

    public GraphicsContext(int width, int height)
    {
        Width = width;
        Height = height;
        PixelBuffer = new char[Width * Height];   
    }

    public void Reset()
    {
        PixelBuffer = new char[Width * Height];
    }

    public void DrawPixel(Point position, char c)
    {
        PixelBuffer[position.X + position.Y * Width] = c;
    }    

    public void DrawString(string text, Point position)
    {
        for (int i = 0; i < text.Length; i++)
            PixelBuffer[position.X + position.Y * Width + i] = text[i];
    }
}
