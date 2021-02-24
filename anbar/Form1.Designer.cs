namespace anbar
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.malinHereketiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cixisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barkodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eUROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromBaseToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.proaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.d1DataSet = new anbar.d1DataSet();
            this.pro_aTableAdapter = new anbar.d1DataSetTableAdapters.pro_aTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qiymetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miqdarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.malinHereketiToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.exchangeToolStripMenuItem,
            this.fromBaseToFileToolStripMenuItem,
            this.fromFileToBaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // malinHereketiToolStripMenuItem
            // 
            this.malinHereketiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisToolStripMenuItem,
            this.cixisToolStripMenuItem});
            this.malinHereketiToolStripMenuItem.Name = "malinHereketiToolStripMenuItem";
            this.malinHereketiToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.malinHereketiToolStripMenuItem.Text = "malin hereketi";
            this.malinHereketiToolStripMenuItem.Click += new System.EventHandler(this.malinHereketiToolStripMenuItem_Click);
            // 
            // girisToolStripMenuItem
            // 
            this.girisToolStripMenuItem.Name = "girisToolStripMenuItem";
            this.girisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.girisToolStripMenuItem.Text = "Giris";
            this.girisToolStripMenuItem.Click += new System.EventHandler(this.girisToolStripMenuItem_Click);
            // 
            // cixisToolStripMenuItem
            // 
            this.cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            this.cixisToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cixisToolStripMenuItem.Text = "Cixis";
            this.cixisToolStripMenuItem.Click += new System.EventHandler(this.cixisToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barkodToolStripMenuItem,
            this.tarixToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // barkodToolStripMenuItem
            // 
            this.barkodToolStripMenuItem.Name = "barkodToolStripMenuItem";
            this.barkodToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.barkodToolStripMenuItem.Text = "Barkod";
            this.barkodToolStripMenuItem.Click += new System.EventHandler(this.barkodToolStripMenuItem_Click);
            // 
            // tarixToolStripMenuItem
            // 
            this.tarixToolStripMenuItem.Name = "tarixToolStripMenuItem";
            this.tarixToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tarixToolStripMenuItem.Text = "Tarix";
            this.tarixToolStripMenuItem.Click += new System.EventHandler(this.tarixToolStripMenuItem_Click);
            // 
            // exchangeToolStripMenuItem
            // 
            this.exchangeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSDToolStripMenuItem,
            this.eUROToolStripMenuItem});
            this.exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            this.exchangeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.exchangeToolStripMenuItem.Text = "Exchange";
            // 
            // uSDToolStripMenuItem
            // 
            this.uSDToolStripMenuItem.Name = "uSDToolStripMenuItem";
            this.uSDToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.uSDToolStripMenuItem.Text = "USD";
            this.uSDToolStripMenuItem.Click += new System.EventHandler(this.uSDToolStripMenuItem_Click);
            // 
            // eUROToolStripMenuItem
            // 
            this.eUROToolStripMenuItem.Name = "eUROToolStripMenuItem";
            this.eUROToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eUROToolStripMenuItem.Text = "EURO";
            this.eUROToolStripMenuItem.Click += new System.EventHandler(this.eUROToolStripMenuItem_Click_1);
            // 
            // fromBaseToFileToolStripMenuItem
            // 
            this.fromBaseToFileToolStripMenuItem.Name = "fromBaseToFileToolStripMenuItem";
            this.fromBaseToFileToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.fromBaseToFileToolStripMenuItem.Text = "FromBaseToFile";
            this.fromBaseToFileToolStripMenuItem.Click += new System.EventHandler(this.fromBaseToFileToolStripMenuItem_Click);
            // 
            // fromFileToBaseToolStripMenuItem
            // 
            this.fromFileToBaseToolStripMenuItem.Name = "fromFileToBaseToolStripMenuItem";
            this.fromFileToBaseToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.fromFileToBaseToolStripMenuItem.Text = "FromFileToBase";
            this.fromFileToBaseToolStripMenuItem.Click += new System.EventHandler(this.fromFileToBaseToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 288);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(180, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(44, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(44, 188);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(44, 162);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(44, 133);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Vergi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "U.mebleg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Miqdar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Qiymet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Malin adi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(221, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 302);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 152);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Satiw";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 124);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Aliw";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Brown;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(172, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(32, 26);
            this.button5.TabIndex = 5;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(40, 83);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 4;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(40, 57);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Satis";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Alis";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CadetBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(24, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 49);
            this.button4.TabIndex = 0;
            this.button4.Text = "CHANGE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CadetBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(387, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "off";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(270, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(111, 20);
            this.textBox8.TabIndex = 3;
            // 
            // proaBindingSource
            // 
            this.proaBindingSource.DataMember = "pro_a";
            this.proaBindingSource.DataSource = this.d1DataSet;
            // 
            // d1DataSet
            // 
            this.d1DataSet.DataSetName = "d1DataSet";
            this.d1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pro_aTableAdapter
            // 
            this.pro_aTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barkodDataGridViewTextBoxColumn,
            this.malDataGridViewTextBoxColumn,
            this.tarixDataGridViewTextBoxColumn,
            this.qiymetDataGridViewTextBoxColumn,
            this.miqdarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(270, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 84);
            this.dataGridView1.TabIndex = 4;
            // 
            // barkodDataGridViewTextBoxColumn
            // 
            this.barkodDataGridViewTextBoxColumn.DataPropertyName = "Barkod";
            this.barkodDataGridViewTextBoxColumn.HeaderText = "Barkod";
            this.barkodDataGridViewTextBoxColumn.Name = "barkodDataGridViewTextBoxColumn";
            // 
            // malDataGridViewTextBoxColumn
            // 
            this.malDataGridViewTextBoxColumn.DataPropertyName = "mal";
            this.malDataGridViewTextBoxColumn.HeaderText = "mal";
            this.malDataGridViewTextBoxColumn.Name = "malDataGridViewTextBoxColumn";
            // 
            // tarixDataGridViewTextBoxColumn
            // 
            this.tarixDataGridViewTextBoxColumn.DataPropertyName = "Tarix";
            this.tarixDataGridViewTextBoxColumn.HeaderText = "Tarix";
            this.tarixDataGridViewTextBoxColumn.Name = "tarixDataGridViewTextBoxColumn";
            // 
            // qiymetDataGridViewTextBoxColumn
            // 
            this.qiymetDataGridViewTextBoxColumn.DataPropertyName = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.HeaderText = "qiymet";
            this.qiymetDataGridViewTextBoxColumn.Name = "qiymetDataGridViewTextBoxColumn";
            // 
            // miqdarDataGridViewTextBoxColumn
            // 
            this.miqdarDataGridViewTextBoxColumn.DataPropertyName = "miqdar";
            this.miqdarDataGridViewTextBoxColumn.HeaderText = "miqdar";
            this.miqdarDataGridViewTextBoxColumn.Name = "miqdarDataGridViewTextBoxColumn";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 394);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "del all";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(84, 378);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 47);
            this.button7.TabIndex = 7;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1021, 439);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "anbar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem malinHereketiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cixisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barkodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exchangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eUROToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox8;
        private d1DataSet d1DataSet;
        private System.Windows.Forms.BindingSource proaBindingSource;
        private d1DataSetTableAdapters.pro_aTableAdapter pro_aTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem fromBaseToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToBaseToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn barkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qiymetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miqdarDataGridViewTextBoxColumn;
    }
}

