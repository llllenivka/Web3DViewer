namespace Web3DViewer.Models;

/// <summary>
/// Полигон 3D модели, состоящую из индексов вершин.
/// </summary>
/// <remarks>
/// Используется для хранения полигонов при загрузке OBJ моделей.
/// Индексы вершин соответствуют позициям в коллекции <see cref="ObjModel.Vertices"/>.
/// </remarks>
public class Face
{
    /// <summary>
    /// Список индексов вершин, образующих грань
    /// </summary>
    /// <value>
    /// Коллекция целых чисел, где каждое число представляет индекс вершины.
    /// </value>
    public List<int> indexes { get; set; } = new();

    /// <summary>
    /// Формирует строковое представление грани.
    /// </summary>
    /// <returns>
    /// Строка, содержащая индексы вершин, разделенные пробелами.
    /// </returns>
    public override string ToString()
    {
        return string.Join(" ", indexes);
    }
}