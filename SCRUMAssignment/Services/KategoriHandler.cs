using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCRUMAssignment.Models;
using SCRUMAssignment.Data;
using System.IO;

namespace SCRUMAssignment.Services
{
    public class KategoriHandler
    {

        private string filePath = Path.GetFullPath("./Data/DataKategori.json", Environment.CurrentDirectory);

        public void Create(Kategori kategori)
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            dic.Add(kategori.Id, kategori);
            jsonKategori.WriteJsonFile(dic, filePath);
        }

        public void Delete(int id)
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonKategori.WriteJsonFile(dic, filePath);
        }

        public void Update(Kategori kategori, int id)
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);

            if (dic[id] != null)
            {
                dic[id] = kategori;
                jsonKategori.WriteJsonFile(dic, filePath);
            }
        }

        public Dictionary<int, Kategori> FilterDictionary(int filter)
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            Dictionary<int, Kategori> dicC = new Dictionary<int, Kategori>();
            foreach (Kategori kategori in dic.Values)
            {
                {
                    dicC.Add(kategori.Id, kategori);
                }

            }
            return dicC;
        }

        public Kategori Get(int id)
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<int, Kategori> GetDictionary()
        {
            JsonEmne<Kategori> jsonKategori = new JsonEmne<Kategori>();
            return jsonKategori.ReadJsonFile(filePath);

        }

        
    }
}

