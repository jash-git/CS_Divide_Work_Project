using Console_Folder_namespace.global;

namespace Console_Folder_namespace
{
    static class Program
    {
        public static void pause()
        {
            Console.WriteLine("Press any key to terminate...");
            Console.ReadKey();
            global.LogFile.Write("Colse APP");
        }
        static void Main(string[] args)
        {
            global.LogFile.Write("Start APP");
            LogFile.CleanLog();
            pause();
        }
    }
}
