// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace EditHTML // Note: actual namespace depends on the project name.
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("=========================");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("=====================");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
            // Console.WriteLine("1 - Sim");
            // Console.WriteLine("2 - Não");
        }
      
    }
}