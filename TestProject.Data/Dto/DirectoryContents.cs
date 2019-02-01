using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Data.Dto
{
    public class DirectoryContents
    {
        public IEnumerable<string> SubDirectories { get; set; }

        public IEnumerable<string> Files { get; set; }
    }
}
