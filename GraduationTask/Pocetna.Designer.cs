
namespace GraduationTask
{
    partial class Pocetna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.Šifra = new System.Windows.Forms.ColumnHeader();
            this.Selo = new System.Windows.Forms.ColumnHeader();
            this.Grad = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.cbGrad = new System.Windows.Forms.ComboBox();
            this.btnUnesiIzmene = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDodeliVaucere = new System.Windows.Forms.ToolStripButton();
            this.btnOAplikaciji = new System.Windows.Forms.ToolStripButton();
            this.btnIzlaz = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Šifra,
            this.Selo,
            this.Grad});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(283, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(349, 352);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Šifra
            // 
            this.Šifra.Text = "Šifra";
            // 
            // Selo
            // 
            this.Selo.Text = "Selo";
            this.Selo.Width = 140;
            // 
            // Grad
            // 
            this.Grad.Text = "Grad";
            this.Grad.Width = 140;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Grad";
            // 
            // tbSifra
            // 
            this.tbSifra.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSifra.Location = new System.Drawing.Point(110, 52);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.Size = new System.Drawing.Size(100, 31);
            this.tbSifra.TabIndex = 4;
            this.tbSifra.TextChanged += new System.EventHandler(this.tbSifra_TextChanged);
            // 
            // tbNaziv
            // 
            this.tbNaziv.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNaziv.Location = new System.Drawing.Point(110, 116);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(143, 31);
            this.tbNaziv.TabIndex = 5;
            // 
            // cbGrad
            // 
            this.cbGrad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrad.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbGrad.FormattingEnabled = true;
            this.cbGrad.Location = new System.Drawing.Point(110, 170);
            this.cbGrad.Name = "cbGrad";
            this.cbGrad.Size = new System.Drawing.Size(143, 31);
            this.cbGrad.TabIndex = 6;
            // 
            // btnUnesiIzmene
            // 
            this.btnUnesiIzmene.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnesiIzmene.Location = new System.Drawing.Point(35, 307);
            this.btnUnesiIzmene.Name = "btnUnesiIzmene";
            this.btnUnesiIzmene.Size = new System.Drawing.Size(199, 45);
            this.btnUnesiIzmene.TabIndex = 7;
            this.btnUnesiIzmene.Text = "Unesi izmene >>>";
            this.btnUnesiIzmene.UseVisualStyleBackColor = true;
            this.btnUnesiIzmene.Click += new System.EventHandler(this.btnUnesiIzmene_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDodeliVaucere,
            this.btnOAplikaciji,
            this.btnIzlaz});
            this.toolStrip1.Location = new System.Drawing.Point(665, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(135, 450);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDodeliVaucere
            // 
            this.btnDodeliVaucere.CheckOnClick = true;
            this.btnDodeliVaucere.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDodeliVaucere.Image = global::GraduationTask.Properties.Resources.voucherImage;
            this.btnDodeliVaucere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDodeliVaucere.Name = "btnDodeliVaucere";
            this.btnDodeliVaucere.Size = new System.Drawing.Size(132, 45);
            this.btnDodeliVaucere.Text = "Dodeli Vaučere";
            this.btnDodeliVaucere.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDodeliVaucere.Click += new System.EventHandler(this.btnDodeliVaucere_Click);
            // 
            // btnOAplikaciji
            // 
            this.btnOAplikaciji.CheckOnClick = true;
            this.btnOAplikaciji.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOAplikaciji.Image = global::GraduationTask.Properties.Resources.Info;
            this.btnOAplikaciji.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOAplikaciji.Name = "btnOAplikaciji";
            this.btnOAplikaciji.Size = new System.Drawing.Size(132, 45);
            this.btnOAplikaciji.Text = "O Aplikaciji";
            this.btnOAplikaciji.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOAplikaciji.Click += new System.EventHandler(this.btnOAplikaciji_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.CheckOnClick = true;
            this.btnIzlaz.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIzlaz.Image = global::GraduationTask.Properties.Resources.Exit;
            this.btnIzlaz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(132, 45);
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnUnesiIzmene);
            this.Controls.Add(this.cbGrad);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Šifra;
        private System.Windows.Forms.ColumnHeader Selo;
        private System.Windows.Forms.ColumnHeader Grad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.ComboBox cbGrad;
        private System.Windows.Forms.Button btnUnesiIzmene;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDodeliVaucere;
        private System.Windows.Forms.ToolStripButton btnOAplikaciji;
        private System.Windows.Forms.ToolStripButton btnIzlaz;
    }
}

