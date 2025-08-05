namespace Web3DViewer.Models;

public class Face
{
    public List<int> indexes { get; set; } = new();

    public override string ToString()
    {
        return string.Join(" ", indexes);
    }
}