
namespace Proiect_GlejaruCostin
{
    partial class SubstantivBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubstantivBD));
            this.listView1 = new System.Windows.Forms.ListView();
            this.Cuvant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Clasificare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Numar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Declinare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Provenienta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pronuntie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Regionalisme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Origine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Explicatii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.intoarcereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cuvant,
            this.Gen,
            this.Clasificare,
            this.Numar,
            this.Declinare,
            this.Provenienta,
            this.Pronuntie,
            this.Regionalisme,
            this.Origine,
            this.Explicatii});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(975, 463);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Cuvant
            // 
            this.Cuvant.Text = "Cuvant";
            this.Cuvant.Width = 81;
            // 
            // Gen
            // 
            this.Gen.Text = "Gen";
            // 
            // Clasificare
            // 
            this.Clasificare.Text = "Clasificare";
            this.Clasificare.Width = 77;
            // 
            // Numar
            // 
            this.Numar.Text = "Numar";
            // 
            // Declinare
            // 
            this.Declinare.Text = "Declinare";
            this.Declinare.Width = 78;
            // 
            // Provenienta
            // 
            this.Provenienta.Text = "Provenienta";
            this.Provenienta.Width = 89;
            // 
            // Pronuntie
            // 
            this.Pronuntie.Text = "Pronuntie";
            this.Pronuntie.Width = 84;
            // 
            // Regionalisme
            // 
            this.Regionalisme.Text = "Regionalisme";
            this.Regionalisme.Width = 101;
            // 
            // Origine
            // 
            this.Origine.Text = "Origine";
            // 
            // Explicatii
            // 
            this.Explicatii.Text = "Explicatii";
            this.Explicatii.Width = 241;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(281, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADAUGA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button2.Location = new System.Drawing.Point(416, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "STERGE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button3.Location = new System.Drawing.Point(558, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "UPDATE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button4.Location = new System.Drawing.Point(693, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 50);
            this.button4.TabIndex = 4;
            this.button4.Text = "PRINT";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intoarcereToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1194, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // intoarcereToolStripMenuItem
            // 
            this.intoarcereToolStripMenuItem.Name = "intoarcereToolStripMenuItem";
            this.intoarcereToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.intoarcereToolStripMenuItem.Text = "Intoarcere";
            this.intoarcereToolStripMenuItem.Click += new System.EventHandler(this.intoarcereToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // SubstantivBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1194, 545);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SubstantivBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubstantivBD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Cuvant;
        private System.Windows.Forms.ColumnHeader Gen;
        private System.Windows.Forms.ColumnHeader Clasificare;
        private System.Windows.Forms.ColumnHeader Numar;
        private System.Windows.Forms.ColumnHeader Declinare;
        private System.Windows.Forms.ColumnHeader Provenienta;
        private System.Windows.Forms.ColumnHeader Pronuntie;
        private System.Windows.Forms.ColumnHeader Regionalisme;
        private System.Windows.Forms.ColumnHeader Origine;
        private System.Windows.Forms.ColumnHeader Explicatii;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem intoarcereToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}