using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Data
{
    public class JsonKategori
    {
        public Dictionary<int, Kategori> ReadJsonFile(string filePath)
        {
            string input = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Dictionary<int, Kategori>>(input);
        }

        public void WriteJsonFile(Dictionary<int, Kategori> dic, string filePath)
        {
            string output = JsonConvert.SerializeObject(dic, Formatting.Indented);
            File.WriteAllText(filePath, output);
        }
    }
}