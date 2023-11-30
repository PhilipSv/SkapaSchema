using Affärslager;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;

namespace Presentationslager
{
    class Program
    {
        static void Main(string[] args)
        {
            SchemaKontroller.SkapaDatabas();

            SchemaKontroller.SkrivUtLärare();

            

            // Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1.   Skapa Schema");
            Console.WriteLine("0.   Avsluta");
            Console.Write(":");
            int.TryParse(Console.ReadLine(), out int input);

            switch (input)
            {
                case 1:
                    SkapaSchema();
                    break;

                case 0:
                    Close();
                    break;
            }
        }

        private static void SkapaSchema()
        {
            //HamtaSchema();
        }

        private static void Close()
        {
            Environment.Exit(0);
        }

        
    }
}
