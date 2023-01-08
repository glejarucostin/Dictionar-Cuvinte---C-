
namespace Proiect_GlejaruCostin
{
    partial class PronumeDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PronumeDB));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cuvant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tipul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tip_Pers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pronuntie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Regionalisme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Origine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Explicatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intoarcereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cuvant,
            this.Tipul,
            this.Numar,
            this.Tip_Pers,
            this.Pronuntie,
            this.Regionalisme,
            this.Origine,
            this.Explicatii});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(812, 482);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Cuvant
            // 
            this.Cuvant.Text = "Cuvant";
            // 
            // Tipul
            // 
            this.Tipul.Text = "Tipul";
            this.Tipul.Width = 69;
            // 
            // Numar
            // 
            this.Numar.Text = "Numar";
            this.Numar.Width = 74;
            // 
            // Tip_Pers
            // 
            this.Tip_Pers.Text = "Tip_Pers";
            this.Tip_Pers.Width = 74;
            // 
            // Pronuntie
            // 
            this.Pronuntie.Text = "Pronuntie";
            this.Pronuntie.Width = 100;
            // 
            // Regionalisme
            // 
            this.Regionalisme.Text = "Regionalisme";
            // 
            // Origine
            // 
            this.Origine.Text = "Origine";
            // 
            // Explicatii
            // 
            this.Explicatii.Text = "Explicatii";
            this.Explicatii.Width = 144;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(384, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intoarcereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intoarcereToolStripMenuItem
            // 
            this.intoarcereToolStripMenuItem.Name = "intoarcereToolStripMenuItem";
            this.intoarcereToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.intoarcereToolStripMenuItem.Text = "Intoarcere";
            this.intoarcereToolStripMenuItem.Click += new System.EventHandler(this.intoarcereToolStripMenuItem_Click);
            // 
            // PronumeDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(898, 564);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PronumeDB";
            this.Text = "PronumeDB";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cuvant;
        private System.Windows.Forms.ColumnHeader Tipul;
        private System.Windows.Forms.ColumnHeader Numar;
        private System.Windows.Forms.ColumnHeader Tip_Pers;
        private System.Windows.Forms.ColumnHeader Pronuntie;
        private System.Windows.Forms.ColumnHeader Regionalisme;
        private System.Windows.Forms.ColumnHeader Origine;
        private System.Windows.Forms.ColumnHeader Explicatii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intoarcereToolStripMenuItem;
    }
}