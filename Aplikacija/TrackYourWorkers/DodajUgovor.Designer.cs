
namespace TrackYourWorkers
{
    partial class DodajUgovor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.cbRadnoMjesto = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.btnOtvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Odaberi studenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Odaberi radnu poziciju";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Početak rada";
            // 
            // cbStudent
            // 
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(169, 13);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(151, 21);
            this.cbStudent.TabIndex = 3;
            // 
            // cbRadnoMjesto
            // 
            this.cbRadnoMjesto.FormattingEnabled = true;
            this.cbRadnoMjesto.Location = new System.Drawing.Point(169, 45);
            this.cbRadnoMjesto.Name = "cbRadnoMjesto";
            this.cbRadnoMjesto.Size = new System.Drawing.Size(151, 21);
            this.cbRadnoMjesto.TabIndex = 4;
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(169, 80);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(102, 20);
            this.dtp.TabIndex = 5;
            // 
            // btnOtvori
            // 
            this.btnOtvori.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOtvori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtvori.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtvori.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnOtvori.Location = new System.Drawing.Point(92, 117);
            this.btnOtvori.Name = "btnOtvori";
            this.btnOtvori.Size = new System.Drawing.Size(155, 26);
            this.btnOtvori.TabIndex = 6;
            this.btnOtvori.Text = "Otvori ugovor";
            this.btnOtvori.UseVisualStyleBackColor = false;
            this.btnOtvori.Click += new System.EventHandler(this.btnOtvori_Click);
            // 
            // DodajUgovor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(334, 155);
            this.Controls.Add(this.btnOtvori);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cbRadnoMjesto);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DodajUgovor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novi ugovor";
            this.Load += new System.EventHandler(this.DodajUgovor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.ComboBox cbRadnoMjesto;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Button btnOtvori;
    }
}