using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model;

namespace DesafioBraspag.Repository.Interfaces
{
    public interface IMdrRepository
    {
        List<MDR> RetornarMDR();
    }
}
