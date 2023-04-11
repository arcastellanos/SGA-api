using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGA_api.Interface
{
    public interface IReadManagers
    {
        public List<Manager> GetAllManagers();
    }
}