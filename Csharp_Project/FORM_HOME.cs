using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Project
{
    public partial class FORM_HOME : Form
    {
        public string userType;
        public FORM_HOME()
        {
            InitializeComponent();
 
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CATEGORIES fmcg = new FORM_MANAGE_CATEGORIES();
            fmcg.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_CUSTOMER fmcm = new FORM_MANAGE_CUSTOMER();
            fmcm.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_ORDER fmo = new FORM_MANAGE_ORDER();
            fmo.ShowDialog();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_USER fmus = new FORM_MANAGE_USER();
            fmus.ShowDialog();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_MANAGE_PRODUCT fmp = new FORM_MANAGE_PRODUCT();
            fmp.ShowDialog();
        }
    }
}
