public interface IFileReader
{
    string[] Read(string path);
}

public class FileReader : IFileReader
{
    public virtual string[] Read(string path)
    {
        return File.ReadAllLines(path);
    }
}