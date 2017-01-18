namespace LivePerformance
{
    partial class Voorraadsysteem
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
            this.lbvoorraad = new System.Windows.Forms.ListBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnremove = new System.Windows.Forms.Button();
            this.lbnaam = new System.Windows.Forms.Label();
            this.lbinkoopprijs = new System.Windows.Forms.Label();
            this.lbverkoopprijs = new System.Windows.Forms.Label();
            this.tbnaam = new System.Windows.Forms.TextBox();
            this.tbinkoop = new System.Windows.Forms.TextBox();
            this.tbverkoop = new System.Windows.Forms.TextBox();
            this.gbaddvoorraad = new System.Windows.Forms.GroupBox();
            this.gbaddvoorraad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvoorraad
            // 
            this.lbvoorraad.FormattingEnabled = true;
            this.lbvoorraad.Location = new System.Drawing.Point(12, 25);
            this.lbvoorraad.Name = "lbvoorraad";
            this.lbvoorraad.Size = new System.Drawing.Size(351, 264);
            this.lbvoorraad.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(369, 25);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(369, 54);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(369, 83);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            // 
            // lbnaam
            // 
            this.lbnaam.AutoSize = true;
            this.lbnaam.Location = new System.Drawing.Point(6, 25);
            this.lbnaam.Name = "lbnaam";
            this.lbnaam.Size = new System.Drawing.Size(38, 13);
            this.lbnaam.TabIndex = 4;
            this.lbnaam.Text = "Naam:";
            // 
            // lbinkoopprijs
            // 
            this.lbinkoopprijs.AutoSize = true;
            this.lbinkoopprijs.Location = new System.Drawing.Point(6, 52);
            this.lbinkoopprijs.Name = "lbinkoopprijs";
            this.lbinkoopprijs.Size = new System.Drawing.Size(61, 13);
            this.lbinkoopprijs.TabIndex = 5;
            this.lbinkoopprijs.Text = "Inkoopprijs:";
            // 
            // lbverkoopprijs
            // 
            this.lbverkoopprijs.AutoSize = true;
            this.lbverkoopprijs.Location = new System.Drawing.Point(6, 78);
            this.lbverkoopprijs.Name = "lbverkoopprijs";
            this.lbverkoopprijs.Size = new System.Drawing.Size(68, 13);
            this.lbverkoopprijs.TabIndex = 6;
            this.lbverkoopprijs.Text = "Verkoopprijs:";
            // 
            // tbnaam
            // 
            this.tbnaam.Location = new System.Drawing.Point(107, 22);
            this.tbnaam.Name = "tbnaam";
            this.tbnaam.Size = new System.Drawing.Size(100, 20);
            this.tbnaam.TabIndex = 7;
            // 
            // tbinkoop
            // 
            this.tbinkoop.Location = new System.Drawing.Point(107, 49);
            this.tbinkoop.Name = "tbinkoop";
            this.tbinkoop.Size = new System.Drawing.Size(100, 20);
            this.tbinkoop.TabIndex = 8;
            // 
            // tbverkoop
            // 
            this.tbverkoop.Location = new System.Drawing.Point(107, 75);
            this.tbverkoop.Name = "tbverkoop";
            this.tbverkoop.Size = new System.Drawing.Size(100, 20);
            this.tbverkoop.TabIndex = 9;
            // 
            // gbaddvoorraad
            // 
            this.gbaddvoorraad.Controls.Add(this.lbnaam);
            this.gbaddvoorraad.Controls.Add(this.tbverkoop);
            this.gbaddvoorraad.Controls.Add(this.lbinkoopprijs);
            this.gbaddvoorraad.Controls.Add(this.tbinkoop);
            this.gbaddvoorraad.Controls.Add(this.lbverkoopprijs);
            this.gbaddvoorraad.Controls.Add(this.tbnaam);
            this.gbaddvoorraad.Location = new System.Drawing.Point(369, 174);
            this.gbaddvoorraad.Name = "gbaddvoorraad";
            this.gbaddvoorraad.Size = new System.Drawing.Size(221, 115);
            this.gbaddvoorraad.TabIndex = 10;
            this.gbaddvoorraad.TabStop = false;
            this.gbaddvoorraad.Text = "Add voorraad:";
            // 
            // Voorraadsysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 315);
            this.Controls.Add(this.gbaddvoorraad);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbvoorraad);
            this.Name = "Voorraadsysteem";
            this.Text = "Voorraadsysteem";
            this.gbaddvoorraad.ResumeLayout(false);
            this.gbaddvoorraad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbvoorraad;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Label lbnaam;
        private System.Windows.Forms.Label lbinkoopprijs;
        private System.Windows.Forms.Label lbverkoopprijs;
        private System.Windows.Forms.TextBox tbnaam;
        private System.Windows.Forms.TextBox tbinkoop;
        private System.Windows.Forms.TextBox tbverkoop;
        private System.Windows.Forms.GroupBox gbaddvoorraad;
    }
}

