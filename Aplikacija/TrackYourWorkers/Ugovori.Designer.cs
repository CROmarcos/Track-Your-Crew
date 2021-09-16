
namespace TrackYourWorkers
{
    partial class Ugovori
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
            this.btnOtvoriUgovor = new System.Windows.Forms.Button();
            this.btnPodnesiUgovor = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOtkaziUgovor = new System.Windows.Forms.Button();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivRadnogMjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otvoreniUgovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvoreniUgovoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtvoriUgovor
            // 
            this.btnOtvoriUgovor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOtvoriUgovor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtvoriUgovor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvoriUgovor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOtvoriUgovor.Location = new System.Drawing.Point(129, 194);
            this.btnOtvoriUgovor.Name = "btnOtvoriUgovor";
            this.btnOtvoriUgovor.Size = new System.Drawing.Size(172, 25);
            this.btnOtvoriUgovor.TabIndex = 0;
            this.btnOtvoriUgovor.Text = "Otvori novi ugovor";
            this.btnOtvoriUgovor.UseVisualStyleBackColor = false;
            this.btnOtvoriUgovor.Click += new System.EventHandler(this.btnOtvoriUgovor_Click);
            // 
            // btnPodnesiUgovor
            // 
            this.btnPodnesiUgovor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPodnesiUgovor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPodnesiUgovor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodnesiUgovor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPodnesiUgovor.Location = new System.Drawing.Point(44, 231);
            this.btnPodnesiUgovor.Name = "btnPodnesiUgovor";
            this.btnPodnesiUgovor.Size = new System.Drawing.Size(172, 25);
            this.btnPodnesiUgovor.TabIndex = 1;
            this.btnPodnesiUgovor.Text = "Podnesi ugovor";
            this.btnPodnesiUgovor.UseVisualStyleBackColor = false;
            this.btnPodnesiUgovor.Click += new System.EventHandler(this.btnPodnesiUgovor_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.mjesecDataGridViewTextBoxColumn,
            this.nazivRadnogMjestaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.otvoreniUgovoriBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(420, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnOtkaziUgovor
            // 
            this.btnOtkaziUgovor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOtkaziUgovor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtkaziUgovor.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtkaziUgovor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOtkaziUgovor.Location = new System.Drawing.Point(232, 231);
            this.btnOtkaziUgovor.Name = "btnOtkaziUgovor";
            this.btnOtkaziUgovor.Size = new System.Drawing.Size(172, 25);
            this.btnOtkaziUgovor.TabIndex = 4;
            this.btnOtkaziUgovor.Text = "Otkaži ugovor";
            this.btnOtkaziUgovor.UseVisualStyleBackColor = false;
            this.btnOtkaziUgovor.Click += new System.EventHandler(this.btnOtkaziUgovor_Click);
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mjesecDataGridViewTextBoxColumn
            // 
            this.mjesecDataGridViewTextBoxColumn.DataPropertyName = "Mjesec";
            this.mjesecDataGridViewTextBoxColumn.HeaderText = "Mjesec";
            this.mjesecDataGridViewTextBoxColumn.Name = "mjesecDataGridViewTextBoxColumn";
            this.mjesecDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivRadnogMjestaDataGridViewTextBoxColumn
            // 
            this.nazivRadnogMjestaDataGridViewTextBoxColumn.DataPropertyName = "NazivRadnogMjesta";
            this.nazivRadnogMjestaDataGridViewTextBoxColumn.HeaderText = "Radno mjesto";
            this.nazivRadnogMjestaDataGridViewTextBoxColumn.Name = "nazivRadnogMjestaDataGridViewTextBoxColumn";
            this.nazivRadnogMjestaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otvoreniUgovoriBindingSource
            // 
            this.otvoreniUgovoriBindingSource.DataSource = typeof(TrackYourWorkers.OtvoreniUgovori);
            // 
            // Ugovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(442, 270);
            this.Controls.Add(this.btnOtkaziUgovor);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPodnesiUgovor);
            this.Controls.Add(this.btnOtvoriUgovor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Ugovori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Otvoreni ugovori";
            this.Load += new System.EventHandler(this.Ugovori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otvoreniUgovoriBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOtvoriUgovor;
        private System.Windows.Forms.Button btnPodnesiUgovor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource otvoreniUgovoriBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRadnogMjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnOtkaziUgovor;
    }
}