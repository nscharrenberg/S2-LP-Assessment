using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_LP_Application.Classes;

namespace SE2_LP_Application.DAL.Interface
{
    public interface IElectionInterface
    {
        List<Election> GetAllElections();
    }
}
