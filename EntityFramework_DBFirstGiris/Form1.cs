using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_DBFirstGiris
{
    public partial class Form1 : Form
    {
        NorthwindEntities db = new NorthwindEntities();
        public Form1()
        {
            InitializeComponent();
            //dgvProducts.DataSource = db.Products.ToList();
            //dgvProducts.DataSource = db.Products.Where(x=>x.CategoryID == 1).ToList(); // kategori id 1 olanlar...

            //dgvProducts.DataSource = db.Products.
            //    Where(x => x.CategoryID == 1).
            //    OrderByDescending(x => x.UnitPrice).
            //    ToList();   // hadi buyur

            cboCategory.DataSource = db.Categories.ToList();
        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedIndex == -1)
            {
                dgvProducts.DataSource = null;
                return;    
            }
            else
            {
                Category category = (Category)cboCategory.SelectedItem;
                dgvProducts.DataSource = category.Products.ToList();
            }

        }
    }
}
