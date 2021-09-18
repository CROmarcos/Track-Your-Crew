
namespace TrackYourWorkers
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnSpremiPDF = new System.Windows.Forms.Button();
            this.IsplaceniUgovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IsplaceniUgovoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "ReportDataSet";
            reportDataSource1.Value = this.IsplaceniUgovoriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrackYourWorkers.Reports.Izvjestaj.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(600, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnSpremiPDF
            // 
            this.btnSpremiPDF.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSpremiPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpremiPDF.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremiPDF.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSpremiPDF.Location = new System.Drawing.Point(259, 573);
            this.btnSpremiPDF.Name = "btnSpremiPDF";
            this.btnSpremiPDF.Size = new System.Drawing.Size(114, 27);
            this.btnSpremiPDF.TabIndex = 1;
            this.btnSpremiPDF.Text = "Spremi";
            this.btnSpremiPDF.UseVisualStyleBackColor = false;
            this.btnSpremiPDF.Click += new System.EventHandler(this.btnSpremiPDF_Click);
            // 
            // IsplaceniUgovoriBindingSource
            // 
            this.IsplaceniUgovoriBindingSource.DataSource = typeof(TrackYourWorkers.IsplaceniUgovori);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(625, 608);
            this.Controls.Add(this.btnSpremiPDF);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pregled ugovora";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IsplaceniUgovoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IsplaceniUgovoriBindingSource;
        private System.Windows.Forms.Button btnSpremiPDF;
    }
}