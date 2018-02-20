using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI.KATA.Exercise3.Services
{
    public class FileServices : IFileServices
    {
        private readonly string filePath;
        

        public FileServices(string filePath)
        {
            this.filePath = filePath;
        }
        public string ReadFile()
        {
            try
            {
                if(!string.Equals(Path.GetExtension(filePath), ".txt"))
                {
                    return "Error extension";
                }
                using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open), new UTF8Encoding()))
                {
                    
                    return reader.ReadToEnd();
                }
            }catch(Exception ex)
            {
                return "Error file";
            }

        }
    }
}
