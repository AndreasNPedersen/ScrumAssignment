using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SCRUMAssignment.Models;

namespace SCRUMAssignment.Interfaces
{
    public interface IEventRepository
    {
        List<Emne> GetAllEvents();
        Emne GetEmne(int id);

        void AddEmne(Emne ev);
        void UpdateEmne(Emne evt);
    }
}
