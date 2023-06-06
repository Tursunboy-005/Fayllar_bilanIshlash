namespace Fayllar_bilanIshlasj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "C:\\New Text Document";

            int lineCount = CountLineInFile(filePath);
            Console.WriteLine($"Faylda {lineCount} qator mavjud");
        }

        public static int CountLineInFile(string filePath)
        {
            int lineCount = 0;

            if(File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                lineCount = lines.Length;
            }
            else
            {
                Console.WriteLine("Berilgan fayl yoq");
            }

            return lineCount;
        }
    }
}