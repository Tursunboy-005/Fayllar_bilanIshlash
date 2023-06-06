namespace Fayllar_bilanIshlasj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Games";

            string result = CheckPathBorligi(path);
            Console.WriteLine(result);
        }

        public static string CheckPathBorligi(string path)
        {
            if(Directory.Exists(path))
            {
                string[] directories = Directory.GetDirectories(path);
                string[] files = Directory.GetFiles(path);

                if(directories.Length > 0 && files.Length > 0)
                {
                    return "Papka va fayllar bor";
                }
                else if(directories.Length > 0)
                {
                    return "Papkalar bor;";
                }else if(files.Length > 0)
                {
                    return "Fayllar bor";
                }
                else
                {
                    return " Papka bo'sh";
                }
            }
            else
            {
                return "Berilgan Path yoq";
            }
        }
    }
}