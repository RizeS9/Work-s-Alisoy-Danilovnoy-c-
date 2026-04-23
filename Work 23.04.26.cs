using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(folderPath);

            string fileName = "example.txt";

            string fullPath = Path.Combine(folderPath, fileName);
            Console.WriteLine(fullPath);

            File.Create(fullPath).Close();
            File.WriteAllText(fullPath, "бурмалдэнс");
            File.AppendAllText(fullPath, " от меллстройности");
            File.WriteAllText(fullPath, "не будет бурмалдэнса(");

            string[] words = new string[] { "я", "9mice", "kai angel", "15 охранников", "сьемочная группа", "гарсон хапаев", "боб строитель", "мурад хасанов", "рома хОмец" };


            File.WriteAllLines(fullPath, words);
            File.AppendAllLines(fullPath, words);
            File.AppendAllText(fullPath, "добро");

            string content = File.ReadAllText(fullPath);
            string[] lines = File.ReadAllLines(fullPath);

            Console.WriteLine(string.Join("\n\t", lines));

            string folderPath2 = Path.Combine(folderPath, "ExampleFolder");
            string filePath = Path.Combine(folderPath2, "anotherExampleFolder.txt");

            if (!Directory.Exists(folderPath2))
                Directory.CreateDirectory(folderPath2);
            if (!File.Exists(filePath))
                File.Create(filePath).Close();

        }
    }
}

