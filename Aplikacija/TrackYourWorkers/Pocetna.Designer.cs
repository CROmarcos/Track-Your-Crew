namespace TrackYourWorkers
{
    partial class Pocetna
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
            this.btnStudenti = new System.Windows.Forms.Button();
            this.btnRadnaMjesta = new System.Windows.Forms.Button();
            this.btnUgovori = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudenti
            // 
            this.btnStudenti.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnStudenti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudenti.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudenti.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnStudenti.Location = new System.Drawing.Point(353, 158);
            this.btnStudenti.Name = "btnStudenti";
            this.btnStudenti.Size = new System.Drawing.Size(80, 108);
            this.btnStudenti.TabIndex = 0;
            this.btnStudenti.Text = "Popis studenata";
            this.btnStudenti.UseVisualStyleBackColor = false;
            this.btnStudenti.Click += new System.EventHandler(this.btnStudenti_Click);
            // 
            // btnRadnaMjesta
            // 
            this.btnRadnaMjesta.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRadnaMjesta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRadnaMjesta.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadnaMjesta.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRadnaMjesta.Location = new System.Drawing.Point(589, 161);
            this.btnRadnaMjesta.Name = "btnRadnaMjesta";
            this.btnRadnaMjesta.Size = new System.Drawing.Size(80, 108);
            this.btnRadnaMjesta.TabIndex = 1;
            this.btnRadnaMjesta.Text = "Popis radnih mjesta";
            this.btnRadnaMjesta.UseVisualStyleBackColor = false;
            this.btnRadnaMjesta.Click += new System.EventHandler(this.btnRadnaMjesta_Click);
            // 
            // btnUgovori
            // 
            this.btnUgovori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUgovori.Font = new System.Drawing.Font("Palatino Linotype", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUgovori.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUgovori.Location = new System.Drawing.Point(467, 356);
            this.btnUgovori.Name = "btnUgovori";
            this.btnUgovori.Size = new System.Drawing.Size(140, 25);
            this.btnUgovori.TabIndex = 2;
            this.btnUgovori.Text = "Pregled ugovora";
            this.btnUgovori.UseVisualStyleBackColor = true;
            this.btnUgovori.Click += new System.EventHandler(this.btnUgovori_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(TrackYourWorkers.Student);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::TrackYourWorkers.Properties.Resources.pozadina;
            this.ClientSize = new System.Drawing.Size(952, 526);
            this.Controls.Add(this.btnUgovori);
            this.Controls.Add(this.btnRadnaMjesta);
            this.Controls.Add(this.btnStudenti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Pocetna";
            this.ShowInTaskbar = false;
            this.Text = "Track Your Crew";
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudenti;
        private System.Windows.Forms.Button btnRadnaMjesta;
        private System.Windows.Forms.Button btnUgovori;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}

