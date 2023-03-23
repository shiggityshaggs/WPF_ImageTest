using System.IO;

namespace ImageTest
{
    public static class Extension
    {
        public static Stream AsStream(this byte[]? data) =>
            data is { } ?
            new MemoryStream(data) :
            new MemoryStream();
    }
}