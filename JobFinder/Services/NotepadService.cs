using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobFinder.Abstract;
using JobFinder.Constants;

namespace JobFinder.Services
{
    internal class NotepadService
    {
        public string Path { get; set; }

        public void SaveToNotepad(ICsvConvertable data) //string data instance
        {
            string path = $"{FileLocations.ProjectFolder}\\Database";
            string type = data.GetType().ToString().Split(".").LastOrDefault(); 
            //We are gonna reach the type of this instance (customer or freelancer)
          

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string filePath = $"{path}\\{type}.txt";
            //the txt file must be customer.txt or freelancer.txt

            File.AppendAllText(filePath, $"{data.GetValues()}\n");

        }

        public string GetOnNotepad(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            throw new Exception("File doesn't exist!");
        }
    }
}
