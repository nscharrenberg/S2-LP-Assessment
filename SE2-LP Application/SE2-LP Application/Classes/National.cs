using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_LP_Application.Classes
{
    public class National : Election
    {
        public Coalition Coalition { get; set; }

        public National(int id, string name, int seats, DateTime electionDate) : base(id, name, seats, electionDate)
        {

        }

        public National(int id, string name, int seats, DateTime electionDate, Coalition coalition) : base(id, name, seats, electionDate)
        {
            this.Coalition = coalition;
        }
    }
}
