namespace ChamSocVaGuiXe
{
    partial class fManageBike
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
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonDownloadBike = new System.Windows.Forms.Button();
            this.buttonUploadBike = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalBike = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bikeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamSocVaGuiXeDataSet2 = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet2();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBoxBike = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.panelFirstName = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonHour = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownTimeRent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonDownloadOwner = new System.Windows.Forms.Button();
            this.buttonUploadOwner = new System.Windows.Forms.Button();
            this.pictureBoxOwner = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bikeTableAdapter = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet2TableAdapters.BikeTableAdapter();
            this.chamSocVaGuiXe_ManageMoto = new ChamSocVaGuiXe.ChamSocVaGuiXe_ManageMoto();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageOwnerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageBikeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet2)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelFirstName.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeRent)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ManageMoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(130, 8);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxPhone.TabIndex = 1;
            // 
            // buttonDownloadBike
            // 
            this.buttonDownloadBike.BackColor = System.Drawing.Color.Teal;
            this.buttonDownloadBike.Location = new System.Drawing.Point(246, 126);
            this.buttonDownloadBike.Name = "buttonDownloadBike";
            this.buttonDownloadBike.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadBike.TabIndex = 3;
            this.buttonDownloadBike.Text = "Download";
            this.buttonDownloadBike.UseVisualStyleBackColor = false;
            this.buttonDownloadBike.Click += new System.EventHandler(this.buttonDownloadBike_Click);
            // 
            // buttonUploadBike
            // 
            this.buttonUploadBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUploadBike.Location = new System.Drawing.Point(139, 126);
            this.buttonUploadBike.Name = "buttonUploadBike";
            this.buttonUploadBike.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadBike.TabIndex = 2;
            this.buttonUploadBike.Text = "Upload";
            this.buttonUploadBike.UseVisualStyleBackColor = false;
            this.buttonUploadBike.Click += new System.EventHandler(this.buttonUploadBike_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Picture of Bike:";
            // 
            // labelTotalBike
            // 
            this.labelTotalBike.BackColor = System.Drawing.Color.Magenta;
            this.labelTotalBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBike.Location = new System.Drawing.Point(666, 516);
            this.labelTotalBike.Name = "labelTotalBike";
            this.labelTotalBike.Size = new System.Drawing.Size(255, 50);
            this.labelTotalBike.TabIndex = 27;
            this.labelTotalBike.Text = "Total Bike:";
            this.labelTotalBike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.buttonSearch);
            this.panel9.Controls.Add(this.textBoxSearch);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(375, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(546, 64);
            this.panel9.TabIndex = 26;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSearch.Location = new System.Drawing.Point(426, 11);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 42);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(192, 20);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(211, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter a value to search:";
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
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonReset.Location = new System.Drawing.Point(1028, 606);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(117, 41);
            this.buttonReset.TabIndex = 24;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRemove.Location = new System.Drawing.Point(813, 606);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(117, 41);
            this.buttonRemove.TabIndex = 23;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.buttonDownloadBike);
            this.panel8.Controls.Add(this.buttonUploadBike);
            this.panel8.Controls.Add(this.pictureBoxBike);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(8, 373);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(344, 155);
            this.panel8.TabIndex = 20;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // pictureBoxBike
            // 
            this.pictureBoxBike.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBoxBike.Location = new System.Drawing.Point(139, 3);
            this.pictureBoxBike.Name = "pictureBoxBike";
            this.pictureBoxBike.Size = new System.Drawing.Size(200, 117);
            this.pictureBoxBike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBike.TabIndex = 1;
            this.pictureBoxBike.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEdit.Location = new System.Drawing.Point(616, 606);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(117, 41);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAdd.Location = new System.Drawing.Point(393, 606);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 41);
            this.buttonAdd.TabIndex = 21;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Phone:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(10, 8);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(27, 16);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Location = new System.Drawing.Point(5, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 39);
            this.panel1.TabIndex = 13;
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(133, 5);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // panelFirstName
            // 
            this.panelFirstName.Controls.Add(this.textBoxName);
            this.panelFirstName.Controls.Add(this.label1);
            this.panelFirstName.Location = new System.Drawing.Point(5, 53);
            this.panelFirstName.Name = "panelFirstName";
            this.panelFirstName.Size = new System.Drawing.Size(347, 39);
            this.panelFirstName.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(133, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 22);
            this.textBoxName.TabIndex = 1;
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
            this.panel4.Location = new System.Drawing.Point(12, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(340, 39);
            this.panel4.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
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
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButtonDay);
            this.panel5.Controls.Add(this.radioButtonMonth);
            this.panel5.Controls.Add(this.radioButtonWeek);
            this.panel5.Controls.Add(this.radioButtonHour);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(8, 342);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(344, 31);
            this.panel5.TabIndex = 19;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDay.Location = new System.Drawing.Point(153, 8);
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
            this.radioButtonMonth.Location = new System.Drawing.Point(281, 7);
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
            this.radioButtonWeek.Location = new System.Drawing.Point(217, 8);
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
            // panel6
            // 
            this.panel6.Controls.Add(this.textBoxPhone);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(8, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(344, 39);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBoxAddress);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(5, 98);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(347, 106);
            this.panel7.TabIndex = 28;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(133, 8);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(200, 82);
            this.textBoxAddress.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Address:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownTimeRent);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 36);
            this.panel2.TabIndex = 29;
            // 
            // numericUpDownTimeRent
            // 
            this.numericUpDownTimeRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTimeRent.Location = new System.Drawing.Point(130, 2);
            this.numericUpDownTimeRent.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownTimeRent.Name = "numericUpDownTimeRent";
            this.numericUpDownTimeRent.Size = new System.Drawing.Size(203, 22);
            this.numericUpDownTimeRent.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonDownloadOwner);
            this.panel3.Controls.Add(this.buttonUploadOwner);
            this.panel3.Controls.Add(this.pictureBoxOwner);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(8, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 166);
            this.panel3.TabIndex = 21;
            // 
            // buttonDownloadOwner
            // 
            this.buttonDownloadOwner.BackColor = System.Drawing.Color.Teal;
            this.buttonDownloadOwner.Location = new System.Drawing.Point(246, 126);
            this.buttonDownloadOwner.Name = "buttonDownloadOwner";
            this.buttonDownloadOwner.Size = new System.Drawing.Size(75, 23);
            this.buttonDownloadOwner.TabIndex = 3;
            this.buttonDownloadOwner.Text = "Download";
            this.buttonDownloadOwner.UseVisualStyleBackColor = false;
            this.buttonDownloadOwner.Click += new System.EventHandler(this.buttonDownloadOwner_Click);
            // 
            // buttonUploadOwner
            // 
            this.buttonUploadOwner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUploadOwner.Location = new System.Drawing.Point(139, 126);
            this.buttonUploadOwner.Name = "buttonUploadOwner";
            this.buttonUploadOwner.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadOwner.TabIndex = 2;
            this.buttonUploadOwner.Text = "Upload";
            this.buttonUploadOwner.UseVisualStyleBackColor = false;
            this.buttonUploadOwner.Click += new System.EventHandler(this.buttonUploadOwner_Click);
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
            // bikeTableAdapter
            // 
            this.bikeTableAdapter.ClearBeforeFill = true;
            // 
            // chamSocVaGuiXe_ManageMoto
            // 
            this.chamSocVaGuiXe_ManageMoto.DataSetName = "ChamSocVaGuiXe_ManageMoto";
            this.chamSocVaGuiXe_ManageMoto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateRentDataGridViewTextBoxColumn
            // 
            this.dateRentDataGridViewTextBoxColumn.DataPropertyName = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.HeaderText = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.Name = "dateRentDataGridViewTextBoxColumn";
            // 
            // timeRentDataGridViewTextBoxColumn
            // 
            this.timeRentDataGridViewTextBoxColumn.DataPropertyName = "TimeRent";
            this.timeRentDataGridViewTextBoxColumn.HeaderText = "TimeRent";
            this.timeRentDataGridViewTextBoxColumn.Name = "timeRentDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // imageOwnerDataGridViewImageColumn
            // 
            this.imageOwnerDataGridViewImageColumn.DataPropertyName = "ImageOwner";
            this.imageOwnerDataGridViewImageColumn.HeaderText = "ImageOwner";
            this.imageOwnerDataGridViewImageColumn.Name = "imageOwnerDataGridViewImageColumn";
            // 
            // imageBikeDataGridViewImageColumn
            // 
            this.imageBikeDataGridViewImageColumn.DataPropertyName = "ImageBike";
            this.imageBikeDataGridViewImageColumn.HeaderText = "ImageBike";
            this.imageBikeDataGridViewImageColumn.Name = "imageBikeDataGridViewImageColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Teal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageBikeDataGridViewImageColumn,
            this.imageOwnerDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.timeRentDataGridViewTextBoxColumn,
            this.dateRentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bikeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(375, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 432);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // fManageBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 709);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.labelTotalBike);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFirstName);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "fManageBike";
            this.Text = "fManageBike";
            this.Load += new System.EventHandler(this.fManageBike_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBike)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFirstName.ResumeLayout(false);
            this.panelFirstName.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeRent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ManageMoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonDownloadBike;
        private System.Windows.Forms.Button buttonUploadBike;
        private System.Windows.Forms.PictureBox pictureBoxBike;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalBike;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Panel panelFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonDownloadOwner;
        private System.Windows.Forms.Button buttonUploadOwner;
        private System.Windows.Forms.PictureBox pictureBoxOwner;
        private System.Windows.Forms.Label label9;
        private ChamSocVaGuiXeDataSet2 chamSocVaGuiXeDataSet2;
        private System.Windows.Forms.BindingSource bikeBindingSource;
        private ChamSocVaGuiXeDataSet2TableAdapters.BikeTableAdapter bikeTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private ChamSocVaGuiXe_ManageMoto chamSocVaGuiXe_ManageMoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageOwnerDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageBikeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}