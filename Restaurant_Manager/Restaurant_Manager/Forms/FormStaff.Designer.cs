﻿namespace Restaurant_Manager.Forms
{
    partial class FormStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSaveStaff = new System.Windows.Forms.Button();
            this.dtStaffInfo = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btDelStaff = new System.Windows.Forms.Button();
            this.btUpdateStaff = new System.Windows.Forms.Button();
            this.btAddStaff = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalSal = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.btCreateStaff = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btSaveStaff);
            this.panel1.Controls.Add(this.dtStaffInfo);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.btDelStaff);
            this.panel1.Controls.Add(this.btUpdateStaff);
            this.panel1.Controls.Add(this.btAddStaff);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtTotalSal);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtBonus);
            this.panel1.Controls.Add(this.txtState);
            this.panel1.Controls.Add(this.cbPosition);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.dtBirthDay);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 651);
            this.panel1.TabIndex = 1;
            // 
            // btSaveStaff
            // 
            this.btSaveStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btSaveStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSaveStaff.Location = new System.Drawing.Point(211, 301);
            this.btSaveStaff.Name = "btSaveStaff";
            this.btSaveStaff.Size = new System.Drawing.Size(94, 29);
            this.btSaveStaff.TabIndex = 29;
            this.btSaveStaff.Text = "Save";
            this.btSaveStaff.UseVisualStyleBackColor = false;
            this.btSaveStaff.Click += new System.EventHandler(this.btSaveStaff_Click);
            // 
            // dtStaffInfo
            // 
            this.dtStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStaffInfo.Location = new System.Drawing.Point(11, 380);
            this.dtStaffInfo.Name = "dtStaffInfo";
            this.dtStaffInfo.RowHeadersWidth = 51;
            this.dtStaffInfo.RowTemplate.Height = 29;
            this.dtStaffInfo.Size = new System.Drawing.Size(547, 255);
            this.dtStaffInfo.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(464, 347);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 25;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(11, 347);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(447, 27);
            this.textBox7.TabIndex = 24;
            // 
            // btDelStaff
            // 
            this.btDelStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDelStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelStaff.Location = new System.Drawing.Point(411, 301);
            this.btDelStaff.Name = "btDelStaff";
            this.btDelStaff.Size = new System.Drawing.Size(94, 29);
            this.btDelStaff.TabIndex = 23;
            this.btDelStaff.Text = "Delete";
            this.btDelStaff.UseVisualStyleBackColor = false;
            // 
            // btUpdateStaff
            // 
            this.btUpdateStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btUpdateStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btUpdateStaff.Location = new System.Drawing.Point(311, 301);
            this.btUpdateStaff.Name = "btUpdateStaff";
            this.btUpdateStaff.Size = new System.Drawing.Size(94, 29);
            this.btUpdateStaff.TabIndex = 22;
            this.btUpdateStaff.Text = "Update";
            this.btUpdateStaff.UseVisualStyleBackColor = false;
            // 
            // btAddStaff
            // 
            this.btAddStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btAddStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAddStaff.Location = new System.Drawing.Point(111, 301);
            this.btAddStaff.Name = "btAddStaff";
            this.btAddStaff.Size = new System.Drawing.Size(94, 29);
            this.btAddStaff.TabIndex = 21;
            this.btAddStaff.Text = "Add";
            this.btAddStaff.UseVisualStyleBackColor = false;
            this.btAddStaff.Click += new System.EventHandler(this.btAddStaff_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(11, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtTotalSal
            // 
            this.txtTotalSal.Location = new System.Drawing.Point(385, 246);
            this.txtTotalSal.Name = "txtTotalSal";
            this.txtTotalSal.Size = new System.Drawing.Size(173, 27);
            this.txtTotalSal.TabIndex = 19;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20"});
            this.listBox1.Location = new System.Drawing.Point(487, 192);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(71, 24);
            this.listBox1.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(446, 195);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 17;
            this.label14.Text = "%";
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(382, 192);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(56, 27);
            this.txtBonus.TabIndex = 15;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(382, 137);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(176, 27);
            this.txtState.TabIndex = 14;
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Location = new System.Drawing.Point(382, 90);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(176, 28);
            this.cbPosition.TabIndex = 13;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 246);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 27);
            this.txtPhone.TabIndex = 12;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.Location = new System.Drawing.Point(88, 194);
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.Size = new System.Drawing.Size(146, 27);
            this.dtBirthDay.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 27);
            this.txtName.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(88, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 27);
            this.txtID.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(278, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Total Salary:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(278, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Bonus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(278, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "State:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(278, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Position:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 249);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Birth Day:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(3, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(168, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Staff Information";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.textBox9);
            this.panel2.Controls.Add(this.textBox8);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(598, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 307);
            this.panel2.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chartreuse;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(218, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Update";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkGray;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(66, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(80, 155);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(268, 27);
            this.textBox9.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(250, 94);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(98, 27);
            this.textBox8.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(119, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(98, 28);
            this.comboBox2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(15, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = "New Positon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Basic:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(122, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Position";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.textBox11);
            this.panel3.Controls.Add(this.textBox10);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.btCreateStaff);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(598, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 336);
            this.panel3.TabIndex = 3;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(131, 179);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(217, 27);
            this.textBox12.TabIndex = 8;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(132, 125);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(216, 27);
            this.textBox11.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(131, 78);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(126, 27);
            this.textBox10.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(17, 182);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 20);
            this.label17.TabIndex = 5;
            this.label17.Text = "Password:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(15, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "User Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(17, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 20);
            this.label15.TabIndex = 3;
            this.label15.Text = "Staff ID:";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Location = new System.Drawing.Point(219, 291);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(129, 29);
            this.button9.TabIndex = 2;
            this.button9.Text = "List account";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // btCreateStaff
            // 
            this.btCreateStaff.BackColor = System.Drawing.Color.Chartreuse;
            this.btCreateStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCreateStaff.Location = new System.Drawing.Point(131, 227);
            this.btCreateStaff.Name = "btCreateStaff";
            this.btCreateStaff.Size = new System.Drawing.Size(111, 37);
            this.btCreateStaff.TabIndex = 1;
            this.btCreateStaff.Text = "Create";
            this.btCreateStaff.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(122, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Account";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 666);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormStaff";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtStaffInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dtStaffInfo;
        private Button button5;
        private TextBox textBox7;
        private Button btDelStaff;
        private Button btUpdateStaff;
        private Button btAddStaff;
        private Button button1;
        private TextBox txtTotalSal;
        private ListBox listBox1;
        private Label label14;
        private TextBox txtBonus;
        private TextBox txtState;
        private ComboBox cbPosition;
        private TextBox txtPhone;
        private DateTimePicker dtBirthDay;
        private TextBox txtName;
        private TextBox txtID;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label4;
        private TextBox textBox8;
        private ComboBox comboBox2;
        private Label label13;
        private Label label1;
        private TextBox textBox9;
        private Button button7;
        private Button button6;
        private TextBox textBox12;
        private TextBox textBox11;
        private TextBox textBox10;
        private Label label17;
        private Label label16;
        private Label label15;
        private Button button9;
        private Button btCreateStaff;
        private Button btSaveStaff;
    }
}