namespace ConsoleRT;

public class Vector3
{
    public float X { get; private set; }
    public float Y { get; private set; }
    public float Z { get; private set; } 
    public float Length
    {
        get
        {
            return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
        }
    }

    public static Vector3 Zero
    {
        get
        {
            return new Vector3(0, 0, 0);
        }
    }       

    public Vector3()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Normalize()
    {
        float length = Length;
        X = X / length;
        Y = Y / length;
        Z = Z / length;
    }

    /// <summary>
    /// Перекрестное произведение двух векторов.
    ///
    /// В результате векторного произведения двух векторов получается третий вектор, 
    /// который перпендикулярен двум входным векторам.
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    public static Vector3 Cross(Vector3 v1, Vector3 v2)
    {
        return new Vector3(
            v1.Y * v2.Z - v1.Z * v2.Y,
            -v1.X * v2.Z - v1.Z * v2.X,
            v1.X * v2.Y - v1.Y * v2.X 
            );
    }

    public static Vector3 operator + (Vector3 a, Vector3 b)
    {
        return new Vector3 { X = a.X + b.X, Y = a.Y + b.Y, Z = a.Z + b.Z };
    }

    public static Vector3 operator - (Vector3 a, Vector3 b)
    {
        return new Vector3 { X = a.X - b.X, Y = a.Y - b.Y, Z = a.Z - b.Z};
    }

    public static Vector3 operator * (Vector3 a, float b)
    {
        return new Vector3 { X = a.X * b, Y = a.Y * b, Z = a.Z * b };
    }

        public static Vector3 operator / (Vector3 a, float b)
    {
        return new Vector3 { X = a.X / b, Y = a.Y / b, Z = a.Z / b };
    }

    public static float operator * (Vector3 a, Vector3 b)
    {
        return a.X*b.X + a.Y*b.Y + a.Z*b.Z;
    }
}