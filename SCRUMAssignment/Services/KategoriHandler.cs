using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCRUMAssignment.Models;
using SCRUMAssignment.Data;


namespace SCRUMAssignment.Services
{
    public class KategoriHandler
    {

        private string filePath = @"\Data\DataKategori.json";

        public void Create(Kategori kategori)
        {
            JsonKategori jsonKategori = new JsonKategori();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            dic.Add(kategori.Id, kategori);
            jsonKategori.WriteJsonFile(dic, filePath);
        }

        public void Delete(int id)
        {
            JsonKategori jsonKategori = new JsonKategori();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            dic.Remove(id);
            jsonKategori.WriteJsonFile(dic, filePath);
        }

        public Dictionary<int, Kategori> FilterDictionary(int filter)
        {
            JsonKategori jsonKategori = new JsonKategori();
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
            JsonKategori jsonKategori = new JsonKategori();
            Dictionary<int, Kategori> dic = jsonKategori.ReadJsonFile(filePath);
            return dic[id];
        }

        public Dictionary<int, Kategori> GetDictionary()
        {
            JsonKategori jsonKategori = new JsonKategori();
            return jsonKategori.ReadJsonFile(filePath);

        }

        
    }
}

