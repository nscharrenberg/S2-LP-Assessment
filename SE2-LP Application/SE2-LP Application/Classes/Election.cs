using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2_LP_Application.Classes
{
    public class Election
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Seats { get; set; }
        public DateTime ElectionDate { get; set; }

        public Election(int id, string name, int seats, DateTime electionDate)
        {
            Id = id;
            Name = name;
            Seats = seats;
            ElectionDate = electionDate;
        }

        public Election(int id, string name, DateTime electionDate)
        {
            Id = id;
            Name = name;
            ElectionDate = electionDate;
        }
    }
}
