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
        public NexusWriter(List<String> taxa)
        {
            this.taxa = new List<String>(taxa);
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
            }
        }
    }
}
