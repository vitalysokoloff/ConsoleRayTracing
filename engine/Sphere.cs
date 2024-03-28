namespace ConsoleRT;

public class Sphere : IHitable
{
    public Vector3 Center
    {
        get
        {
            return _center;
        }
    }
    public float Radius
    {
        get
        {
            return _radius;
        }
    }
    public Vector3 Color
    {
        get
        {
            return _color;
        }
    }

    protected Vector3 _center;
    public float _radius;
    public Vector3 _color;

    public Sphere()
    {
        _center = new Vector3(0, 0, 0);
        _radius = 0.5f;
        _color = new Vector3(1, 0, 0);
    }

    public Sphere(Vector3 center, float radius, Vector3 color)
    {
        _center = center;
        _radius = radius;
        _color = color;
    }

    public bool Hit(Ray ray)
    {
        Vector3 oc = ray.Origin - _center;
        float a = ray.Direction * ray.Direction;
        float b = oc * ray.Direction * 2.0f;
        float c = oc * oc - _radius * _radius;
        float discriminant = b * b - 4 * a * c;
        return discriminant > 0;
    }

    public char GetChar(Ray ray)
    {
        if (Hit(ray))
        {
            return new Color(_color).Value;
        }
        else
        {
            return ' ';
        }
    }

    public char GetChar(Ray ray, bool useNormal)
    {
        if (useNormal)
        {
            return GetChar(ray);
        }
        else
        {
            return GetChar(ray);
        }
    }
}