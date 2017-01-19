namespace LivePerformance
{
    partial class Bestelpagina
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
            this.gbpizzas = new System.Windows.Forms.GroupBox();
            this.lbpizzas = new System.Windows.Forms.ListBox();
            this.gbproducten = new System.Windows.Forms.GroupBox();
            this.lbproducten = new System.Windows.Forms.ListBox();
            this.gbbestelling = new System.Windows.Forms.GroupBox();
            this.btnbestel = new System.Windows.Forms.Button();
            this.lbprijs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbbestelling = new System.Windows.Forms.ListBox();
            this.btnaddpizza = new System.Windows.Forms.Button();
            this.btnaddproduct = new System.Windows.Forms.Button();
            this.btnklantnew = new System.Windows.Forms.Button();
            this.gbklant = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbadres = new System.Windows.Forms.TextBox();
            this.tbnaam = new System.Windows.Forms.TextBox();
            this.btnbestelling = new System.Windows.Forms.Button();
            this.lbgeplaatst = new System.Windows.Forms.Label();
            this.btnnieuw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbon = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbtime = new System.Windows.Forms.Label();
            this.cbbezorg = new System.Windows.Forms.CheckBox();
            this.gbpizzas.SuspendLayout();
            this.gbproducten.SuspendLayout();
            this.gbbestelling.SuspendLayout();
            this.gbklant.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpizzas
            // 
            this.gbpizzas.Controls.Add(this.lbpizzas);
            this.gbpizzas.Location = new System.Drawing.Point(12, 34);
            this.gbpizzas.Name = "gbpizzas";
            this.gbpizzas.Size = new System.Drawing.Size(324, 184);
            this.gbpizzas.TabIndex = 0;
            this.gbpizzas.TabStop = false;
            this.gbpizzas.Text = "Pizza\'s";
            // 
            // lbpizzas
            // 
            this.lbpizzas.FormattingEnabled = true;
            this.lbpizzas.Location = new System.Drawing.Point(6, 19);
            this.lbpizzas.Name = "lbpizzas";
            this.lbpizzas.Size = new System.Drawing.Size(312, 147);
            this.lbpizzas.TabIndex = 1;
            // 
            // gbproducten
            // 
            this.gbproducten.Controls.Add(this.lbproducten);
            this.gbproducten.Location = new System.Drawing.Point(12, 228);
            this.gbproducten.Name = "gbproducten";
            this.gbproducten.Size = new System.Drawing.Size(324, 179);
            this.gbproducten.TabIndex = 1;
            this.gbproducten.TabStop = false;
            this.gbproducten.Text = "Overige producten";
            // 
            // lbproducten
            // 
            this.lbproducten.FormattingEnabled = true;
            this.lbproducten.Location = new System.Drawing.Point(7, 20);
            this.lbproducten.Name = "lbproducten";
            this.lbproducten.Size = new System.Drawing.Size(311, 147);
            this.lbproducten.TabIndex = 0;
            // 
            // gbbestelling
            // 
            this.gbbestelling.Controls.Add(this.btnbestel);
            this.gbbestelling.Controls.Add(this.lbprijs);
            this.gbbestelling.Controls.Add(this.label1);
            this.gbbestelling.Controls.Add(this.lbbestelling);
            this.gbbestelling.Location = new System.Drawing.Point(423, 34);
            this.gbbestelling.Name = "gbbestelling";
            this.gbbestelling.Size = new System.Drawing.Size(178, 216);
            this.gbbestelling.TabIndex = 1;
            this.gbbestelling.TabStop = false;
            this.gbbestelling.Text = "Huidige bestelling";
            // 
            // btnbestel
            // 
            this.btnbestel.Location = new System.Drawing.Point(93, 187);
            this.btnbestel.Name = "btnbestel";
            this.btnbestel.Size = new System.Drawing.Size(75, 23);
            this.btnbestel.TabIndex = 4;
            this.btnbestel.Text = "Bestel";
            this.btnbestel.UseVisualStyleBackColor = true;
            this.btnbestel.Click += new System.EventHandler(this.btnbestel_Click);
            // 
            // lbprijs
            // 
            this.lbprijs.AutoSize = true;
            this.lbprijs.Location = new System.Drawing.Point(133, 171);
            this.lbprijs.Name = "lbprijs";
            this.lbprijs.Size = new System.Drawing.Size(10, 13);
            this.lbprijs.TabIndex = 2;
            this.lbprijs.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Totaal:";
            // 
            // lbbestelling
            // 
            this.lbbestelling.FormattingEnabled = true;
            this.lbbestelling.Location = new System.Drawing.Point(7, 19);
            this.lbbestelling.Name = "lbbestelling";
            this.lbbestelling.Size = new System.Drawing.Size(161, 147);
            this.lbbestelling.TabIndex = 0;
            // 
            // btnaddpizza
            // 
            this.btnaddpizza.Location = new System.Drawing.Point(342, 53);
            this.btnaddpizza.Name = "btnaddpizza";
            this.btnaddpizza.Size = new System.Drawing.Size(75, 23);
            this.btnaddpizza.TabIndex = 2;
            this.btnaddpizza.Text = "Add pizza";
            this.btnaddpizza.UseVisualStyleBackColor = true;
            this.btnaddpizza.Click += new System.EventHandler(this.btnaddpizza_Click);
            // 
            // btnaddproduct
            // 
            this.btnaddproduct.Location = new System.Drawing.Point(342, 248);
            this.btnaddproduct.Name = "btnaddproduct";
            this.btnaddproduct.Size = new System.Drawing.Size(75, 23);
            this.btnaddproduct.TabIndex = 3;
            this.btnaddproduct.Text = "Add product";
            this.btnaddproduct.UseVisualStyleBackColor = true;
            this.btnaddproduct.Click += new System.EventHandler(this.btnaddproduct_Click);
            // 
            // btnklantnew
            // 
            this.btnklantnew.Location = new System.Drawing.Point(481, 257);
            this.btnklantnew.Name = "btnklantnew";
            this.btnklantnew.Size = new System.Drawing.Size(110, 23);
            this.btnklantnew.TabIndex = 4;
            this.btnklantnew.Text = "Nieuwe klant?";
            this.btnklantnew.UseVisualStyleBackColor = true;
            this.btnklantnew.Visible = false;
            this.btnklantnew.Click += new System.EventHandler(this.btnklantnew_Click);
            // 
            // gbklant
            // 
            this.gbklant.Controls.Add(this.label3);
            this.gbklant.Controls.Add(this.label2);
            this.gbklant.Controls.Add(this.tbadres);
            this.gbklant.Controls.Add(this.tbnaam);
            this.gbklant.Location = new System.Drawing.Point(345, 286);
            this.gbklant.Name = "gbklant";
            this.gbklant.Size = new System.Drawing.Size(246, 73);
            this.gbklant.TabIndex = 5;
            this.gbklant.TabStop = false;
            this.gbklant.Text = "Klantgegevens";
            this.gbklant.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naam:";
            // 
            // tbadres
            // 
            this.tbadres.Location = new System.Drawing.Point(87, 46);
            this.tbadres.Name = "tbadres";
            this.tbadres.Size = new System.Drawing.Size(100, 20);
            this.tbadres.TabIndex = 1;
            // 
            // tbnaam
            // 
            this.tbnaam.Location = new System.Drawing.Point(87, 20);
            this.tbnaam.Name = "tbnaam";
            this.tbnaam.Size = new System.Drawing.Size(100, 20);
            this.tbnaam.TabIndex = 0;
            // 
            // btnbestelling
            // 
            this.btnbestelling.Location = new System.Drawing.Point(481, 384);
            this.btnbestelling.Name = "btnbestelling";
            this.btnbestelling.Size = new System.Drawing.Size(110, 23);
            this.btnbestelling.TabIndex = 6;
            this.btnbestelling.Text = "Complete order";
            this.btnbestelling.UseVisualStyleBackColor = true;
            this.btnbestelling.Visible = false;
            this.btnbestelling.Click += new System.EventHandler(this.btnbestelling_Click);
            // 
            // lbgeplaatst
            // 
            this.lbgeplaatst.AutoSize = true;
            this.lbgeplaatst.ForeColor = System.Drawing.Color.Red;
            this.lbgeplaatst.Location = new System.Drawing.Point(345, 366);
            this.lbgeplaatst.Name = "lbgeplaatst";
            this.lbgeplaatst.Size = new System.Drawing.Size(108, 13);
            this.lbgeplaatst.TabIndex = 7;
            this.lbgeplaatst.Text = "Bestelling is geplaatst";
            this.lbgeplaatst.Visible = false;
            // 
            // btnnieuw
            // 
            this.btnnieuw.Location = new System.Drawing.Point(343, 384);
            this.btnnieuw.Name = "btnnieuw";
            this.btnnieuw.Size = new System.Drawing.Size(110, 23);
            this.btnnieuw.TabIndex = 8;
            this.btnnieuw.Text = "Nieuwe bestelling";
            this.btnnieuw.UseVisualStyleBackColor = true;
            this.btnnieuw.Visible = false;
            this.btnnieuw.Click += new System.EventHandler(this.btnnieuw_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Terug naar hoofdpagina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnbon
            // 
            this.btnbon.Location = new System.Drawing.Point(481, 384);
            this.btnbon.Name = "btnbon";
            this.btnbon.Size = new System.Drawing.Size(110, 23);
            this.btnbon.TabIndex = 10;
            this.btnbon.Text = "Exporteer bon";
            this.btnbon.UseVisualStyleBackColor = true;
            this.btnbon.Visible = false;
            this.btnbon.Click += new System.EventHandler(this.btnbon_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbtime
            // 
            this.lbtime.AutoSize = true;
            this.lbtime.ForeColor = System.Drawing.Color.Black;
            this.lbtime.Location = new System.Drawing.Point(478, 366);
            this.lbtime.Name = "lbtime";
            this.lbtime.Size = new System.Drawing.Size(108, 13);
            this.lbtime.TabIndex = 11;
            this.lbtime.Text = "Bestelling is geplaatst";
            this.lbtime.Visible = false;
            // 
            // cbbezorg
            // 
            this.cbbezorg.AutoSize = true;
            this.cbbezorg.Location = new System.Drawing.Point(503, 413);
            this.cbbezorg.Name = "cbbezorg";
            this.cbbezorg.Size = new System.Drawing.Size(71, 17);
            this.cbbezorg.TabIndex = 5;
            this.cbbezorg.Text = "Bezorgen";
            this.cbbezorg.UseVisualStyleBackColor = true;
            // 
            // Bestelpagina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 435);
            this.Controls.Add(this.cbbezorg);
            this.Controls.Add(this.lbtime);
            this.Controls.Add(this.btnbon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnnieuw);
            this.Controls.Add(this.lbgeplaatst);
            this.Controls.Add(this.btnbestelling);
            this.Controls.Add(this.gbklant);
            this.Controls.Add(this.btnklantnew);
            this.Controls.Add(this.btnaddproduct);
            this.Controls.Add(this.btnaddpizza);
            this.Controls.Add(this.gbbestelling);
            this.Controls.Add(this.gbproducten);
            this.Controls.Add(this.gbpizzas);
            this.Name = "Bestelpagina";
            this.Text = "Bestelpagina";
            this.gbpizzas.ResumeLayout(false);
            this.gbproducten.ResumeLayout(false);
            this.gbbestelling.ResumeLayout(false);
            this.gbbestelling.PerformLayout();
            this.gbklant.ResumeLayout(false);
            this.gbklant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbpizzas;
        private System.Windows.Forms.ListBox lbpizzas;
        private System.Windows.Forms.GroupBox gbproducten;
        private System.Windows.Forms.ListBox lbproducten;
        private System.Windows.Forms.GroupBox gbbestelling;
        private System.Windows.Forms.ListBox lbbestelling;
        private System.Windows.Forms.Button btnaddpizza;
        private System.Windows.Forms.Button btnaddproduct;
        private System.Windows.Forms.Label lbprijs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnbestel;
        private System.Windows.Forms.Button btnklantnew;
        private System.Windows.Forms.GroupBox gbklant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbadres;
        private System.Windows.Forms.TextBox tbnaam;
        private System.Windows.Forms.Button btnbestelling;
        private System.Windows.Forms.Label lbgeplaatst;
        private System.Windows.Forms.Button btnnieuw;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbtime;
        private System.Windows.Forms.CheckBox cbbezorg;
    }
}