using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Data
{
    public class JsonFileReader
    {
        public static List<Emne> ReadJson(string JsonFileName)
        {
            using (var JsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<List<Emne>>(JsonFileReader.ReadToEnd());

            }
        }
    }
}
