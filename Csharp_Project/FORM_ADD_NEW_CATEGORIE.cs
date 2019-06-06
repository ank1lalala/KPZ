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
    public partial class FORM_ADD_NEW_CATEGORIE : Form
    {
        DB db = new DB();
        Categorie category = new Categorie();
        public FORM_ADD_NEW_CATEGORIE()
        {
            InitializeComponent();
            
        }

        // add new categorie
        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            if(TB_CATEGORY_NAME.Text != string.Empty)
            {
                db.openConnection();
                category.insertCategory(TB_CATEGORY_NAME.Text);
                MessageBox.Show("New Category Inserted Successfully", "Insert Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("Enter The Categorie Name");
            }
            
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_MIN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
