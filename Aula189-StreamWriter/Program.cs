/* StreamWriter - Utilizada para escrever caracteres a partir de uma stream binaria. Ex.: FileStream. 
    - Suporta dados em formato de texto. 
*/

using System;
using System.IO;

namespace Aula189_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";


            try
            {
                string[] lines = File.ReadAllLines(sourcePath); // Le o conteudo do arquivo e armazena no vetor de string

                using (StreamWriter sw = File.AppendText(targetPath)) // Abre o arquivo para escrita e acrescenta ao final
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
