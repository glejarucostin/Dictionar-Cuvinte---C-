
namespace Proiect_GlejaruCostin
{
    partial class Adjectiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adjectiv));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intoarcereMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatiiCuFisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbClasificare = new System.Windows.Forms.ComboBox();
            this.cbMijloc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbValoarea = new System.Windows.Forms.ComboBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPronuntie = new System.Windows.Forms.TextBox();
            this.tbCuvant = new System.Windows.Forms.TextBox();
            this.tbRegionalisme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrigine = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbExplicati = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.scriereFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.operatiiCuFisiereToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intoarcereMainToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // intoarcereMainToolStripMenuItem
            // 
            this.intoarcereMainToolStripMenuItem.Name = "intoarcereMainToolStripMenuItem";
            this.intoarcereMainToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.intoarcereMainToolStripMenuItem.Text = "Intoarcere Main";
            this.intoarcereMainToolStripMenuItem.Click += new System.EventHandler(this.intoarcereMainToolStripMenuItem_Click);
            // 
            // operatiiCuFisiereToolStripMenuItem
            // 
            this.operatiiCuFisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem1,
            this.deserializareToolStripMenuItem1});
            this.operatiiCuFisiereToolStripMenuItem.Name = "operatiiCuFisiereToolStripMenuItem";
            this.operatiiCuFisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.operatiiCuFisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // serializareToolStripMenuItem1
            // 
            this.serializareToolStripMenuItem1.Name = "serializareToolStripMenuItem1";
            this.serializareToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.serializareToolStripMenuItem1.Text = "Serializare";
            this.serializareToolStripMenuItem1.Click += new System.EventHandler(this.serializareToolStripMenuItem1_Click);
            // 
            // deserializareToolStripMenuItem1
            // 
            this.deserializareToolStripMenuItem1.Name = "deserializareToolStripMenuItem1";
            this.deserializareToolStripMenuItem1.Size = new System.Drawing.Size(178, 26);
            this.deserializareToolStripMenuItem1.Text = "Deserializare";
            this.deserializareToolStripMenuItem1.Click += new System.EventHandler(this.deserializareToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            this.bazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazaDeDateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clasificare";
            // 
            // cbClasificare
            // 
            this.cbClasificare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbClasificare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClasificare.FormattingEnabled = true;
            this.cbClasificare.Items.AddRange(new object[] {
            "substantival",
            "adjectival",
            "pronominal",
            "numeral",
            "verbal",
            "adverbial",
            "interjectional"});
            this.cbClasificare.Location = new System.Drawing.Point(710, 70);
            this.cbClasificare.Name = "cbClasificare";
            this.cbClasificare.Size = new System.Drawing.Size(121, 30);
            this.cbClasificare.TabIndex = 3;
            // 
            // cbMijloc
            // 
            this.cbMijloc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbMijloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMijloc.FormattingEnabled = true;
            this.cbMijloc.Items.AddRange(new object[] {
            "substantiv",
            "adjectiv",
            "pronume",
            "numeral",
            "verb",
            "adverb",
            "interjectie"});
            this.cbMijloc.Location = new System.Drawing.Point(710, 105);
            this.cbMijloc.Name = "cbMijloc";
            this.cbMijloc.Size = new System.Drawing.Size(120, 30);
            this.cbMijloc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mijloc exprimare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valoare stilistica";
            // 
            // cbValoarea
            // 
            this.cbValoarea.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbValoarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbValoarea.FormattingEnabled = true;
            this.cbValoarea.Items.AddRange(new object[] {
            "epitet",
            "comparatie",
            "metafora"});
            this.cbValoarea.Location = new System.Drawing.Point(710, 140);
            this.cbValoarea.Name = "cbValoarea";
            this.cbValoarea.Size = new System.Drawing.Size(120, 30);
            this.cbValoarea.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Coral;
            this.btnAdauga.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAdauga.Location = new System.Drawing.Point(12, 444);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(85, 48);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(755, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 48);
            this.button2.TabIndex = 9;
            this.button2.Text = "A&fisare";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAfisare
            // 
            this.tbAfisare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbAfisare.Location = new System.Drawing.Point(243, 434);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.Size = new System.Drawing.Size(282, 58);
            this.tbAfisare.TabIndex = 11;
            this.tbAfisare.TextChanged += new System.EventHandler(this.tbAfisare_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Cuvant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pronuntie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Regionalisme";
            // 
            // tbPronuntie
            // 
            this.tbPronuntie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPronuntie.Location = new System.Drawing.Point(710, 175);
            this.tbPronuntie.Name = "tbPronuntie";
            this.tbPronuntie.Size = new System.Drawing.Size(118, 28);
            this.tbPronuntie.TabIndex = 15;
            // 
            // tbCuvant
            // 
            this.tbCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvant.Location = new System.Drawing.Point(710, 35);
            this.tbCuvant.Name = "tbCuvant";
            this.tbCuvant.Size = new System.Drawing.Size(122, 28);
            this.tbCuvant.TabIndex = 16;
            // 
            // tbRegionalisme
            // 
            this.tbRegionalisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegionalisme.Location = new System.Drawing.Point(710, 210);
            this.tbRegionalisme.Name = "tbRegionalisme";
            this.tbRegionalisme.Size = new System.Drawing.Size(118, 28);
            this.tbRegionalisme.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 18;
            this.label7.Text = "Origine";
            // 
            // tbOrigine
            // 
            this.tbOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigine.Location = new System.Drawing.Point(710, 245);
            this.tbOrigine.Name = "tbOrigine";
            this.tbOrigine.Size = new System.Drawing.Size(118, 28);
            this.tbOrigine.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Explicatii";
            // 
            // tbExplicati
            // 
            this.tbExplicati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExplicati.Location = new System.Drawing.Point(635, 280);
            this.tbExplicati.Multiline = true;
            this.tbExplicati.Name = "tbExplicati";
            this.tbExplicati.Size = new System.Drawing.Size(198, 79);
            this.tbExplicati.TabIndex = 21;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriereFisierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 28);
            // 
            // scriereFisierToolStripMenuItem
            // 
            this.scriereFisierToolStripMenuItem.Name = "scriereFisierToolStripMenuItem";
            this.scriereFisierToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.scriereFisierToolStripMenuItem.Text = "Scriere fisier";
            this.scriereFisierToolStripMenuItem.Click += new System.EventHandler(this.scriereFisierToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(649, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 48);
            this.button1.TabIndex = 22;
            this.button1.Text = "SAVEBD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adjectiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(840, 504);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbExplicati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOrigine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRegionalisme);
            this.Controls.Add(this.tbCuvant);
            this.Controls.Add(this.tbPronuntie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.cbValoarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMijloc);
            this.Controls.Add(this.cbClasificare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Adjectiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intoarcereMainToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbClasificare;
        private System.Windows.Forms.ComboBox cbMijloc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbValoarea;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPronuntie;
        private System.Windows.Forms.TextBox tbCuvant;
        private System.Windows.Forms.TextBox tbRegionalisme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrigine;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbExplicati;
        private System.Windows.Forms.ToolStripMenuItem operatiiCuFisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem scriereFisierToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
    }
}