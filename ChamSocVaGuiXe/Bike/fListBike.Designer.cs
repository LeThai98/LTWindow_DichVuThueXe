namespace ChamSocVaGuiXe
{
    partial class fListBike
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
            this.chamSocVaGuiXeDataSet = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet();
            this.bikeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bikeTableAdapter = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSetTableAdapters.BikeTableAdapter();
            this.dataGridViewBikeList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageBikeDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageOwnerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bikeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.chamSocVaGuiXeDataSet1 = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet1();
            this.bikeTableAdapter1 = new ChamSocVaGuiXe.ChamSocVaGuiXeDataSet1TableAdapters.BikeTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chamSocVaGuiXeDataSet
            // 
            this.chamSocVaGuiXeDataSet.DataSetName = "ChamSocVaGuiXeDataSet";
            this.chamSocVaGuiXeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bikeBindingSource
            // 
            this.bikeBindingSource.DataMember = "Bike";
            this.bikeBindingSource.DataSource = this.chamSocVaGuiXeDataSet;
            // 
            // bikeTableAdapter
            // 
            this.bikeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewBikeList
            // 
            this.dataGridViewBikeList.AutoGenerateColumns = false;
            this.dataGridViewBikeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBikeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBikeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageBikeDataGridViewImageColumn,
            this.imageOwnerDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.timeRentDataGridViewTextBoxColumn,
            this.dateRentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewBikeList.DataSource = this.bikeBindingSource1;
            this.dataGridViewBikeList.Location = new System.Drawing.Point(2, 12);
            this.dataGridViewBikeList.Name = "dataGridViewBikeList";
            this.dataGridViewBikeList.Size = new System.Drawing.Size(921, 316);
            this.dataGridViewBikeList.TabIndex = 0;
            this.dataGridViewBikeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBikeList_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // imageBikeDataGridViewImageColumn
            // 
            this.imageBikeDataGridViewImageColumn.DataPropertyName = "ImageBike";
            this.imageBikeDataGridViewImageColumn.HeaderText = "ImageBike";
            this.imageBikeDataGridViewImageColumn.Name = "imageBikeDataGridViewImageColumn";
            // 
            // imageOwnerDataGridViewImageColumn
            // 
            this.imageOwnerDataGridViewImageColumn.DataPropertyName = "ImageOwner";
            this.imageOwnerDataGridViewImageColumn.HeaderText = "ImageOwner";
            this.imageOwnerDataGridViewImageColumn.Name = "imageOwnerDataGridViewImageColumn";
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
            // bikeBindingSource1
            // 
            this.bikeBindingSource1.DataMember = "Bike";
            this.bikeBindingSource1.DataSource = this.chamSocVaGuiXeDataSet1;
            // 
            // chamSocVaGuiXeDataSet1
            // 
            this.chamSocVaGuiXeDataSet1.DataSetName = "ChamSocVaGuiXeDataSet1";
            this.chamSocVaGuiXeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bikeTableAdapter1
            // 
            this.bikeTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(344, 348);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // fListBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewBikeList);
            this.Name = "fListBike";
            this.Text = "fListBike";
            this.Load += new System.EventHandler(this.fListBike_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bikeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXeDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ChamSocVaGuiXeDataSet chamSocVaGuiXeDataSet;
        private System.Windows.Forms.BindingSource bikeBindingSource;
        private ChamSocVaGuiXeDataSetTableAdapters.BikeTableAdapter bikeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewBikeList;
        private ChamSocVaGuiXeDataSet1 chamSocVaGuiXeDataSet1;
        private System.Windows.Forms.BindingSource bikeBindingSource1;
        private ChamSocVaGuiXeDataSet1TableAdapters.BikeTableAdapter bikeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageBikeDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageOwnerDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonRefresh;
    }
}