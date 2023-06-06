namespace Fayllar_bilanIshlasj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parentDirectory = Directory.GetParent("C:\\games");
            Console.WriteLine(parentDirectory);

            string path = "C:\\New folder\\";

            if(Directory.Exists(path))
            {
                var directories = Directory.GetDirectories(path);
                string newDirectory = "C:\\New folder\\";


                foreach(var d in directories)
                {
                    Console.WriteLine(d);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            DateTime dateTime = Directory.GetLastWriteTime(path);
            Directory.Delete(path, true);
            Directory.Delete("C:\\New folder", true);
        }
    }
}