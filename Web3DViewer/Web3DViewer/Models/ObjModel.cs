using System.Numerics;
using System.Text;

namespace Web3DViewer.Models;

/// <summary>
/// 3D модель в формате OBJ, содержащую коллекции вершин и граней.
/// </summary>
/// <remarks>
/// Используется для хранения данных 3D моделей,
/// загруженных из файлов формата Wavefront OBJ.
/// </remarks>
public class ObjModel
{
    /// <summary>
    /// Коллекция вершин модели.
    /// </summary>
    /// <value>
    /// Список объектов <see cref="Coordinate"/>, представляющих вершины модели в 3D пространстве.
    /// </value>
    public List<Coordinate> Vertices { get; set;  } = new();
    
    /// <summary>
    /// Коллекция полигонов модели.
    /// </summary>
    /// <value>
    /// Список объектов <see cref="Face"/>, где каждый объект представляет одну грань модели.
    /// </value>
    public List<Face> Faces { get; set; } = new();
    
    /// <summary>
    /// Формирует строковое представление модели.
    /// </summary>
    /// <returns>
    /// Строка, содержащая количество вершин и граней, а также их подробное представление.
    /// </returns>
    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Vertices count: {Vertices.Count}");
        result.AppendLine($"Faces count: {Faces.Count}");

        foreach (var coordinate in Vertices)
        {
            result.AppendLine("v " + coordinate);
        }

        foreach (var face in Faces)
        {
            result.AppendLine("f " + face);
        }
        
        return result.ToString();
    }
}