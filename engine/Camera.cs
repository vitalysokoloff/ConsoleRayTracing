namespace ConsoleRT;

public class Camera
{
    protected Vector3 _origin;
    protected Vector3 _lowerLeftCorner;
    protected Vector3 _horizontal;
    protected Vector3 _vertical;

    public Camera(Vector3 origin, Vector3 target, Vector3 vup, float fov, float aspect)
    {
        
    }

    public Ray GetRay(float u, float v)
    {
        return new Ray(_origin, _lowerLeftCorner + _horizontal * u + _vertical * v);
    }
}