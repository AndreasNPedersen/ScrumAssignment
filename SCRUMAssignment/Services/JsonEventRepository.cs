using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCRUMAssignment.Models;
using SCRUMAssignment.Helpers;
using SCRUMAssignment.Data;
using SCRUMAssignment.Interfaces;

namespace SCRUMAssignment.Services
{
    public class JsonEventRepository:IEventRepository
    {
        string JsonFileName = @"D:\Documents\GitHub\ScrumAssignment\SCRUMAssignment\Data\JsonEvents.json";

        public List<Emne> GetAllEvents()
        {
            return JsonFileReader.ReadJson(JsonFileName);
        }

        public void AddEmne(Emne evt)
        {
            List<Emne> @events = GetAllEvents().ToList();
            List<int> eventIds = new List<int>();
            foreach (var ev in events)
            {
                eventIds.Add(ev.Id);
            }
            if (eventIds.Count != 0)
            {
                int start = eventIds.Max();
                evt.Id = start + 1;
            }
            else
            {
                evt.Id = 1;
            }
            events.Add(evt);
            JsonFileWriter.WriteToJson(events, JsonFileName);
        }
        public void UpdateEmne (Emne @evt)
        {
            List<Emne> @events = GetAllEvents().ToList();

            if (evt != null)
            {
                foreach (var e in @events)
                {
                    if (e.Id == @evt.Id)
                    {
                        e.Id = evt.Id;
                        e.Indhold = evt.Indhold;
                    }
                }
            }
            JsonFileWriter.WriteToJson(events, JsonFileName);
        }
        public Emne GetEmne(int id)
        {
            foreach (var v in GetAllEvents())
            {
                if (v.Id == id)
                    return v;
            }
            return new Emne();
        }
        public List<Emne> FilterEmner(string indhold)
        {
            List<Emne> filteredList = new List<Emne>();
            List<Emne> @events = GetAllEvents().ToList();

            foreach (var ev in events)
            {
                if (ev.Indhold.Contains(indhold))
                {
                    filteredList.Add(ev);
                }
            }
            return filteredList;
        }
    }
}
