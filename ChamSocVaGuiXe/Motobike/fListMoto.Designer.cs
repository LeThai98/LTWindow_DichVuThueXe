namespace ChamSocVaGuiXe
{
    partial class fListMoto
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
            this.dataGridViewMotoList = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageNumberPlateDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.imageOwnerDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chamSocVaGuiXe_ListMoto = new ChamSocVaGuiXe.ChamSocVaGuiXe_ListMoto();
            this.motoTableAdapter = new ChamSocVaGuiXe.ChamSocVaGuiXe_ListMotoTableAdapters.MotoTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotoList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ListMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMotoList
            // 
            this.dataGridViewMotoList.AutoGenerateColumns = false;
            this.dataGridViewMotoList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMotoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.imageNumberPlateDataGridViewImageColumn,
            this.imageOwnerDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.timeRentDataGridViewTextBoxColumn,
            this.dateRentDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridViewMotoList.DataSource = this.motoBindingSource;
            this.dataGridViewMotoList.Location = new System.Drawing.Point(3, 1);
            this.dataGridViewMotoList.Name = "dataGridViewMotoList";
            this.dataGridViewMotoList.Size = new System.Drawing.Size(794, 359);
            this.dataGridViewMotoList.TabIndex = 0;
            this.dataGridViewMotoList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMotoList_CellContentClick);
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
            // motoBindingSource
            // 
            this.motoBindingSource.DataMember = "Moto";
            this.motoBindingSource.DataSource = this.chamSocVaGuiXe_ListMoto;
            // 
            // chamSocVaGuiXe_ListMoto
            // 
            this.chamSocVaGuiXe_ListMoto.DataSetName = "ChamSocVaGuiXe_ListMoto";
            this.chamSocVaGuiXe_ListMoto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motoTableAdapter
            // 
            this.motoTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(339, 390);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // fListMoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewMotoList);
            this.Name = "fListMoto";
            this.Text = "fListMoto";
            this.Load += new System.EventHandler(this.fListMoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotoList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamSocVaGuiXe_ListMoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMotoList;
        private ChamSocVaGuiXe_ListMoto chamSocVaGuiXe_ListMoto;
        private System.Windows.Forms.BindingSource motoBindingSource;
        private ChamSocVaGuiXe_ListMotoTableAdapters.MotoTableAdapter motoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageNumberPlateDataGridViewImageColumn;
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