namespace ChamSocVaGuiXe
{
    partial class fListCar
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
            this.dataGridViewCarList = new System.Windows.Forms.DataGridView();
            this.chamSocVaGuiXe_ListCar = new ChamSocVaGuiXe.ChamSocVaGuiXe_ListCar();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new ChamSocVaGuiXe.ChamSocVaGuiXe_ListCarTableAdapters.CarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNumberPlateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageTypeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ListCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarList
            // 
            this.dataGridViewCarList.AutoGenerateColumns = false;
            this.dataGridViewCarList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageNumberPlateDataGridViewImageColumn,
            this.imageTypeDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.timeRentDataGridViewTextBoxColumn,
            this.dateRentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewCarList.DataSource = this.carBindingSource;
            this.dataGridViewCarList.Location = new System.Drawing.Point(6, 5);
            this.dataGridViewCarList.Name = "dataGridViewCarList";
            this.dataGridViewCarList.Size = new System.Drawing.Size(790, 355);
            this.dataGridViewCarList.TabIndex = 0;
            this.dataGridViewCarList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarList_CellContentClick);
            // 
            // chamSocVaGuiXe_ListCar
            // 
            this.chamSocVaGuiXe_ListCar.DataSetName = "ChamSocVaGuiXe_ListCar";
            this.chamSocVaGuiXe_ListCar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.chamSocVaGuiXe_ListCar;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imageNumberPlateDataGridViewImageColumn
            // 
            this.imageNumberPlateDataGridViewImageColumn.DataPropertyName = "ImageNumberPlate";
            this.imageNumberPlateDataGridViewImageColumn.HeaderText = "ImageNumberPlate";
            this.imageNumberPlateDataGridViewImageColumn.Name = "imageNumberPlateDataGridViewImageColumn";
            // 
            // imageTypeDataGridViewImageColumn
            // 
            this.imageTypeDataGridViewImageColumn.DataPropertyName = "ImageType";
            this.imageTypeDataGridViewImageColumn.HeaderText = "ImageType";
            this.imageTypeDataGridViewImageColumn.Name = "imageTypeDataGridViewImageColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // timeRentDataGridViewTextBoxColumn
            // 
            this.timeRentDataGridViewTextBoxColumn.DataPropertyName = "TimeRent";
            this.timeRentDataGridViewTextBoxColumn.HeaderText = "TimeRent";
            this.timeRentDataGridViewTextBoxColumn.Name = "timeRentDataGridViewTextBoxColumn";
            // 
            // dateRentDataGridViewTextBoxColumn
            // 
            this.dateRentDataGridViewTextBoxColumn.DataPropertyName = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.HeaderText = "DateRent";
            this.dateRentDataGridViewTextBoxColumn.Name = "dateRentDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(411, 394);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // fListCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewCarList);
            this.Name = "fListCar";
            this.Text = "fListCar";
            this.Load += new System.EventHandler(this.fListCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ListCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarList;
        private ChamSocVaGuiXe_ListCar chamSocVaGuiXe_ListCar;
        private System.Windows.Forms.BindingSource carBindingSource;
        private ChamSocVaGuiXe_ListCarTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageNumberPlateDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageTypeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}