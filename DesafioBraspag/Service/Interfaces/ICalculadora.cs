using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBraspag.Model;

namespace DesafioBraspag.Service.Interfaces
{
    public interface ICalculadora
    {
        double CalcularTaxa(Transacao transacao);

    }
}
