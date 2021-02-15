using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCRUMAssignment.Data;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Services
{
    public class EmneHandler
    {

        private string filePath = @"\Data\DataEmner.json";

        public void Create(Emne emne)
        {
            JsonEmne jsonEmne = new JsonEmne();
            Dictionary<int, Emne> dic = jsonEmne.ReadJsonFile(filePath);
            dic.Add(emne.Id, emne);
            jsonEmne.WriteJsonFile(dic, filePath);
        }

        public void Delete(int id)
        {
            JsonEmne jsonEmne = new JsonEmne();
            Dictionary<int, Emne> dic = jsonEmne.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonEmne.WriteJsonFile(dic, filePath);
        }

        public Dictionary<int, Emne> FilterDictionary(int filter)
        {
            JsonEmne jsonEmne = new JsonEmne();
            Dictionary<int, Emne> dic = jsonEmne.ReadJsonFile(filePath);
            Dictionary<int, Emne> dicC = new Dictionary<int, Emne>();
            foreach (Emne emne in dic.Values)
            {
                {
                    dicC.Add(emne.Id, emne);
                }
               
            }
            return dicC;
        }

        public Emne Get(int id)
        {
            JsonEmne jsonEmne = new JsonEmne();
            Dictionary<int, Emne> dic = jsonEmne.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<int, Emne> GetDictionary()
        {
            JsonEmne jsonEmne = new JsonEmne();
            return jsonEmne.ReadJsonFile(filePath);

        }

       
    }
}

