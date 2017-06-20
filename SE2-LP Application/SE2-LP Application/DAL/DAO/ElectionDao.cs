using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SE2_LP_Application.Classes;
using SE2_LP_Application.DAL.Interface;

namespace SE2_LP_Application.DAL.DAO
{
    class ElectionDao : IElectionInterface
    {
        SqlDataAccessObject _sqlDao = new SqlDataAccessObject();
        public List<Election> _elections = new List<Election>();

        public List<Election> GetAllElections()
        {
            string allElectionsQuery = "SELECT * FROM Election";
            DataTable elections = _sqlDao.Execute(allElectionsQuery);

            foreach (DataRow dr in elections.Rows)
            {
                if (dr["seats"].ToString() == "")
                {
                    _elections.Add(new Election((int) dr["id"], dr["name"].ToString(),
                        Convert.ToDateTime(dr["electionDate"])));
                }
                else
                {
                    _elections.Add(new Election((int)dr["id"], dr["name"].ToString(), (int)dr["seats"], Convert.ToDateTime(dr["electionDate"])));
                }
                
            }

            return _elections;
        }
    }
}
