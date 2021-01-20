using System.Collections.Generic;

namespace FileRead
{
    public interface IFileReader
    {
        long GetCurrentIndex();
        List<string> ReturnRows(long newIndex);
    }
}