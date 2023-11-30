using Models;
using Datalager;

namespace Affärslager
{
    public static class SchemaKontroller
    {
        //public void SchemaD

        public static void Test()
        {
            Console.WriteLine("test");
        }

        public static void SkapaDatabas()
        {
            Databas instans = new Databas();
        }

        public static void SkrivUtLärare()
        {
            List<Larare> AllaLarare = Databas.HämtaLärare();

            foreach (Larare larare in AllaLarare)
            {
                Console.WriteLine(larare.Fornamn +" "+ larare.Efternamn);
            }
        }
        
    }
}
