using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDVDMerger
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                string Parent_Name = Path.GetDirectoryName(arg);

                List<string> Clones = GetClones(arg);

                foreach (string Clone in Clones)
                {
                    List<string> Dirs_and_Files = new List<string>();
                }
            }
        }

        private static List<string> GetClones(string arg)
        {
            List<string> Clones = new List<string>();
            Clones.AddRange(Directory.GetDirectories(arg));
            Clones.AddRange(Directory.GetFiles(arg));
            return Clones;
        }
    }
}
