namespace Tip_Calculator___Desktop
{
    partial class frmReportViewer
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
            this.CondominiumManagementSystemDBDataSet = new Tip_Calculator___Desktop.CondominiumManagementSystemDBDataSet();
            this.tblHouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHouseTableAdapter = new Tip_Calculator___Desktop.CondominiumManagementSystemDBDataSetTableAdapters.tblHouseTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CondominiumManagementSystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // CondominiumManagementSystemDBDataSet
            // 
            this.CondominiumManagementSystemDBDataSet.DataSetName = "CondominiumManagementSystemDBDataSet";
            this.CondominiumManagementSystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHouseBindingSource
            // 
            this.tblHouseBindingSource.DataMember = "tblHouse";
            this.tblHouseBindingSource.DataSource = this.CondominiumManagementSystemDBDataSet;
            // 
            // tblHouseTableAdapter
            // 
            this.tblHouseTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1145, 643);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 667);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportViewer";
            this.Text = "frmReportViewer";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CondominiumManagementSystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHouseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblHouseBindingSource;
        private CondominiumManagementSystemDBDataSet CondominiumManagementSystemDBDataSet;
        private CondominiumManagementSystemDBDataSetTableAdapters.tblHouseTableAdapter tblHouseTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}