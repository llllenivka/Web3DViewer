namespace Web3DViewer.Models;

/**
 * Координата.
 */
public class Coordinate
{
    /**
     * Ось X.
     */
    public float X { get; set; }
    
    /**
     * Ось Y.
     */
    public float Y { get; set; }
    
    /**
     * Ось Z.
     */
    public float Z { get; set; }

    /**
     * 
     */
    public override string ToString()
    {
        return $"{X} {Y} {Z}";
    }
}