using System;
using System.Diagnostics;
using System.IO;

namespace ConvertToBak
{
    class Program
    {
        static void Main(string[] args)
        {
            var safeFile = args[0];

            var path = Path.GetDirectoryName(safeFile);

            var command = $"/c safetosql \"{safeFile}\" -output \"{path}\"";

            Process.Start("CMD.exe", command);
        }
    }
}
