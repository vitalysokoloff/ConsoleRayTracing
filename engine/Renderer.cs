namespace ConsoleRT;

public class Renderer
{
    public Camera Camera;
    protected GraphicsContext _context;
    
    public Renderer(GraphicsContext context)
    {
        _context = context;
        
        int width = _context.Width;
        int height = _context.Height;
        Camera = new Camera(
            new Vector3(0, 2, -2),
            new Vector3(0, 0, 0),
            new Vector3(0, 1, 0),
            90,
            width / (float)height
            );
    }

    public void Calculate(IHitable hitable)
    {
        int width = _context.Width;
        int height = _context.Height;
        float aspect = width / (float)height;
        float pixelAspect = 8.0f / 16.0f;
        float totalAspect = aspect * pixelAspect;

        Vector3 loverLeftCorner = new Vector3(-2 , -1 * totalAspect, -1);
        Vector3 horizontal = new Vector3(4, 0, 0);
        Vector3 vertical = new Vector3(0, 2 * totalAspect, 0);
        Vector3 origin = new Vector3(0, 0, 1);

        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            { 
                float u = i / (float)width;
                float v = j / (float)height * totalAspect;
                Ray ray = new Ray(origin, loverLeftCorner + horizontal * u + vertical * v);
                _context.DrawPixel(new Point(i, j), hitable.GetChar(ray));
            }
        }
    }
}