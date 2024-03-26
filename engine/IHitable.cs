namespace ConsoleRT;

public interface IHitable
{
    public bool Hit(Ray ray);
    public char GetChar(Ray ray);
    public char GetChar(Ray ray, bool useNormals);
}