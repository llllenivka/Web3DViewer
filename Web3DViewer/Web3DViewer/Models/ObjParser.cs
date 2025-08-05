namespace Web3DViewer.Models;

/// <summary>
/// Парсер 3D моделей из файлов формата OBJ.
/// </summary>
public static class ObjParser
{
    /// <summary>
    /// Префикс для строк, содержащих вершины в OBJ файле.
    /// </summary>
    private const string Vertices = "v ";
    
    /// <summary>
    /// Префикс для строк, содержащих полигоны в OBJ файле.
    /// </summary>
    private const string Faces = "f ";
    
    /// <summary>
    /// Парсит OBJ файл и возвращает соответствующую модель.
    /// </summary>
    /// <param name="filePath">Путь к OBJ файлу.</param>
    /// <returns>Заполненная модель ObjModel с вершинами и полигонами.</returns>
    /// <exception cref="System.IO.IOException">При проблемах чтения файла.</exception>
    /// <exception cref="System.FormatException">При некорректном формате данных в файле.</exception>
    public static ObjModel Parse(string filePath)
    {
        var model = new ObjModel();
        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            if (line.StartsWith(Vertices))
            {
                model.Vertices.Add(GetCoordinate(line));
            }
            else if (line.StartsWith(Faces))
            {
                model.Faces.Add(GetFace(line));
            }
        }
        
        return model;
    }

    /// <summary>
    /// Извлекает координаты вершины из строки OBJ файла.
    /// </summary>
    /// <param name="line">Строка с вершиной.</param>
    /// <returns>Объект Coordinate с координатами X,Y,Z.</returns>
    /// <exception cref="System.FormatException">При некорректном формате координат.</exception>
    private static Coordinate GetCoordinate(string line)
    {
        var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        return new Coordinate
        {
            X = float.Parse(parts[1]),
            Y = float.Parse(parts[2]),
            Z = float.Parse(parts[3])
        };
    }
    
    /// <summary>
    /// Извлекает данные о полигоне из строки OBJ файла.
    /// </summary>
    /// <param name="line">Строка с полигоном.</param>
    /// <returns>Объект Face с индексами вершин≥</returns>
    /// <exception cref="System.FormatException">При некорректном формате индексов.</exception>
    /// <remarks>
    /// Обрабатывает только индексы вершин (первое значение в группе v/vt/vn),
    /// нормали и текстурные координаты игнорируются.
    /// </remarks>
    private static Face GetFace(string line)
    {
        var parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var face = new Face();
                
        for (int i = 1; i < parts.Length; i++)
        {
            var vertexPart = parts[i].Split('/')[0];
            face.indexes.Add(int.Parse(vertexPart) - 1);
        }
        
        return face;
    }
}