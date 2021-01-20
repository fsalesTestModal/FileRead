using System;
using System.IO;
using System.Linq;
using Xunit;

namespace FileRead.Test.Unit
{
    public class FileReadTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(100)]
        [InlineData(1000)]
        public void ReturnRows_ReturnFilledList(long index)
        {
            string AppPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            AppPath = AppPath.Replace("bin\\Debug\\netcoreapp3.1", "");
            var testFile = @"Artifact\sample.csv";
            var filePath = AppPath + testFile;

            var qtdRows = 11;

            var fileReader = new FileReader(filePath, qtdRows);
            var listRowx = fileReader.ReturnRows(index);

            Assert.True(listRowx.Any());
            Assert.Equal(11, listRowx.Count);
        }
    }
}
