
namespace TrackYourWorkers
{
    partial class PodnesiUgovor
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
            this.lbStudent = new System.Windows.Forms.Label();
            this.lbMjesec = new System.Windows.Forms.Label();
            this.lbRM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRS = new System.Windows.Forms.TextBox();
            this.lbIznos = new System.Windows.Forms.Label();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnPodnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStudent
            // 
            this.lbStudent.AutoSize = true;
            this.lbStudent.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudent.Location = new System.Drawing.Point(13, 15);
            this.lbStudent.Name = "lbStudent";
            this.lbStudent.Size = new System.Drawing.Size(59, 17);
            this.lbStudent.TabIndex = 0;
            this.lbStudent.Text = "(Student)";
            // 
            // lbMjesec
            // 
            this.lbMjesec.AutoSize = true;
            this.lbMjesec.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMjesec.Location = new System.Drawing.Point(13, 51);
            this.lbMjesec.Name = "lbMjesec";
            this.lbMjesec.Size = new System.Drawing.Size(56, 17);
            this.lbMjesec.TabIndex = 1;
            this.lbMjesec.Text = "(Mjesec)";
            // 
            // lbRM
            // 
            this.lbRM.AutoSize = true;
            this.lbRM.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRM.Location = new System.Drawing.Point(13, 84);
            this.lbRM.Name = "lbRM";
            this.lbRM.Size = new System.Drawing.Size(93, 17);
            this.lbRM.TabIndex = 2;
            this.lbRM.Text = "(Radno mjesto)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student je odradio radnih sati:";
            // 
            // tbRS
            // 
            this.tbRS.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRS.Location = new System.Drawing.Point(194, 114);
            this.tbRS.Name = "tbRS";
            this.tbRS.Size = new System.Drawing.Size(34, 24);
            this.tbRS.TabIndex = 4;
            this.tbRS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRS_KeyPress);
            // 
            // lbIznos
            // 
            this.lbIznos.AutoSize = true;
            this.lbIznos.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIznos.Location = new System.Drawing.Point(13, 149);
            this.lbIznos.Name = "lbIznos";
            this.lbIznos.Size = new System.Drawing.Size(47, 17);
            this.lbIznos.TabIndex = 5;
            this.lbIznos.Text = "(Iznos)";
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnIzracunaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIzracunaj.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzracunaj.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnIzracunaj.Location = new System.Drawing.Point(65, 179);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(114, 25);
            this.btnIzracunaj.TabIndex = 6;
            this.btnIzracunaj.Text = "Izračunaj iznos";
            this.btnIzracunaj.UseVisualStyleBackColor = false;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnPodnesi
            // 
            this.btnPodnesi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPodnesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPodnesi.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodnesi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnPodnesi.Location = new System.Drawing.Point(65, 213);
            this.btnPodnesi.Name = "btnPodnesi";
            this.btnPodnesi.Size = new System.Drawing.Size(114, 25);
            this.btnPodnesi.TabIndex = 7;
            this.btnPodnesi.Text = "Podnesi ugovor";
            this.btnPodnesi.UseVisualStyleBackColor = false;
            this.btnPodnesi.Click += new System.EventHandler(this.btnPodnesi_Click);
            // 
            // PodnesiUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(241, 249);
            this.Controls.Add(this.btnPodnesi);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.lbIznos);
            this.Controls.Add(this.tbRS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRM);
            this.Controls.Add(this.lbMjesec);
            this.Controls.Add(this.lbStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PodnesiUgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podnesi ugovor";
            this.Load += new System.EventHandler(this.PodnesiUgovor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudent;
        private System.Windows.Forms.Label lbMjesec;
        private System.Windows.Forms.Label lbRM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRS;
        private System.Windows.Forms.Label lbIznos;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnPodnesi;
    }
}