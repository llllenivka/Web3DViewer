namespace Web3DViewer.Models;

/// <summary>
/// 3D координата с компонентами X, Y и Z.
/// </summary>
/// <remarks>
/// Для хранения позиций вершин в 3D пространстве.
/// </remarks>
public class Coordinate
{
    /// <summary>
    /// Координата по оси X.
    /// </summary>
    /// <value>Вещественное число, представляющее положение по горизонтальной оси.</value>
    public double X { get; set; }
    
    /// <summary>
    /// Координата по оси Y.
    /// </summary>
    /// <value>Вещественное число, представляющее положение по вертикальной оси.</value>
    public double Y { get; set; }
    
    /// <summary>
    /// Координата по оси Z.
    /// </summary>
    /// <value>Вещественное число, представляющее положение по глубине.</value>
    public double Z { get; set; }
    
    /// <summary>
    /// Инициализирует новую координату с указанными значениями.
    /// </summary>
    /// <param name="x">Значение по оси X.</param>
    /// <param name="y">Значение по оси Y.</param>
    /// <param name="z">Значение по оси Z.</param>
    public Coordinate(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    
    /// <summary>
    /// Формирует строковое представление координаты.
    /// </summary>
    /// <returns>
    /// Строка в формате "X Y Z" с компонентами, разделенными пробелами.
    /// </returns>
    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}