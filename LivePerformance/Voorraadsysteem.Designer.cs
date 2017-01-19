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
            this.gbaddproduct = new System.Windows.Forms.GroupBox();
            this.btneditproduct = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.tbbtw = new System.Windows.Forms.TextBox();
            this.lbbtw = new System.Windows.Forms.Label();
            this.btnshowproduct = new System.Windows.Forms.Button();
            this.btnshowingredienten = new System.Windows.Forms.Button();
            this.btnhoofdpagina = new System.Windows.Forms.Button();
            this.btnsortproduct = new System.Windows.Forms.Button();
            this.gbaddproduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbvoorraad
            // 
            this.lbvoorraad.FormattingEnabled = true;
            this.lbvoorraad.Location = new System.Drawing.Point(12, 46);
            this.lbvoorraad.Name = "lbvoorraad";
            this.lbvoorraad.Size = new System.Drawing.Size(351, 264);
            this.lbvoorraad.TabIndex = 0;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(369, 46);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add ";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(369, 75);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnremove
            // 
            this.btnremove.Location = new System.Drawing.Point(369, 104);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(75, 23);
            this.btnremove.TabIndex = 3;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
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
            // gbaddproduct
            // 
            this.gbaddproduct.Controls.Add(this.btneditproduct);
            this.gbaddproduct.Controls.Add(this.btnaddproduct);
            this.gbaddproduct.Controls.Add(this.tbbtw);
            this.gbaddproduct.Controls.Add(this.lbbtw);
            this.gbaddproduct.Controls.Add(this.lbnaam);
            this.gbaddproduct.Controls.Add(this.tbverkoop);
            this.gbaddproduct.Controls.Add(this.lbinkoopprijs);
            this.gbaddproduct.Controls.Add(this.tbinkoop);
            this.gbaddproduct.Controls.Add(this.lbverkoopprijs);
            this.gbaddproduct.Controls.Add(this.tbnaam);
            this.gbaddproduct.Location = new System.Drawing.Point(369, 163);
            this.gbaddproduct.Name = "gbaddproduct";
            this.gbaddproduct.Size = new System.Drawing.Size(231, 161);
            this.gbaddproduct.TabIndex = 10;
            this.gbaddproduct.TabStop = false;
            this.gbaddproduct.Text = "Add product:";
            this.gbaddproduct.Visible = false;
            // 
            // btneditproduct
            // 
            this.btneditproduct.Location = new System.Drawing.Point(9, 132);
            this.btneditproduct.Name = "btneditproduct";
            this.btneditproduct.Size = new System.Drawing.Size(75, 23);
            this.btneditproduct.TabIndex = 12;
            this.btneditproduct.Text = "Edit";
            this.btneditproduct.UseVisualStyleBackColor = true;
            this.btneditproduct.UseWaitCursor = true;
            this.btneditproduct.Click += new System.EventHandler(this.btneditproduct_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(150, 132);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(75, 23);
            this.btnaddproduct.TabIndex = 11;
            this.btnaddproduct.Text = "Add";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.UseWaitCursor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // tbbtw
            // 
            this.tbbtw.Location = new System.Drawing.Point(107, 101);
            this.tbbtw.Name = "tbbtw";
            this.tbbtw.Size = new System.Drawing.Size(100, 20);
            this.tbbtw.TabIndex = 11;
            // 
            // lbbtw
            // 
            this.lbbtw.AutoSize = true;
            this.lbbtw.Location = new System.Drawing.Point(6, 104);
            this.lbbtw.Name = "lbbtw";
            this.lbbtw.Size = new System.Drawing.Size(32, 13);
            this.lbbtw.TabIndex = 10;
            this.lbbtw.Text = "BTW";
            // 
            // btnshowproduct
            // 
            this.btnshowproduct.Location = new System.Drawing.Point(12, 17);
            this.btnshowproduct.Name = "btnshowproduct";
            this.btnshowproduct.Size = new System.Drawing.Size(75, 23);
            this.btnshowproduct.TabIndex = 11;
            this.btnshowproduct.Text = "Producten";
            this.btnshowproduct.UseVisualStyleBackColor = true;
            this.btnshowproduct.Click += new System.EventHandler(this.btnshowproduct_Click);
            // 
            // btnshowingredienten
            // 
            this.btnshowingredienten.Location = new System.Drawing.Point(93, 17);
            this.btnshowingredienten.Name = "btnshowingredienten";
            this.btnshowingredienten.Size = new System.Drawing.Size(75, 23);
            this.btnshowingredienten.TabIndex = 12;
            this.btnshowingredienten.Text = "Ingrediënten";
            this.btnshowingredienten.UseVisualStyleBackColor = true;
            this.btnshowingredienten.Click += new System.EventHandler(this.btnshowingredienten_Click);
            // 
            // btnhoofdpagina
            // 
            this.btnhoofdpagina.Location = new System.Drawing.Point(505, 12);
            this.btnhoofdpagina.Name = "btnhoofdpagina";
            this.btnhoofdpagina.Size = new System.Drawing.Size(131, 23);
            this.btnhoofdpagina.TabIndex = 13;
            this.btnhoofdpagina.Text = "Terug naar hoofdpagina";
            this.btnhoofdpagina.UseVisualStyleBackColor = true;
            this.btnhoofdpagina.Click += new System.EventHandler(this.btnhoofdpagina_Click);
            // 
            // btnsortproduct
            // 
            this.btnsortproduct.Location = new System.Drawing.Point(12, 316);
            this.btnsortproduct.Name = "btnsortproduct";
            this.btnsortproduct.Size = new System.Drawing.Size(75, 23);
            this.btnsortproduct.TabIndex = 14;
            this.btnsortproduct.Text = "Sorteer";
            this.btnsortproduct.UseVisualStyleBackColor = true;
            this.btnsortproduct.Click += new System.EventHandler(this.btnsortproduct_Click);
            // 
            // Voorraadsysteem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 343);
            this.Controls.Add(this.btnsortproduct);
            this.Controls.Add(this.btnhoofdpagina);
            this.Controls.Add(this.btnshowingredienten);
            this.Controls.Add(this.btnshowproduct);
            this.Controls.Add(this.gbaddproduct);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lbvoorraad);
            this.Name = "Voorraadsysteem";
            this.Text = "Voorraadsysteem";
            this.gbaddproduct.ResumeLayout(false);
            this.gbaddproduct.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbaddproduct;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.TextBox tbbtw;
        private System.Windows.Forms.Label lbbtw;
        private System.Windows.Forms.Button btnshowproduct;
        private System.Windows.Forms.Button btnshowingredienten;
        private System.Windows.Forms.Button btneditproduct;
        private System.Windows.Forms.Button btnhoofdpagina;
        private System.Windows.Forms.Button btnsortproduct;
    }
}

