namespace LivePerformance
{
    partial class Hoofdpagina
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
            this.btnvoorraad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbestelpagina = new System.Windows.Forms.Button();
            this.btnbeheer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnvoorraad
            // 
            this.btnvoorraad.Location = new System.Drawing.Point(6, 19);
            this.btnvoorraad.Name = "btnvoorraad";
            this.btnvoorraad.Size = new System.Drawing.Size(204, 23);
            this.btnvoorraad.TabIndex = 0;
            this.btnvoorraad.Text = "Ga naar voorraadadministratie";
            this.btnvoorraad.UseVisualStyleBackColor = true;
            this.btnvoorraad.Click += new System.EventHandler(this.btnvoorraad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbeheer);
            this.groupBox1.Controls.Add(this.btnbestelpagina);
            this.groupBox1.Controls.Add(this.btnvoorraad);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pizzeria La Crosta hoofdmenu";
            // 
            // btnbestelpagina
            // 
            this.btnbestelpagina.Location = new System.Drawing.Point(6, 48);
            this.btnbestelpagina.Name = "btnbestelpagina";
            this.btnbestelpagina.Size = new System.Drawing.Size(204, 23);
            this.btnbestelpagina.TabIndex = 1;
            this.btnbestelpagina.Text = "Ga naar bestellen";
            this.btnbestelpagina.UseVisualStyleBackColor = true;
            this.btnbestelpagina.Click += new System.EventHandler(this.btnbestelpagina_Click);
            // 
            // btnbeheer
            // 
            this.btnbeheer.Location = new System.Drawing.Point(6, 77);
            this.btnbeheer.Name = "btnbeheer";
            this.btnbeheer.Size = new System.Drawing.Size(204, 23);
            this.btnbeheer.TabIndex = 2;
            this.btnbeheer.Text = "Ga naar beheer";
            this.btnbeheer.UseVisualStyleBackColor = true;
            this.btnbeheer.Click += new System.EventHandler(this.btnbeheer_Click);
            // 
            // Hoofdpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 177);
            this.Controls.Add(this.groupBox1);
            this.Name = "Hoofdpagina";
            this.Text = "Hoofdpagina";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnvoorraad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbestelpagina;
        private System.Windows.Forms.Button btnbeheer;
    }
}