
using System.IO;
using indice.Edi;

namespace indice.Test
{
    class Program
    {
        static void Main(string[] args) {

            var manager = new GestampSinPaletManager();
            //var manager = new GestampConPaletManager();

            var grammar = EdiGrammar.NewEdiFact();

            var albaran = manager.BuildNopalletExample();

            //var albaran = manager.BuildPalletExample();


            // serialize to file.            
            using (var textWriter = new StreamWriter(File.Open(@"c:\Projects\AlbaranGESTAMP.edi", FileMode.Create))) {
                using (var ediWriter = new EdiTextWriter(textWriter, grammar)) {
                    new EdiSerializer().Serialize(ediWriter, albaran);
                }
            }
        }
    }
}
