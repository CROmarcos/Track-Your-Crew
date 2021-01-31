namespace TrackYourWorkers
{
    partial class RadnaMjesta
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
            this.dgvRadnoMjesto = new System.Windows.Forms.DataGridView();
            this.btnUnesiRM = new System.Windows.Forms.Button();
            this.btnIzmijeniRM = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnoMjestoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoMjesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnoMjestoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRadnoMjesto
            // 
            this.dgvRadnoMjesto.AllowUserToAddRows = false;
            this.dgvRadnoMjesto.AllowUserToDeleteRows = false;
            this.dgvRadnoMjesto.AutoGenerateColumns = false;
            this.dgvRadnoMjesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRadnoMjesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvRadnoMjesto.DataSource = this.radnoMjestoBindingSource;
            this.dgvRadnoMjesto.Location = new System.Drawing.Point(12, 12);
            this.dgvRadnoMjesto.Name = "dgvRadnoMjesto";
            this.dgvRadnoMjesto.ReadOnly = true;
            this.dgvRadnoMjesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadnoMjesto.Size = new System.Drawing.Size(543, 220);
            this.dgvRadnoMjesto.TabIndex = 0;
            // 
            // btnUnesiRM
            // 
            this.btnUnesiRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnesiRM.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiRM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUnesiRM.Location = new System.Drawing.Point(66, 247);
            this.btnUnesiRM.Name = "btnUnesiRM";
            this.btnUnesiRM.Size = new System.Drawing.Size(177, 31);
            this.btnUnesiRM.TabIndex = 2;
            this.btnUnesiRM.Text = "Unesi novo radno mjesto";
            this.btnUnesiRM.UseVisualStyleBackColor = true;
            this.btnUnesiRM.Click += new System.EventHandler(this.btnUnesiRM_Click);
            // 
            // btnIzmijeniRM
            // 
            this.btnIzmijeniRM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmijeniRM.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniRM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmijeniRM.Location = new System.Drawing.Point(302, 247);
            this.btnIzmijeniRM.Name = "btnIzmijeniRM";
            this.btnIzmijeniRM.Size = new System.Drawing.Size(177, 31);
            this.btnIzmijeniRM.TabIndex = 3;
            this.btnIzmijeniRM.Text = "Uredi radno mjesto";
            this.btnIzmijeniRM.UseVisualStyleBackColor = true;
            this.btnIzmijeniRM.Click += new System.EventHandler(this.btnIzmijeniRM_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RadnoMjestoId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RadnoMjestoId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NazivRadnogMjesta";
            this.dataGridViewTextBoxColumn2.HeaderText = "Radno mjesto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OpisRadnogMjesta";
            this.dataGridViewTextBoxColumn3.HeaderText = "Opis posla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CijenaRadnogSata";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cijena radnog sata";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Ugovor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Ugovor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // radnoMjestoBindingSource
            // 
            this.radnoMjestoBindingSource.DataSource = typeof(TrackYourWorkers.RadnoMjesto);
            // 
            // RadnaMjesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(569, 290);
            this.Controls.Add(this.btnIzmijeniRM);
            this.Controls.Add(this.btnUnesiRM);
            this.Controls.Add(this.dgvRadnoMjesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RadnaMjesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Radna mjesta";
            this.Load += new System.EventHandler(this.RadnaMjesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadnoMjesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radnoMjestoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource radnoMjestoBindingSource;
        private System.Windows.Forms.DataGridView dgvRadnoMjesto;
        private System.Windows.Forms.Button btnUnesiRM;
        private System.Windows.Forms.Button btnIzmijeniRM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}