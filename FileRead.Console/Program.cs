using FileRead.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            ConsoleKey keyPressed;

            var index = 0L;
            var qtdRows = 11;
            var listRows = new List<string>();

            var filePath = OpenFile();

            IFileReader fileReader = new FileReader(filePath, qtdRows);
            listRows = fileReader.ReturnRows(index);

            PrintRows(listRows);

            do
            {
                keyPressed = Console.ReadKey().Key;

                index = GetIndex(keyPressed, fileReader);

                if (index != fileReader.GetCurrentIndex())
                {
                    listRows = fileReader.ReturnRows(index);
                    PrintRows(listRows);
                }

            } while (keyPressed != ConsoleKey.Escape);
        }

        private static long GetIndex(ConsoleKey keyPressed, IFileReader fileReader)
        {
            long index = fileReader.GetCurrentIndex();
            var commandKey = CommandKeyFactory.Create(keyPressed);

            switch (commandKey)
            {
                case CommandKeyL keyL:

                    Console.Clear();
                    
                    PrintHeader();

                    bool success;

                    do
                    {
                        Console.WriteLine("Digite o  nº da Linha que deseja visualizar: ");

                        success = long.TryParse(Console.ReadLine(), out long userIndex);

                        if (success)
                        {
                            index = keyL.ReturnIndex(userIndex);
                        }
                        else
                        {
                            Console.WriteLine("Não é um nº válido: ");
                        }

                    } while (!success);
              
                    break;

                default:

                    index = commandKey.ReturnIndex(index);

                    break;
            }

            return index;
        }

        private static void PrintRows(List<string> listRows)
        {
            Console.Clear();
            PrintHeader();
            if (listRows.Any())
            {
                listRows.ForEach(row => Console.WriteLine(row));
            }
            else
            {
                Console.WriteLine("Não há dados para exibir!: ");
            }
        }

        private static void PrintHeader()
        {
            Console.WriteLine();
            Console.WriteLine(" [↑] - [↓] - [PgUp] - [PgDn] - [ [L] -> [Buscar Índice] ] ");
            Console.WriteLine();
        }

        private static string OpenFile()
        {
            bool isValide;
            string filePath;
            do
            {
                Console.WriteLine("Informe a localização do arquivo no disco: ");
                filePath = Console.ReadLine();

                isValide = File.Exists(filePath);

                if (!isValide)
                {
                    Console.WriteLine("Arquivo não encontrado!: ");
                }

            } while (!isValide);

            return filePath;
        }
    }
}

