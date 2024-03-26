namespace ConsoleRT;

public class Color
{
    public char Value 
    {
        get
        {
            return _value;
        }
    }

    protected char _value;

    /// <summary>
    /// Принимает вектор, желательно со значениями не боль (1, 1, 1) и преобразует в char из таблицы градиента { .:;+=xX$&}
    /// </summary>
    /// <param name="v"></param>
    public Color(Vector3 v)
    {
        char[] values = {' ', '.', ':', ';', '+', '=', 'x', 'X', '$', '&'};
        float sum = v.X + v.Y + v.Z;
        if (sum > 3)
        {
            _value = values[9];
        }
        else
        {
            int index = (int)(sum / 3 * 100 / 10);
            _value = values[index];
        }
    }
}