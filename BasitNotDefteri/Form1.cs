using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasitNotDefteri
{
    public partial class Form1 : Form
    {
        BasitNotDefteriDbEntities db = new BasitNotDefteriDbEntities();

        public Form1()
        {
            InitializeComponent();

            lstNotlar.DataSource = db.Nots.ToList();
        }

        private void lstNotlar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedValue != null)
            {
                // Not not = (Not)lstNotlar.SelectedItem;   böyle de yapabilirsin...
                int seciliId = (int)lstNotlar.SelectedValue;
                pnlNot.Show();
                txtBaslik.Text = db.Nots.First(x => x.Id == seciliId).Baslik;
                txtNot.Text = db.Nots.First(x => x.Id == seciliId).Icerik;
            }
            else
            {
                pnlNot.Hide();
                txtBaslik.Text = "";
                txtNot.Text = "";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Not yeniNot = (Not)lstNotlar.SelectedItem;

            if (!string.IsNullOrEmpty(txtBaslik.Text) &&
                !string.IsNullOrEmpty(txtNot.Text) &&
                yeniNot.Baslik == "Yeni Not")
            {
                yeniNot.Baslik = txtBaslik.Text.Trim();
                yeniNot.Icerik = txtNot.Text.Trim();
                db.SaveChanges();
                lstNotlar.DataSource = db.Nots.ToList();
                lstNotlar.SelectedItem = yeniNot;
            }
            else
            {
                MessageBox.Show("Başlık veya içerik boş olamaz...");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedIndex == -1)
                return;
            Not not = (Not)lstNotlar.SelectedItem;
            db.Nots.Remove(not);
            db.SaveChanges();
            lstNotlar.DataSource = db.Nots.ToList();

            if (lstNotlar.Items.Count < 1)
                pnlNot.Hide();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Not yeniNot = new Not() { Baslik = "Yeni Not" };
            db.Nots.Add(yeniNot);
            db.SaveChanges();
            lstNotlar.DataSource = db.Nots.ToList();
            lstNotlar.SelectedItem = yeniNot;
        }
    }
}
