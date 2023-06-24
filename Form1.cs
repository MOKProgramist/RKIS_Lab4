using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RKIS_Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ModelEF database = new ModelEF();

        List<Pavilion> pavilions = new List<Pavilion>();
        List<Pavilion> PavilionsChange = new List<Pavilion>();
        List<string> povilionsProp = new List<string>();
         
        private void LoadStartData()
        {
            pavilionBindingSource.DataSource = PavilionsChange;
        }

        private void LoadDataCombo() {

            povilionsProp = typeof(Pavilion).GetProperties().Select((x) => x.Name).ToList();
            povilionsProp.RemoveRange(povilionsProp.Count - 2, 2);

            comboBoxOrderBy.DataSource = povilionsProp;

            comboBoxOrderBy.SelectedIndex = 0;

        }

        private void LoadOrder()
        {
            if(checkBox1.Checked)
            {
                PavilionsChange = PavilionsChange.OrderByDescending(p => p.GetType().GetProperties().First(x => x.Name == comboBoxOrderBy.SelectedItem.ToString()).GetValue(p)).ToList();
            } else
            {
                PavilionsChange = PavilionsChange.OrderByDescending(p => p.GetType().GetProperties().First(x => x.Name == comboBoxOrderBy.SelectedItem.ToString()).GetValue(p)).ToList();
            }
            LoadStartData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PavilionsChange = pavilions = database.Pavilion.ToList();

            LoadStartData();
            LoadDataCombo();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            PavilionsChange = pavilions.Where(x => x.Status.ToLower().Contains(textBox1.Text.ToLower())).ToList();

            LoadOrder();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }

        private void comboBoxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
