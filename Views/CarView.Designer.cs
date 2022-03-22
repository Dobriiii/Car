
namespace Car.Views
{
    partial class CarView
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
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.carDatabaseDataSet = new Car.CarDatabaseDataSet();
            this.carTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableTableAdapter = new Car.CarDatabaseDataSetTableAdapters.CarTableTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblProductionYear = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.carDatabaseDataSet1 = new Car.CarDatabaseDataSet();
            this.ProductionYearPick = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCars
            // 
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.productionYearDataGridViewTextBoxColumn});
            this.dgvCars.DataSource = this.carTableBindingSource;
            this.dgvCars.Location = new System.Drawing.Point(22, 29);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.Size = new System.Drawing.Size(444, 214);
            this.dgvCars.TabIndex = 0;
            // 
            // carDatabaseDataSet
            // 
            this.carDatabaseDataSet.DataSetName = "CarDatabaseDataSet";
            this.carDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTableBindingSource
            // 
            this.carTableBindingSource.DataMember = "CarTable";
            this.carTableBindingSource.DataSource = this.carDatabaseDataSet;
            // 
            // carTableTableAdapter
            // 
            this.carTableTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // productionYearDataGridViewTextBoxColumn
            // 
            this.productionYearDataGridViewTextBoxColumn.DataPropertyName = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.HeaderText = "ProductionYear";
            this.productionYearDataGridViewTextBoxColumn.Name = "productionYearDataGridViewTextBoxColumn";
            // 
            // lblBrand
            // 
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(496, 50);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(62, 34);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(601, 50);
            this.txtBrand.Multiline = true;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 34);
            this.txtBrand.TabIndex = 2;
            // 
            // lblModel
            // 
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(496, 102);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(62, 34);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProductionYear
            // 
            this.lblProductionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductionYear.Location = new System.Drawing.Point(472, 159);
            this.lblProductionYear.Name = "lblProductionYear";
            this.lblProductionYear.Size = new System.Drawing.Size(86, 34);
            this.lblProductionYear.TabIndex = 4;
            this.lblProductionYear.Text = "Production Year";
            this.lblProductionYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(601, 102);
            this.txtModel.Multiline = true;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 34);
            this.txtModel.TabIndex = 5;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(482, 246);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(93, 35);
            this.btnCreate.TabIndex = 7;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // carDatabaseDataSet1
            // 
            this.carDatabaseDataSet1.DataSetName = "CarDatabaseDataSet";
            this.carDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductionYearPick
            // 
            this.ProductionYearPick.Location = new System.Drawing.Point(588, 164);
            this.ProductionYearPick.Name = "ProductionYearPick";
            this.ProductionYearPick.Size = new System.Drawing.Size(200, 20);
            this.ProductionYearPick.TabIndex = 8;
            // 
            // CarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Car.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductionYearPick);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblProductionYear);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.dgvCars);
            this.Name = "CarView";
            this.Text = "CarView";
            this.Load += new System.EventHandler(this.CarView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCars;
        private CarDatabaseDataSet carDatabaseDataSet;
        private System.Windows.Forms.BindingSource carTableBindingSource;
        private CarDatabaseDataSetTableAdapters.CarTableTableAdapter carTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblProductionYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnCreate;
        private CarDatabaseDataSet carDatabaseDataSet1;
        private System.Windows.Forms.DateTimePicker ProductionYearPick;
    }
}