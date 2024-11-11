using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            DataTable dt = edit.dtFormulaList.Copy();
            grdFormulaList.DataSource = dt;

            InitComboBoxInCell();
            
        }

        private void InitComboBoxInCell(int? rowIdx =null)
        {
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            cell.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            cell.DataSource = grdFormulaList.DataSource;
            cell.ValueMember = "Formula";
            cell.DisplayMember = "TITLE";

            if (rowIdx == null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells["funtiontitle"] = cell;
                }
            }
            else
            {
                try
                {
                    int k = rowIdx.Value;
                    dataGridView1.Rows[k].Cells["funtiontitle"] = cell;
                }
                catch (Exception ex)
                {
                }

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitDataSource();

        }

        private void InitDataSource()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("funtiontitle");
            dt.Columns.Add("width");
            dt.Columns.Add("height");
            //dt.Columns.Add("formula");
            //dt.Columns.Add("formulaView");
            dt.Columns.Add("RESULT");
            dt.Columns.Add("RESULT2");
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["funtiontitle"].HeaderText = "공식";
            dataGridView1.Columns["width"].HeaderText = "가로";
            dataGridView1.Columns["height"].HeaderText = "세로";
            //dataGridView1.Columns["formula"].HeaderText = "공식(코드)";
            //dataGridView1.Columns["formulaView"].HeaderText = "공식";
            dataGridView1.Columns["RESULT"].HeaderText = "결과";
            dataGridView1.Columns["RESULT2"].HeaderText = "결과2";
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            try
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string stringFormular = row.Cells["funtiontitle"].Value.ToString();
                
                string resultCol = GetResultColumn(row.Cells["funtiontitle"]);
                foreach (string col in getColListByCalc(stringFormular))
                {
                    string val = row.Cells[col].Value.ToString();
                    stringFormular = stringFormular.Replace($"[{col}]", val);
                }
                DataTable dtTempForCalc = new DataTable();
                var result = dtTempForCalc.Compute(stringFormular, "");
                dataGridView1.CellValueChanged-= dataGridView1_CellValueChanged;
                row.Cells[resultCol].Value = result;
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            }
            catch (Exception ex) { }
        }

        private string GetResultColumn(DataGridViewCell title)
        {
            var comboBoxCell = title as DataGridViewComboBoxCell;
            string titleName = "";
            if (comboBoxCell != null && comboBoxCell.Value != null)
            {
                // 콤보박스의 Value 값
                var selectedValue = comboBoxCell.Value;

                // DisplayMember와 ValueMember 사용하여 Display 값을 찾음
                var displayValue = comboBoxCell.Items
                    .Cast<DataRowView>()
                    .FirstOrDefault(item => item[comboBoxCell.ValueMember].Equals(selectedValue))?[comboBoxCell.DisplayMember];
                
                titleName = displayValue.ToString();
            }
            
            string result = "";
            DataTable dt = (DataTable)grdFormulaList.DataSource;
            var rows = dt.Select($"title = '{titleName}'");
            if (rows.Count() > 0)
            {
                result = rows[0]["RESULTCELL"].ToString();
                    
            }
            
            return result;
        }

        private List<string> getColListByCalc(string strCalc)
        {
            List<string> result = new List<string>();
            Regex regex = new Regex(@"\[(.*?)\]");
            MatchCollection matches = regex.Matches(strCalc);

            foreach (Match match in matches)
            {
                result.Add(match.Groups[1].Value);
            }

            return result;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (e.RowIndex < 0) return;
            InitComboBoxInCell(e.RowIndex);
        }
    }
}
