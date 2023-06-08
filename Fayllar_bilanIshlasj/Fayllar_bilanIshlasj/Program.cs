namespace Fayllar_bilanIshlasj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            //string path = Directory.GetCurrentDirectory();
            //DirectoryInfo directoryInfo = Directory.GetParent(path);
            //var parentDirecctory = directoryInfo.Parent.Parent.Parent.Parent;

            //File.Create($"{parentDirecctory}\\.gitignore");
            #endregion
            #region Task 2

            string fullPath = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = new DirectoryInfo(fullPath).Parent.Parent.Parent.Parent;
            string[] directories = Directory.GetDirectories(directoryInfo.FullName, "*", SearchOption.AllDirectories);

            foreach(string directory in directories)
            {
                string FolderNmae = Path.GetFileName(directory);
                if(FolderNmae == "bin" || FolderNmae == "obj")
                {
                    Console.WriteLine(directory);
                }
            }

            #endregion
        }
    }
}