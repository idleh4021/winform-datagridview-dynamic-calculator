using Microsoft.VisualBasic;
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
    public partial class Editor : Form
    {
        DataGridView _src_grd;
        public Editor(DataGridView grid)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            _src_grd = grid;
            txtFormula.ReadOnly = txtFormulaView.ReadOnly = true;
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            dt.Columns.Add("Name");
            dt.Columns.Add("Code");
            foreach (DataGridViewColumn col in _src_grd.Columns)
            {
                dt.Rows.Add(col.HeaderText,col.Name);
            }
            gridparam.DataSource = dt;

            DataTable dtCombo = dt.Copy();
            comboBox1.DataSource = dtCombo;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Code";

            gridparam.ReadOnly = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ControlChars.Back && e.KeyChar != '.' && e.KeyChar != ',')
                {
                    //cancel key
                    e.Handled = true;
                }
        }

        private void AddFormularParam(string code,string name =null)
        {
            txtFormula.Text += " " + code;
            txtFormulaView.Text += " " + ((name == null) ? code : name);
        }

        private void btnNumAdd_Click(object sender, EventArgs e)
        {
            AddFormularParam(txtNumber.Text);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            AddFormularParam("+");
        }

        private void btn_Function_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            AddFormularParam(btn.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFormula.Text = txtFormulaView.Text = string.Empty;
        }

        private void gridparam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow selectedRow = gridparam.Rows[e.RowIndex];
            string code = $"[{selectedRow.Cells["CODE"].Value.ToString()}]";
            string name = $"[{selectedRow.Cells["NAME"].Value.ToString()}]";
            AddFormularParam(code,name);

        }
    }
}
