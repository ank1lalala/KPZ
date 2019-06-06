using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Csharp_Project
{
    public partial class FORM_NEW_PRODUCT : Form
    {
        Categorie catg = new Categorie();
        Product product = new Product();


        public FORM_NEW_PRODUCT()
        {
            InitializeComponent();
            loadComboCategory();
        }

        public void loadComboCategory()
        {
            COMBO_CATEGORIES.DataSource = catg.getCategories();
            COMBO_CATEGORIES.DisplayMember = "CAT_NAME";
            COMBO_CATEGORIES.ValueMember = "CAT_ID";
        }

        private void PB_BROWSE_IMAGE_Click(object sender, EventArgs e)
        {

            OpenFileDialog ImagefileDialog = new OpenFileDialog();
            ImagefileDialog.Filter = "Image |*.JPG; *.PNG; *.GIF";
            if(ImagefileDialog.ShowDialog() == DialogResult.OK)
            {
                PB_BROWSE_IMAGE.Image = Image.FromFile(ImagefileDialog.FileName);
            }
        }

        private void PANEL_CLOSE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PANEL_ADD_PRODUCT_Click(object sender, EventArgs e)
        {
            
            
        }

        private void TB_QUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void TB_PRICE_KeyPress(object sender, KeyPressEventArgs e)
        {
            char separator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != separator)
            {
                e.Handled = true;
            }
        }

        private void BTN_ADD_CATEGORY_Click(object sender, EventArgs e)
        {
            FORM_ADD_NEW_CATEGORIE faddc = new FORM_ADD_NEW_CATEGORIE();
            faddc.ShowDialog();
            loadComboCategory();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            if (TB_NAME.Text == string.Empty)
            {
                MessageBox.Show("Enter The Product Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (TB_PRICE.Text == string.Empty && TB_QUANTITY.Text == string.Empty)
            {
                MessageBox.Show("Quantity and Price Can't Be Empty | But Can Be Equal To 0", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PB_BROWSE_IMAGE.Image == null)
            {
                MessageBox.Show("No Image Selected", "No Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                MemoryStream ms = new MemoryStream();
                PB_BROWSE_IMAGE.Image.Save(ms, PB_BROWSE_IMAGE.Image.RawFormat);
                byte[] image = ms.ToArray();

                product.insertProduct(Convert.ToInt32(COMBO_CATEGORIES.SelectedValue), TB_NAME.Text,
                                     TB_PRICE.Text, image, Convert.ToInt32(TB_QUANTITY.Text), TB_DESCRIPTION.Text);
                MessageBox.Show("New Product Inserted Successfully", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void FORM_NEW_PRODUCT_Load(object sender, EventArgs e)
        {

        }
    }
}
