using System;
using System.Collections.Generic;
using System.IO;

namespace FileRead
{
    public class FileReader : IFileReader
    {
        long index;
        int qtdrows;
        int qtdRownBuffer;
        string filePath;
        List<string> linesToShow;
        Dictionary<long, string> listBuffer;
        public FileReader(string filePath, int qtdLinhas)
        {
            this.filePath = filePath;
            this.qtdrows = qtdLinhas;
            this.qtdRownBuffer = 100;
            linesToShow = new List<string>();
            listBuffer = new Dictionary<long, string>();
            LoadBuffer(0);
        }

        public List<string> ReturnRows(long newIndex)
        {
            if (!listBuffer.ContainsKey(Convert.ToInt64(newIndex + qtdrows)) || !listBuffer.ContainsKey(Convert.ToInt64(newIndex)))
            {
                LoadBuffer(newIndex);
            }

            linesToShow.Clear();

            for (long i = newIndex; i < newIndex + qtdrows; i++)
            {
                if (!string.IsNullOrEmpty(listBuffer.GetValueOrDefault(i)))
                {
                    linesToShow.Add($"{i + 1} - {listBuffer.GetValueOrDefault(i)}");
                }
            }

            index = newIndex;

            return linesToShow;
        }

        public long GetCurrentIndex()
        {
            return this.index;
        }

        private void LoadBuffer(long newIndex)
        {
            newIndex = newIndex <= qtdrows ? 0 : newIndex;

            listBuffer.Clear();

            using StreamReader streamReader = new StreamReader(filePath);
            for (int i = 0; i < (newIndex + qtdRownBuffer); i++)
            {
                if (streamReader.EndOfStream)
                    return;

                var row = streamReader.ReadLine();

                if (i >= newIndex)
                {
                    listBuffer.Add(i, row);
                }
            }
        }
    }
}
