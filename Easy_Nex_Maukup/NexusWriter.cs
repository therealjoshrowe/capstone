using Shared_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Nex_Maukup
{
    class NexusWriter
    {
        private NexusFile nexusOb;
        public NexusWriter(NexusFile n)
        {
            nexusOb = n;
        }

        public void WriteToFile()
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"C:\capstone\output.nex"))
            {
                file.WriteLine("#NEXUS");
                file.WriteLine("BEGIN TAXA;");
                file.WriteLine("Dimensions NTax=" + nexusOb.T.taxa.Count);
                file.Write("TaxLabels ");

                foreach (string taxon in nexusOb.T.taxa)
                {
                    file.Write(taxon + " ");
                }
                file.WriteLine();

                file.WriteLine("END;");

            }
        }
    }
}
