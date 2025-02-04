﻿namespace BlackBox_Proyect_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            string title = "Proyect One";
            string[] options = { "Ahorcado", "Tablas" };
            bool running = true;
            Console.Clear();
            while (running)
            {
                int result = Tls.WriteMenu(title, options);
                Console.Clear();
                switch (result)
                {
                    case 1: 
                        Hung.Start();
                        Tls.enterClear(); 
                        break;
                    case 2: 
                        Tables.Start();
                        Tls.enterClear(); 
                        break;
                    case 0: 
                        running = false; 
                        break;
                    default: 
                        Tls.OutLine("Algun error sucedio."); Tls.enterClear(); 
                        break;
                }
            }
        }
    }
}