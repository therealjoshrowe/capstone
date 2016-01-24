using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Nex_Maukup
{
    class NexusWriter
    {
        private List<String> taxa;
        private List<String> data;
        public NexusWriter(List<String> taxa, List<String> data)
        {
            this.taxa = new List<String>(taxa);
            this.data = new List<String>(data);
        }

        public void WriteToFile()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\capstone\output.nex"))
            {
                file.WriteLine("#NEXUS");
                file.WriteLine("BEGIN TAXA;");
                file.WriteLine("Dimensions NTax=" + taxa.Count);
                file.Write("TaxLabels ");

                foreach (string taxon in taxa)
                {
                    file.Write(taxon + " ");
                }
                file.WriteLine();

                file.WriteLine("END;");

                file.WriteLine("BEGIN CHARACTERS;");
                file.WriteLine("DIMENSIONS NChar=");
                file.WriteLine("MATRIX");
                foreach (String s in data)
                {
                    file.WriteLine(s);
                }
                file.Write(";");
                file.WriteLine("END;");
            }
        }
    }
}
