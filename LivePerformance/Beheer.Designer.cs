namespace LivePerformance
{
    partial class Beheer
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
            this.gbklanten = new System.Windows.Forms.GroupBox();
            this.lbklanten = new System.Windows.Forms.ListBox();
            this.btnterug = new System.Windows.Forms.Button();
            this.gbklanten.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbklanten
            // 
            this.gbklanten.Controls.Add(this.lbklanten);
            this.gbklanten.Location = new System.Drawing.Point(13, 22);
            this.gbklanten.Name = "gbklanten";
            this.gbklanten.Size = new System.Drawing.Size(262, 227);
            this.gbklanten.TabIndex = 0;
            this.gbklanten.TabStop = false;
            this.gbklanten.Text = "Klanten";
            // 
            // lbklanten
            // 
            this.lbklanten.FormattingEnabled = true;
            this.lbklanten.Location = new System.Drawing.Point(7, 20);
            this.lbklanten.Name = "lbklanten";
            this.lbklanten.Size = new System.Drawing.Size(237, 199);
            this.lbklanten.TabIndex = 0;
            // 
            // btnterug
            // 
            this.btnterug.Location = new System.Drawing.Point(281, 12);
            this.btnterug.Name = "btnterug";
            this.btnterug.Size = new System.Drawing.Size(141, 23);
            this.btnterug.TabIndex = 1;
            this.btnterug.Text = "Terug naar hoofdpagina";
            this.btnterug.UseVisualStyleBackColor = true;
            this.btnterug.Click += new System.EventHandler(this.btnterug_Click);
            // 
            // Beheer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 261);
            this.Controls.Add(this.btnterug);
            this.Controls.Add(this.gbklanten);
            this.Name = "Beheer";
            this.Text = "Beheer";
            this.gbklanten.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbklanten;
        private System.Windows.Forms.ListBox lbklanten;
        private System.Windows.Forms.Button btnterug;
    }
}