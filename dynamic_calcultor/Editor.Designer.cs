namespace dynamic_calcultor
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFormulaView = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFormula = new System.Windows.Forms.RichTextBox();
            this.gridparam = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btndevide = new System.Windows.Forms.Button();
            this.btnStBracket = new System.Windows.Forms.Button();
            this.btnEdBracket = new System.Windows.Forms.Button();
            this.btnIIF = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnNumAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdFormulaList = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridparam)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFormulaList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFormulaView
            // 
            this.txtFormulaView.Location = new System.Drawing.Point(17, 20);
            this.txtFormulaView.Name = "txtFormulaView";
            this.txtFormulaView.Size = new System.Drawing.Size(601, 103);
            this.txtFormulaView.TabIndex = 0;
            this.txtFormulaView.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFormulaView);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formula";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFormula);
            this.groupBox2.Location = new System.Drawing.Point(12, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Formula(Code)";
            // 
            // txtFormula
            // 
            this.txtFormula.Location = new System.Drawing.Point(17, 20);
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.Size = new System.Drawing.Size(601, 103);
            this.txtFormula.TabIndex = 0;
            this.txtFormula.Text = "";
            // 
            // gridparam
            // 
            this.gridparam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridparam.Location = new System.Drawing.Point(10, 20);
            this.gridparam.Name = "gridparam";
            this.gridparam.RowTemplate.Height = 23;
            this.gridparam.Size = new System.Drawing.Size(259, 300);
            this.gridparam.TabIndex = 3;
            this.gridparam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridparam_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridparam);
            this.groupBox3.Location = new System.Drawing.Point(658, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 335);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Parameter";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(47, 13);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(107, 21);
            this.txtTitle.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "result_cell";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(14, 355);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPlus.TabIndex = 9;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(95, 355);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 10;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(177, 355);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnMultiple.TabIndex = 11;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btndevide
            // 
            this.btndevide.Location = new System.Drawing.Point(13, 384);
            this.btndevide.Name = "btndevide";
            this.btndevide.Size = new System.Drawing.Size(75, 23);
            this.btndevide.TabIndex = 12;
            this.btndevide.Text = "/";
            this.btndevide.UseVisualStyleBackColor = true;
            this.btndevide.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btnStBracket
            // 
            this.btnStBracket.Location = new System.Drawing.Point(95, 384);
            this.btnStBracket.Name = "btnStBracket";
            this.btnStBracket.Size = new System.Drawing.Size(75, 23);
            this.btnStBracket.TabIndex = 13;
            this.btnStBracket.Text = "(";
            this.btnStBracket.UseVisualStyleBackColor = true;
            this.btnStBracket.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btnEdBracket
            // 
            this.btnEdBracket.Location = new System.Drawing.Point(177, 384);
            this.btnEdBracket.Name = "btnEdBracket";
            this.btnEdBracket.Size = new System.Drawing.Size(75, 23);
            this.btnEdBracket.TabIndex = 14;
            this.btnEdBracket.Text = ")";
            this.btnEdBracket.UseVisualStyleBackColor = true;
            this.btnEdBracket.Click += new System.EventHandler(this.btn_Function_Click);
            // 
            // btnIIF
            // 
            this.btnIIF.Location = new System.Drawing.Point(14, 413);
            this.btnIIF.Name = "btnIIF";
            this.btnIIF.Size = new System.Drawing.Size(238, 23);
            this.btnIIF.TabIndex = 15;
            this.btnIIF.Text = "IIF()";
            this.btnIIF.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnNumAdd);
            this.groupBox4.Controls.Add(this.txtNumber);
            this.groupBox4.Location = new System.Drawing.Point(258, 355);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 52);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 20);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 21);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // btnNumAdd
            // 
            this.btnNumAdd.Location = new System.Drawing.Point(112, 19);
            this.btnNumAdd.Name = "btnNumAdd";
            this.btnNumAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNumAdd.TabIndex = 1;
            this.btnNumAdd.Text = "Add";
            this.btnNumAdd.UseVisualStyleBackColor = true;
            this.btnNumAdd.Click += new System.EventHandler(this.btnNumAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(577, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(577, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdFormulaList);
            this.groupBox5.Location = new System.Drawing.Point(14, 457);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(923, 170);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Formula List";
            // 
            // grdFormulaList
            // 
            this.grdFormulaList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFormulaList.Location = new System.Drawing.Point(15, 20);
            this.grdFormulaList.Name = "grdFormulaList";
            this.grdFormulaList.RowTemplate.Height = 23;
            this.grdFormulaList.Size = new System.Drawing.Size(898, 144);
            this.grdFormulaList.TabIndex = 0;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 639);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnIIF);
            this.Controls.Add(this.btnEdBracket);
            this.Controls.Add(this.btnStBracket);
            this.Controls.Add(this.btndevide);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridparam)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFormulaList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFormulaView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtFormula;
        private System.Windows.Forms.DataGridView gridparam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiple;
        private System.Windows.Forms.Button btndevide;
        private System.Windows.Forms.Button btnStBracket;
        private System.Windows.Forms.Button btnEdBracket;
        private System.Windows.Forms.Button btnIIF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnNumAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grdFormulaList;
    }
}