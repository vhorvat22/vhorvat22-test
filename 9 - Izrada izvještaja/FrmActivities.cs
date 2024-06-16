using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmActivities : Form
    {
        public FrmActivities()
        {
            InitializeComponent();
        }

        private void FrmActivities_Load(object sender, EventArgs e)
        {
            dgvActivities.DataSource = ActivityRepository.GetActivities();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
