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
        private readonly bool isEncrypted;
        

        public FileServices(string filePath)
        {
            this.filePath = filePath;
            this.isEncrypted = false;
        }

        public FileServices(string filePath, bool isEncrypted)
        {
            this.filePath = filePath;
            this.isEncrypted = isEncrypted;
        }

        public string ReadFile()
        {
            try
            {
                if (!isEncrypted)
                {
                    if (!string.Equals(Path.GetExtension(filePath), ".txt")
                        && !string.Equals(Path.GetExtension(filePath), ".xml")
                        )
                    {
                        return "Error extension";
                    }
                    using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open), new UTF8Encoding()))
                    {

                        return reader.ReadToEnd();
                    }
                }
                else
                {
                    //prérequis : reverse algorithm
                    if (!string.Equals(Path.GetExtension(filePath), ".txt"))
                    {
                        return "Error extension";
                    }
                    using (StreamReader reader = new StreamReader(new FileStream(filePath, FileMode.Open), new UTF8Encoding()))
                    {

                        var content = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(content))
                        {
                            return new string(content.Reverse().ToArray());
                        }
                        return string.Empty;
                    }
                }
            }catch(Exception ex)
            {
                return "Error file";
            }

        }

    }
}
