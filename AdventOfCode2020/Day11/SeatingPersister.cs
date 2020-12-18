using System;
using System.Text;

namespace AdventOfCode2020.Day11
{
    public static class SeatingPersister
    {
        public static void WriteToFile(char[,] currentSeating, string path, string filename)
        {
            var fullPath = System.IO.Path.Combine(path, filename);

            if (System.IO.File.Exists(fullPath))
            {
                System.IO.File.Delete(fullPath);
            }
            
            for (int row = 0; row <= currentSeating.GetUpperBound(0); row++)
            {
                var sb = new StringBuilder();
                for (int column = 0; column <= currentSeating.GetUpperBound(1); column++)
                {
                    sb.Append(currentSeating[row, column]);
                }

                using (var streamWriter = System.IO.File.AppendText(fullPath))
                {
                    streamWriter.Write(sb.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
