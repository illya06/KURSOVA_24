namespace KURSOVA_24
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
            this.Mark = new System.Windows.Forms.TextBox();
            this.Power = new System.Windows.Forms.TextBox();
            this.FS = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FK = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Mark__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Power__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelSize__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FuelKm__ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.addLog = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sortC = new System.Windows.Forms.RadioButton();
            this.sortT = new System.Windows.Forms.RadioButton();
            this.sortM = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.down = new System.Windows.Forms.RadioButton();
            this.up = new System.Windows.Forms.RadioButton();
            this.sortByMark = new System.Windows.Forms.Button();
            this.showAll = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Find = new System.Windows.Forms.Button();
            this.findLog = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.consume = new System.Windows.Forms.RadioButton();
            this.size = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lAndT = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.border = new System.Windows.Forms.TextBox();
            this.noRefueling = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // Mark
            // 
            this.Mark.Location = new System.Drawing.Point(114, 40);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(102, 20);
            this.Mark.TabIndex = 0;
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(114, 92);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(102, 20);
            this.Power.TabIndex = 1;
            // 
            // FS
            // 
            this.FS.Location = new System.Drawing.Point(114, 118);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(102, 20);
            this.FS.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(114, 66);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(102, 20);
            this.Type.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Car type (0/1)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fuel tank size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Consumption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Horse power";
            // 
            // FK
            // 
            this.FK.Location = new System.Drawing.Point(114, 144);
            this.FK.Name = "FK";
            this.FK.Size = new System.Drawing.Size(102, 20);
            this.FK.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mark__,
            this.Type__,
            this.Power__,
            this.FuelSize__,
            this.FuelKm__});
            this.dataGridView1.Location = new System.Drawing.Point(139, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(426, 239);
            this.dataGridView1.TabIndex = 10;
            // 
            // Mark__
            // 
            this.Mark__.HeaderText = "Mark";
            this.Mark__.Name = "Mark__";
            this.Mark__.ReadOnly = true;
            // 
            // Type__
            // 
            this.Type__.HeaderText = "Car type";
            this.Type__.Name = "Type__";
            this.Type__.ReadOnly = true;
            // 
            // Power__
            // 
            this.Power__.HeaderText = "Horse power";
            this.Power__.Name = "Power__";
            this.Power__.ReadOnly = true;
            // 
            // FuelSize__
            // 
            this.FuelSize__.HeaderText = "Fuel tank size";
            this.FuelSize__.Name = "FuelSize__";
            this.FuelSize__.ReadOnly = true;
            // 
            // FuelKm__
            // 
            this.FuelKm__.HeaderText = "Consumption";
            this.FuelKm__.Name = "FuelKm__";
            this.FuelKm__.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(38, 170);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(178, 38);
            this.Add.TabIndex = 11;
            this.Add.Text = "SUBMIT";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 287);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.addLog);
            this.tabPage1.Controls.Add(this.Mark);
            this.tabPage1.Controls.Add(this.Add);
            this.tabPage1.Controls.Add(this.Power);
            this.tabPage1.Controls.Add(this.FS);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.Type);
            this.tabPage1.Controls.Add(this.FK);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "0 - LIGHTWEIGHT | 1 - TRUCK";
            // 
            // addLog
            // 
            this.addLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addLog.Location = new System.Drawing.Point(222, 38);
            this.addLog.Name = "addLog";
            this.addLog.Size = new System.Drawing.Size(334, 170);
            this.addLog.TabIndex = 12;
            this.addLog.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.sortByMark);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.showAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SORT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sortC);
            this.groupBox3.Controls.Add(this.sortT);
            this.groupBox3.Controls.Add(this.sortM);
            this.groupBox3.Location = new System.Drawing.Point(20, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(113, 73);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sort by : ";
            // 
            // sortC
            // 
            this.sortC.AutoSize = true;
            this.sortC.Location = new System.Drawing.Point(6, 51);
            this.sortC.Name = "sortC";
            this.sortC.Size = new System.Drawing.Size(79, 17);
            this.sortC.TabIndex = 14;
            this.sortC.TabStop = true;
            this.sortC.Text = "consumtion";
            this.sortC.UseVisualStyleBackColor = true;
            // 
            // sortT
            // 
            this.sortT.AutoSize = true;
            this.sortT.Location = new System.Drawing.Point(6, 32);
            this.sortT.Name = "sortT";
            this.sortT.Size = new System.Drawing.Size(63, 17);
            this.sortT.TabIndex = 13;
            this.sortT.TabStop = true;
            this.sortT.Text = "car type";
            this.sortT.UseVisualStyleBackColor = true;
            // 
            // sortM
            // 
            this.sortM.AutoSize = true;
            this.sortM.Location = new System.Drawing.Point(6, 13);
            this.sortM.Name = "sortM";
            this.sortM.Size = new System.Drawing.Size(48, 17);
            this.sortM.TabIndex = 12;
            this.sortM.TabStop = true;
            this.sortM.Text = "mark";
            this.sortM.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.down);
            this.groupBox1.Controls.Add(this.up);
            this.groupBox1.Location = new System.Drawing.Point(20, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 36);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // down
            // 
            this.down.AutoSize = true;
            this.down.Location = new System.Drawing.Point(56, 13);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(51, 17);
            this.down.TabIndex = 13;
            this.down.TabStop = true;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            // 
            // up
            // 
            this.up.AutoSize = true;
            this.up.Location = new System.Drawing.Point(6, 13);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(37, 17);
            this.up.TabIndex = 12;
            this.up.TabStop = true;
            this.up.Text = "up";
            this.up.UseVisualStyleBackColor = true;
            // 
            // sortByMark
            // 
            this.sortByMark.Location = new System.Drawing.Point(20, 53);
            this.sortByMark.Name = "sortByMark";
            this.sortByMark.Size = new System.Drawing.Size(113, 34);
            this.sortByMark.TabIndex = 11;
            this.sortByMark.Text = "SORT";
            this.sortByMark.UseVisualStyleBackColor = true;
            this.sortByMark.Click += new System.EventHandler(this.sortByMark_Click);
            // 
            // showAll
            // 
            this.showAll.Location = new System.Drawing.Point(20, 13);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(54, 34);
            this.showAll.TabIndex = 0;
            this.showAll.Text = "SHOW";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.Click += new System.EventHandler(this.showAll_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.findLog);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.Find);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "FIND";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(89, 86);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(113, 34);
            this.Find.TabIndex = 15;
            this.Find.Text = "FIND BY";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // findLog
            // 
            this.findLog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.findLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.findLog.Location = new System.Drawing.Point(262, 6);
            this.findLog.Name = "findLog";
            this.findLog.Size = new System.Drawing.Size(197, 239);
            this.findLog.TabIndex = 14;
            this.findLog.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.consume);
            this.groupBox2.Controls.Add(this.size);
            this.groupBox2.Location = new System.Drawing.Point(89, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Find min max by :  ";
            // 
            // consume
            // 
            this.consume.AutoSize = true;
            this.consume.Location = new System.Drawing.Point(6, 38);
            this.consume.Name = "consume";
            this.consume.Size = new System.Drawing.Size(79, 17);
            this.consume.TabIndex = 14;
            this.consume.Text = "consumtion";
            this.consume.UseVisualStyleBackColor = true;
            this.consume.CheckedChanged += new System.EventHandler(this.consume_CheckedChanged);
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Checked = true;
            this.size.Location = new System.Drawing.Point(6, 19);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(87, 17);
            this.size.TabIndex = 13;
            this.size.TabStop = true;
            this.size.Text = "fuel tank size";
            this.size.UseVisualStyleBackColor = true;
            this.size.CheckedChanged += new System.EventHandler(this.size_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lAndT);
            this.groupBox4.Location = new System.Drawing.Point(89, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 45);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Find by :  ";
            // 
            // lAndT
            // 
            this.lAndT.AutoSize = true;
            this.lAndT.Checked = true;
            this.lAndT.Location = new System.Drawing.Point(6, 19);
            this.lAndT.Name = "lAndT";
            this.lAndT.Size = new System.Drawing.Size(97, 17);
            this.lAndT.TabIndex = 13;
            this.lAndT.TabStop = true;
            this.lAndT.Text = "light and trucks";
            this.lAndT.UseVisualStyleBackColor = true;
            this.lAndT.CheckedChanged += new System.EventHandler(this.lAndT_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Controls.Add(this.border);
            this.tabPage4.Controls.Add(this.noRefueling);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(588, 261);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "#4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // border
            // 
            this.border.Location = new System.Drawing.Point(66, 75);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(59, 20);
            this.border.TabIndex = 16;
            // 
            // noRefueling
            // 
            this.noRefueling.Location = new System.Drawing.Point(10, 127);
            this.noRefueling.Name = "noRefueling";
            this.noRefueling.Size = new System.Drawing.Size(115, 39);
            this.noRefueling.TabIndex = 18;
            this.noRefueling.Text = "NO REFUELING";
            this.noRefueling.UseVisualStyleBackColor = true;
            this.noRefueling.Click += new System.EventHandler(this.hasAllTypes_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Consumption";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Fuel tank size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Horse power";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Car type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mark";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView2.Location = new System.Drawing.Point(156, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ShowCellErrors = false;
            this.dataGridView2.ShowCellToolTips = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.ShowRowErrors = false;
            this.dataGridView2.Size = new System.Drawing.Size(426, 249);
            this.dataGridView2.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "BORDER :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 285);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Mark;
        private System.Windows.Forms.TextBox Power;
        private System.Windows.Forms.TextBox FS;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox addLog;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button showAll;
        private System.Windows.Forms.RadioButton down;
        private System.Windows.Forms.RadioButton up;
        private System.Windows.Forms.Button sortByMark;
        private System.Windows.Forms.RichTextBox findLog;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mark__;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type__;
        private System.Windows.Forms.DataGridViewTextBoxColumn Power__;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelSize__;
        private System.Windows.Forms.DataGridViewTextBoxColumn FuelKm__;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton sortC;
        private System.Windows.Forms.RadioButton sortT;
        private System.Windows.Forms.RadioButton sortM;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton consume;
        private System.Windows.Forms.RadioButton size;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton lAndT;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox border;
        private System.Windows.Forms.Button noRefueling;
    }
}

