using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_LP_Application.Classes
{
    class Faction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Votes { get; set; }
        public Candidate Candidate { get; set; }
        public List<Coalition> Coalitions { get; set; }
    }
}
