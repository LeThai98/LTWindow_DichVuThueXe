namespace ChamSocVaGuiXe
{
    partial class fCostFineMoto
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.bikeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamSocVaGuiXeDataSet2 = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxOwner = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBoxMoto = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownTimeRent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxFine = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.bikeTableAdapter = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet2TableAdapters.BikeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoto)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeRent)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelFirstName.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSearch.Location = new System.Drawing.Point(348, 7);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 42);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Search by ID:";
            // 
            // bikeBindingSource
            // 
            this.bikeBindingSource.DataMember = "Bike";
            this.bikeBindingSource.DataSource = this.chamSocVaGuiXeDataSet2;
            // 
            // chamSocVaGuiXeDataSet2
            // 
            this.chamSocVaGuiXeDataSet2.DataSetName = "ChamSocVaGuiXeDataSet2";
            this.chamSocVaGuiXeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBoxOwner);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(55, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 128);
            this.panel3.TabIndex = 54;
            // 
            // pictureBoxOwner
            // 
            this.pictureBoxOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBoxOwner.Location = new System.Drawing.Point(139, 3);
            this.pictureBoxOwner.Name = "pictureBoxOwner";
            this.pictureBoxOwner.Size = new System.Drawing.Size(200, 117);
            this.pictureBoxOwner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOwner.TabIndex = 1;
            this.pictureBoxOwner.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Picture of Owner:";
            // 
            // pictureBoxMoto
            // 
            this.pictureBoxMoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBoxMoto.Location = new System.Drawing.Point(194, 8);
            this.pictureBoxMoto.Name = "pictureBoxMoto";
            this.pictureBoxMoto.Size = new System.Drawing.Size(200, 117);
            this.pictureBoxMoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMoto.TabIndex = 1;
            this.pictureBoxMoto.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxCost);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(478, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 36);
            this.panel6.TabIndex = 59;
            // 
            // textBoxCost
            // 
            this.textBoxCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCost.Location = new System.Drawing.Point(99, 6);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(200, 22);
            this.textBoxCost.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cost:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownTimeRent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(53, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 36);
            this.panel2.TabIndex = 58;
            // 
            // numericUpDownTimeRent
            // 
            this.numericUpDownTimeRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTimeRent.Location = new System.Drawing.Point(130, 2);
            this.numericUpDownTimeRent.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownTimeRent.Name = "numericUpDownTimeRent";
            this.numericUpDownTimeRent.Size = new System.Drawing.Size(203, 22);
            this.numericUpDownTimeRent.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Time rent:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(115, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(211, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // textBoxFine
            // 
            this.textBoxFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFine.Location = new System.Drawing.Point(99, 8);
            this.textBoxFine.Name = "textBoxFine";
            this.textBoxFine.Size = new System.Drawing.Size(200, 22);
            this.textBoxFine.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonDay);
            this.panel5.Controls.Add(this.radioButtonMonth);
            this.panel5.Controls.Add(this.radioButtonWeek);
            this.panel5.Controls.Add(this.radioButtonHour);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(54, 212);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(348, 31);
            this.panel5.TabIndex = 52;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.Location = new System.Drawing.Point(158, 8);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(47, 17);
            this.radioButtonDay.TabIndex = 4;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "Day";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonth.Location = new System.Drawing.Point(285, 7);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMonth.TabIndex = 3;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "Month";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonWeek.Location = new System.Drawing.Point(221, 7);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(58, 17);
            this.radioButtonWeek.TabIndex = 2;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonHour
            // 
            this.radioButtonHour.AutoSize = true;
            this.radioButtonHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHour.Location = new System.Drawing.Point(100, 8);
            this.radioButtonHour.Name = "radioButtonHour";
            this.radioButtonHour.Size = new System.Drawing.Size(52, 17);
            this.radioButtonHour.TabIndex = 1;
            this.radioButtonHour.TabStop = true;
            this.radioButtonHour.Text = "Hour";
            this.radioButtonHour.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type Rent:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fine:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(478, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 36);
            this.panel1.TabIndex = 60;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(99, 6);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotal.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(577, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(475, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 49;
            this.label11.Text = "Cost/1H:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxFine);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(478, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(344, 36);
            this.panel7.TabIndex = 61;
            // 
            // panelFirstName
            // 
            this.panelFirstName.Controls.Add(this.textBoxName);
            this.panelFirstName.Controls.Add(this.label1);
            this.panelFirstName.Location = new System.Drawing.Point(55, 80);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Size = new System.Drawing.Size(347, 39);
            this.panelFirstName.TabIndex = 50;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(133, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Owner:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(53, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 39);
            this.panel4.TabIndex = 51;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date rent:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonSearch);
            this.panel9.Controls.Add(this.textBoxSearch);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(415, 19);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(443, 54);
            this.panel9.TabIndex = 57;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEdit.Location = new System.Drawing.Point(597, 302);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 41);
            this.buttonEdit.TabIndex = 55;
            this.buttonEdit.Text = "Edit/Remove";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonReset.Location = new System.Drawing.Point(1189, 623);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 41);
            this.buttonReset.TabIndex = 56;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBoxMoto);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(0, 249);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(399, 137);
            this.panel8.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Picture of Numberplate:";
            // 
            // bikeTableAdapter
            // 
            this.bikeTableAdapter.ClearBeforeFill = true;
            // 
            // fCostFineMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panelFirstName);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.panel8);
            this.Name = "fCostFineMoto";
            this.Text = "fCostFineMoto";
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoto)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeRent)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelFirstName.ResumeLayout(false);
            this.panelFirstName.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource bikeBindingSource;
        private ChamSocVaGuiXeDataSet2 chamSocVaGuiXeDataSet2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxOwner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBoxMoto;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxFine;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private ChamSocVaGuiXeDataSet2TableAdapters.BikeTableAdapter bikeTableAdapter;
    }
}