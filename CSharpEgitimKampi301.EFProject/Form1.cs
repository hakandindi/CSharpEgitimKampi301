using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e){}

        EgitimKampiEFTravelDbEntities db = new EgitimKampiEFTravelDbEntities();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.Guides.Find(id);
            updatedValue.GuideName = txtName.Text;
            updatedValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Başarıyla güncellendi!", "Uyarı", MessageBoxButtons.OK);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var value = db.Guides.Where(x => x.GuideId == id).ToList(); // **
            dataGridView1.DataSource = value;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname = txtSurname.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Eklendi!", "Uyarı", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var removedValue = db.Guides.Find(id);
            db.Guides.Remove(removedValue);
            db.SaveChanges();
            MessageBox.Show("Başarıyla Silindi!", "Uyarı", MessageBoxButtons.OK);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtSurname_TextChanged(object sender, EventArgs e) { }

        private void txtName_TextChanged(object sender, EventArgs e) { }

        private void txtId_TextChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
