using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestProject.Data.Service
{
    public class DirectoryExplorer
    {
        private string _directory = "C:\\Users";

        public string[] GetFolderContents(string folderName)
        {
            string[] files = Directory.GetFiles(folderName);
            string[] folders = Directory.GetDirectories(folderName);
            
            return folders;
        }
    }
}