using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_calcultor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenEditor_Click(object sender, EventArgs e)
        {
            Editor edit = new Editor(dataGridView1);
            edit.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitDataSource();

        }

        private void InitDataSource()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("diagram");
            dt.Columns.Add("width");
            dt.Columns.Add("height");
            dt.Columns.Add("formula");
            dt.Columns.Add("formulaView");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["diagram"].HeaderText = "도형";
            dataGridView1.Columns["width"].HeaderText = "가로";
            dataGridView1.Columns["height"].HeaderText = "세로";
            dataGridView1.Columns["formula"].HeaderText = "공식(코드)";
            dataGridView1.Columns["formulaView"].HeaderText = "공식";
        }
    }
}
