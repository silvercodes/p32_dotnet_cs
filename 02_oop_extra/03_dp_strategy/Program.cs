
ICompression zipComp = new ZipCompression();
ICompression rarCom = new RarCompression();
ICompression defCom = new DeflateCompression();

Compressor compressor = new Compressor(zipComp);
Console.WriteLine(compressor.MakeArchive("data.txt"));
//
//
compressor.CompressionStrategy = rarCom;
Console.WriteLine(compressor.MakeArchive("data.txt"));

compressor.CompressionStrategy = defCom;
Console.WriteLine(compressor.MakeArchive("data.txt"));


abstract class ICompression
{
    public abstract string Compress(string path);
}

class ZipCompression : ICompression
{
    public override string Compress(string path)
    {
        return $"zip file: {path}.zip";
    }
}
class RarCompression : ICompression
{
    public override string Compress(string path)
    {
        return $"rar file: {path}.rar";
    }
}
class DeflateCompression: ICompression
{
    public override string Compress(string path)
    {
        return $"def file: {path}.def";
    }
}

class Compressor
{
    public ICompression CompressionStrategy { get; set; }
    public Compressor(ICompression compression)
    {
        CompressionStrategy = compression;
    }

    public string MakeArchive(string path)
    {
        return CompressionStrategy.Compress(path);
    }
}
