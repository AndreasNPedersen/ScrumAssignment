using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Helpers
{
    public class JsonFileWriter
    {
        public static void WriteToJson(List<Emne> @events, string JsonFileName)
        {
            using (FileStream outputStream = File.OpenWrite(JsonFileName))
            {
                var writter = new Utf8JsonWriter(outputStream, new JsonWriterOptions
                {
                    SkipValidation = false,
                    Indented = true
                });
                JsonSerializer.Serialize<Emne[]>(writter, events.ToArray());
            }
        }
    }
}
