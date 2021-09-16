namespace TrackYourWorkers
{
    partial class Studenti
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ugovorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnUnesiStudenta = new System.Windows.Forms.Button();
            this.btnIzmijeniStudenta = new System.Windows.Forms.Button();
            this.dgvUgovori = new System.Windows.Forms.DataGridView();
            this.studentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivRadnogMjestaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojRadnihSatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isplaceniUgovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isplaceniUgovoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.AllowUserToAddRows = false;
            this.dgvStudenti.AllowUserToDeleteRows = false;
            this.dgvStudenti.AutoGenerateColumns = false;
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.ugovorDataGridViewTextBoxColumn});
            this.dgvStudenti.DataSource = this.studentBindingSource;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 12);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.ReadOnly = true;
            this.dgvStudenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudenti.Size = new System.Drawing.Size(768, 150);
            this.dgvStudenti.TabIndex = 0;
            this.dgvStudenti.SelectionChanged += new System.EventHandler(this.dgvStudenti_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RadnikId";
            this.dataGridViewTextBoxColumn1.HeaderText = "RadnikId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ime";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prezime";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prezime";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OIB";
            this.dataGridViewTextBoxColumn4.HeaderText = "OIB";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fakultet";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fakultet";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GodinaRodjenja";
            this.dataGridViewTextBoxColumn6.HeaderText = "Godina rođenja";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Mobitel";
            this.dataGridViewTextBoxColumn7.HeaderText = "Broj mobitela";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn8.HeaderText = "E-mail adresa";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ugovorDataGridViewTextBoxColumn
            // 
            this.ugovorDataGridViewTextBoxColumn.DataPropertyName = "Ugovor";
            this.ugovorDataGridViewTextBoxColumn.HeaderText = "Ugovor";
            this.ugovorDataGridViewTextBoxColumn.Name = "ugovorDataGridViewTextBoxColumn";
            this.ugovorDataGridViewTextBoxColumn.ReadOnly = true;
            this.ugovorDataGridViewTextBoxColumn.Visible = false;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(TrackYourWorkers.Student);
            // 
            // btnUnesiStudenta
            // 
            this.btnUnesiStudenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUnesiStudenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnesiStudenta.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesiStudenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUnesiStudenta.Location = new System.Drawing.Point(498, 198);
            this.btnUnesiStudenta.Name = "btnUnesiStudenta";
            this.btnUnesiStudenta.Size = new System.Drawing.Size(242, 33);
            this.btnUnesiStudenta.TabIndex = 1;
            this.btnUnesiStudenta.Text = "Dodaj novog studenta";
            this.btnUnesiStudenta.UseVisualStyleBackColor = false;
            this.btnUnesiStudenta.Click += new System.EventHandler(this.btnUnesiStudenta_Click);
            // 
            // btnIzmijeniStudenta
            // 
            this.btnIzmijeniStudenta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzmijeniStudenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzmijeniStudenta.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzmijeniStudenta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzmijeniStudenta.Location = new System.Drawing.Point(498, 265);
            this.btnIzmijeniStudenta.Name = "btnIzmijeniStudenta";
            this.btnIzmijeniStudenta.Size = new System.Drawing.Size(242, 33);
            this.btnIzmijeniStudenta.TabIndex = 2;
            this.btnIzmijeniStudenta.Text = "Izmijeni podatke o studentu";
            this.btnIzmijeniStudenta.UseVisualStyleBackColor = false;
            this.btnIzmijeniStudenta.Click += new System.EventHandler(this.btnIzmijeniStudenta_Click);
            // 
            // dgvUgovori
            // 
            this.dgvUgovori.AllowUserToAddRows = false;
            this.dgvUgovori.AllowUserToDeleteRows = false;
            this.dgvUgovori.AutoGenerateColumns = false;
            this.dgvUgovori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUgovori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentDataGridViewTextBoxColumn,
            this.mjesecDataGridViewTextBoxColumn,
            this.nazivRadnogMjestaDataGridViewTextBoxColumn,
            this.brojRadnihSatiDataGridViewTextBoxColumn,
            this.iznosDataGridViewTextBoxColumn});
            this.dgvUgovori.DataSource = this.isplaceniUgovoriBindingSource;
            this.dgvUgovori.Location = new System.Drawing.Point(12, 217);
            this.dgvUgovori.Name = "dgvUgovori";
            this.dgvUgovori.ReadOnly = true;
            this.dgvUgovori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUgovori.Size = new System.Drawing.Size(447, 150);
            this.dgvUgovori.TabIndex = 3;
            // 
            // studentDataGridViewTextBoxColumn
            // 
            this.studentDataGridViewTextBoxColumn.DataPropertyName = "Student";
            this.studentDataGridViewTextBoxColumn.HeaderText = "Student";
            this.studentDataGridViewTextBoxColumn.Name = "studentDataGridViewTextBoxColumn";
            this.studentDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentDataGridViewTextBoxColumn.Visible = false;
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
            // brojRadnihSatiDataGridViewTextBoxColumn
            // 
            this.brojRadnihSatiDataGridViewTextBoxColumn.DataPropertyName = "BrojRadnihSati";
            this.brojRadnihSatiDataGridViewTextBoxColumn.HeaderText = "Broj radnih sati";
            this.brojRadnihSatiDataGridViewTextBoxColumn.Name = "brojRadnihSatiDataGridViewTextBoxColumn";
            this.brojRadnihSatiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iznosDataGridViewTextBoxColumn
            // 
            this.iznosDataGridViewTextBoxColumn.DataPropertyName = "Iznos";
            this.iznosDataGridViewTextBoxColumn.HeaderText = "Iznos";
            this.iznosDataGridViewTextBoxColumn.Name = "iznosDataGridViewTextBoxColumn";
            this.iznosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isplaceniUgovoriBindingSource
            // 
            this.isplaceniUgovoriBindingSource.DataSource = typeof(TrackYourWorkers.IsplaceniUgovori);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Isplaćeni ugovori:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(498, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ispiši ugovor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnObrisi.Location = new System.Drawing.Point(498, 386);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(242, 33);
            this.btnObrisi.TabIndex = 6;
            this.btnObrisi.Text = "Obriši studenta";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(791, 437);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUgovori);
            this.Controls.Add(this.btnIzmijeniStudenta);
            this.Controls.Add(this.btnUnesiStudenta);
            this.Controls.Add(this.dgvStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Studenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Studenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUgovori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isplaceniUgovoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnikIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oIBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fakultetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn godinaRodjenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobitelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUnesiStudenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn ugovorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button btnIzmijeniStudenta;
        private System.Windows.Forms.DataGridView dgvUgovori;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivRadnogMjestaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojRadnihSatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource isplaceniUgovoriBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnObrisi;
    }
}