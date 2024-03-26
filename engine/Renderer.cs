namespace ConsoleRT;

public class Renderer
{
    protected GraphicsContext _context;
    
    public Renderer(GraphicsContext context)
    {
        _context = context;
    }

    public void Calculate(IHitable hitable)
    {
        int width = _context.Width;
        int height = _context.Height;
        float aspect = width / (float)height;
        float pixelAspect = 8.0f / 16.0f;
        float totalAspect = aspect * pixelAspect;

        Vector3 loverLeftCorner = new Vector3(-2 / totalAspect, -1, -1);
        Vector3 horizontal = new Vector3(4 / totalAspect, 0, 0);
        Vector3 vertical = new Vector3(0, 2, 0);
        Vector3 origin = new Vector3(0, 0, 0);

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                float u = i / (float)width / totalAspect;
                float v = j / (float)height;
                Ray ray = new Ray(origin, loverLeftCorner + horizontal * u + vertical * v);
                _context.DrawPixel(new Point(i, j), hitable.GetChar(ray));
            }
        }
    }
}