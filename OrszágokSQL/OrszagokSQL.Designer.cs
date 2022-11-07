namespace OrszágokSQL
{
    partial class OrszagokSQL
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
            this.list_Orszagok = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ID = new System.Windows.Forms.Label();
            this.OrszagNev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.orszag = new System.Windows.Forms.TextBox();
            this.fovaros = new System.Windows.Forms.TextBox();
            this.terulet = new System.Windows.Forms.TextBox();
            this.nepesseg = new System.Windows.Forms.TextBox();
            this.allamforma = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // list_Orszagok
            // 
            this.list_Orszagok.Dock = System.Windows.Forms.DockStyle.Left;
            this.list_Orszagok.FormattingEnabled = true;
            this.list_Orszagok.Location = new System.Drawing.Point(0, 0);
            this.list_Orszagok.Name = "list_Orszagok";
            this.list_Orszagok.Size = new System.Drawing.Size(179, 450);
            this.list_Orszagok.TabIndex = 0;
            this.list_Orszagok.SelectedIndexChanged += new System.EventHandler(this.list_Orszagok_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allamforma);
            this.groupBox1.Controls.Add(this.nepesseg);
            this.groupBox1.Controls.Add(this.terulet);
            this.groupBox1.Controls.Add(this.fovaros);
            this.groupBox1.Controls.Add(this.orszag);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.OrszagNev);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(179, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kivalasztott orszag maradekai";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(16, 32);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 0;
            this.ID.Text = "ID";
            // 
            // OrszagNev
            // 
            this.OrszagNev.AutoSize = true;
            this.OrszagNev.Location = new System.Drawing.Point(16, 57);
            this.OrszagNev.Name = "OrszagNev";
            this.OrszagNev.Size = new System.Drawing.Size(60, 13);
            this.OrszagNev.TabIndex = 1;
            this.OrszagNev.Text = "OrszagNev";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Főváros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Terület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Népesség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Államforma";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(35, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // orszag
            // 
            this.orszag.Location = new System.Drawing.Point(105, 56);
            this.orszag.Name = "orszag";
            this.orszag.Size = new System.Drawing.Size(147, 20);
            this.orszag.TabIndex = 7;
            this.orszag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fovaros
            // 
            this.fovaros.Location = new System.Drawing.Point(105, 86);
            this.fovaros.Name = "fovaros";
            this.fovaros.Size = new System.Drawing.Size(146, 20);
            this.fovaros.TabIndex = 8;
            this.fovaros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // terulet
            // 
            this.terulet.Location = new System.Drawing.Point(105, 115);
            this.terulet.Name = "terulet";
            this.terulet.Size = new System.Drawing.Size(90, 20);
            this.terulet.TabIndex = 9;
            this.terulet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nepesseg
            // 
            this.nepesseg.Location = new System.Drawing.Point(105, 145);
            this.nepesseg.Name = "nepesseg";
            this.nepesseg.Size = new System.Drawing.Size(90, 20);
            this.nepesseg.TabIndex = 10;
            this.nepesseg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // allamforma
            // 
            this.allamforma.Location = new System.Drawing.Point(105, 177);
            this.allamforma.Name = "allamforma";
            this.allamforma.Size = new System.Drawing.Size(144, 20);
            this.allamforma.TabIndex = 11;
            this.allamforma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OrszagokSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.list_Orszagok);
            this.Name = "OrszagokSQL";
            this.Text = "FormOrszagok";
            this.Load += new System.EventHandler(this.OrszagokSQL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_Orszagok;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox allamforma;
        private System.Windows.Forms.TextBox nepesseg;
        private System.Windows.Forms.TextBox terulet;
        private System.Windows.Forms.TextBox fovaros;
        private System.Windows.Forms.TextBox orszag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OrszagNev;
        private System.Windows.Forms.Label ID;
    }
}

