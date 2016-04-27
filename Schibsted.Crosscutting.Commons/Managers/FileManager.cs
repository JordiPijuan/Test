using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schibsted.Crosscutting.Commons.Managers
{
    public class FileManager
    {
        public static void CreateFile(string filePath, string texto, bool append = true)
        {
            using (var fileWriter = new StreamWriter(filePath, append))
            {
                fileWriter.Write(texto);
                fileWriter.Flush();
            }
        }

        public static void DeleteFile(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }

        public static void CopyFile(string sourceFile, string destFile, bool rewrite)
        {
            File.Copy(sourceFile, destFile, rewrite);
        }

        public static void CopyFileWithRewrite(string sourceFile, string destFile)
        {
            CopyFile(sourceFile, destFile, true);
        }

        public static FileStream ReadFile(string path)
        {
            return File.OpenRead(path);
        }

        public static StreamReader ReadFileStream(string path)
        {
            return new StreamReader(ReadFile(path), Encoding.UTF8);
        }

        public static string ReadFileToString(string path)
        {
            using (var fileStream = ReadFile(path))
            {
                using (var stream = new StreamReader(fileStream))
                {
                    return stream.ReadToEnd();
                }
            }

            return string.Empty;
        }

    }

}
