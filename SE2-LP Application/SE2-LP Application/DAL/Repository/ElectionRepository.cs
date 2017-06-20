using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_LP_Application.Classes;
using SE2_LP_Application.DAL.DAO;
using SE2_LP_Application.DAL.Interface;

namespace SE2_LP_Application.DAL.Repository
{
    class ElectionRepository
    {
        private IElectionInterface Context;

        public ElectionRepository(IElectionInterface context)
        {
            this.Context = context;
        }

        public Election[] GetAllElections()
        {
            return Context.GetAllElections().ToArray();
        }
    }
}
