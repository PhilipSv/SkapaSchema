using Models;

namespace Datalager
{
    public class Databas
    {
        
        internal List<Schema> scheman = new List<Schema>();
        internal List<Sal> salar = new List<Sal>();
        internal List<Utbildningstillfalle> utbildningstillfallen = new List<Utbildningstillfalle>();
        internal List<Schemarad> schemarader = new List<Schemarad>();
        public static List<Larare> larare = new List<Larare>();
        internal List<Kurstillfalle> kurstillfallen = new List<Kurstillfalle>();
        
        

        
        public Databas()
        {
            larare = new List<Larare>()
            {
                new Larare("Pontus", "Idre", "POID"),
                new Larare("Magda", "Murt", "MAMU"),
                new Larare("Legolas", "Alv", "LEAL")
            };

            salar = new List<Sal>()
            {
                new Sal("A105", 18),
                new Sal("C205", 30),
                new Sal("D307", 28)
            };

            utbildningstillfallen = new List<Utbildningstillfalle>()
            {
                new Utbildningstillfalle("Systemvetarutbildning", "ASYST22h", 2022, "Patrik" ),
                new Utbildningstillfalle("Dataekonomutbildningen", "ADAEK22h", 2022, "Helena" ),
                new Utbildningstillfalle("Systemarkitektutbildningen", "ASYAR23h", 2023, "Johan" )


            };

            scheman = new List<Schema>()
            {
                new Schema("Dataekonomutbildningen"),
                new Schema("Systemarkitektutbildningen"),
                new Schema("Systemvetarutbildningen")
            };

            schemarader = new List<Schemarad>()
            {
                new Schemarad(new DateOnly(2023, 11, 30), new TimeOnly(10,00), new TimeOnly(12,00), "Föreläsning 4 - Vafan?", " ")
            };
            
        }
        
        public static List<Larare> HämtaLärare()
        {
            return larare;
        }
        
    }
}
