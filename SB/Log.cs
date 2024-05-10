using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB
{
    public static class Log
    {
        
        private static StringBuilder combined = new StringBuilder();
        public static void CreateLog()
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("HH_mm");
            string filename = "Result_" + formattedDateTime + ".csv";
            combined.AppendLine(SBModel.T1Name+","+SBModel.T2Name);
            combined.AppendLine("FirstHalf,FirstHalf");
            compilescore(SBModel.T1F,SBModel.T2F);
            combined.AppendLine("SecondHalf,SecondHalf");
            compilescore(SBModel.T1S, SBModel.T2S);
            combined.AppendLine("Total,Total");
            combined.AppendLine(SBModel.T1Score+","+SBModel.T2Score);
            File.WriteAllText(filename,combined.ToString());
        }
        private static void compilescore(string A, string B)
        {
            string[] linesA = A.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            string[] linesB = B.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            int maxLength = Math.Max(linesA.Length, linesB.Length);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < linesA.Length)
                {
                    combined.Append(linesA[i]);
                }
                combined.Append(",");
                if (i < linesB.Length)
                {
                    combined.Append(linesB[i]);
                }
                combined.Append("\n");
            }
        }

    }
}
