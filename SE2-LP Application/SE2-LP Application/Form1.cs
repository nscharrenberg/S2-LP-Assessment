using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SE2_LP_Application.Classes;
using SE2_LP_Application.DAL.DAO;
using SE2_LP_Application.DAL.Repository;

namespace SE2_LP_Application
{
    public partial class mainFrm : Form
    {
        static ElectionDao _eDao = new ElectionDao();
        ElectionRepository _er = new ElectionRepository(_eDao);

        public mainFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            electionList.FormattingEnabled = true;
            electionList.ValueMember = "id";
            electionList.DisplayMember = "name";
            electionList.DataSource = _er.GetAllElections();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void electionList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (electionList.CheckedItems.Count == 1)
            {
                Boolean isChecked = (e.CurrentValue == CheckState.Checked);
                if (isChecked)
                {
                    e.NewValue = CheckState.Checked;
                }
                else
                {
                    int checkItemIndex = electionList.CheckedIndices[0];
                    electionList.ItemCheck -= electionList_ItemCheck;
                    electionList.SetItemChecked(checkItemIndex, false);
                    electionList.ItemCheck += electionList_ItemCheck;
                }
            }
        }

        private void electionList_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((Election) e.ListItem).Name;
            int? seats = ((Election) e.ListItem).Seats;
            DateTime date = ((Election)e.ListItem).ElectionDate;
        }
    }
}
