using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE2_LP_Application.Classes
{
    public class Coalition
    {
        public int Id { get; set; }
        public Candidate Candidate { get; set; }
        public List<Faction> Factions { get; set; }
        public List<Result> Results { get; set; }
    }
}
