using System.Numerics;
using System.Text;

namespace Web3DViewer.Models;

/**
 * Модель obj объекта7
 */
public class ObjModel
{
    /**
     * Вершины.
     */
    public List<Coordinate> Vertices { get; set;  } = new();
    
    /**
     * Индексы вершин для каждого полигона.
     */
    public List<Face> Faces { get; set; } = new();

    /**
     * 
     */
    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Vertices: {Vertices.Count}");
        result.AppendLine($"Faces: {Faces.Count}");

        foreach (var coordinate in Vertices)
        {
            Console.WriteLine("v " + coordinate);
        }

        foreach (var face in Faces)
        {
            Console.WriteLine("f " + face);
        }
        
        return result.ToString();
    }
}