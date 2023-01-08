
namespace Proiect_GlejaruCostin
{
    partial class Substantiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Substantiv));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intoarcereLaRomana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbGen = new System.Windows.Forms.ComboBox();
            this.cbClasificare = new System.Windows.Forms.ComboBox();
            this.cbNumar = new System.Windows.Forms.ComboBox();
            this.cbDeclinare = new System.Windows.Forms.ComboBox();
            this.cbProvenienta = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.tbExplicati = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbOrigine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRegionalisme = new System.Windows.Forms.TextBox();
            this.tbPronuntie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCuvant = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
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
            this.fisiereToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.bazaDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intoarcereLaRomana1ToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // intoarcereLaRomana1ToolStripMenuItem
            // 
            this.intoarcereLaRomana1ToolStripMenuItem.Name = "intoarcereLaRomana1ToolStripMenuItem";
            this.intoarcereLaRomana1ToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.intoarcereLaRomana1ToolStripMenuItem.Text = "Intoarcere Main";
            this.intoarcereLaRomana1ToolStripMenuItem.Click += new System.EventHandler(this.intoarcereLaRomana1ToolStripMenuItem_Click);
            // 
            // fisiereToolStripMenuItem
            // 
            this.fisiereToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            this.fisiereToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.serializareToolStripMenuItem.Text = "Serializare";
            this.serializareToolStripMenuItem.Click += new System.EventHandler(this.serializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.deserializareToolStripMenuItem.Text = "Deserializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bazaDeDateToolStripMenuItem
            // 
            this.bazaDeDateToolStripMenuItem.Name = "bazaDeDateToolStripMenuItem";
            this.bazaDeDateToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bazaDeDateToolStripMenuItem.Text = "Baza de date";
            this.bazaDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazaDeDateToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 28);
            // 
            // salvareFisierToolStripMenuItem
            // 
            this.salvareFisierToolStripMenuItem.Name = "salvareFisierToolStripMenuItem";
            this.salvareFisierToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.salvareFisierToolStripMenuItem.Text = "Salvare fisier";
            this.salvareFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clasificare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Declinare";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Provenienta";
            // 
            // cbGen
            // 
            this.cbGen.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbGen.FormattingEnabled = true;
            this.cbGen.Items.AddRange(new object[] {
            "masculin",
            "feminin",
            "neutru"});
            this.cbGen.Location = new System.Drawing.Point(704, 70);
            this.cbGen.Name = "cbGen";
            this.cbGen.Size = new System.Drawing.Size(122, 24);
            this.cbGen.TabIndex = 6;
            // 
            // cbClasificare
            // 
            this.cbClasificare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbClasificare.FormattingEnabled = true;
            this.cbClasificare.Items.AddRange(new object[] {
            "comun",
            "propriu"});
            this.cbClasificare.Location = new System.Drawing.Point(704, 105);
            this.cbClasificare.Name = "cbClasificare";
            this.cbClasificare.Size = new System.Drawing.Size(122, 24);
            this.cbClasificare.TabIndex = 7;
            // 
            // cbNumar
            // 
            this.cbNumar.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbNumar.FormattingEnabled = true;
            this.cbNumar.Items.AddRange(new object[] {
            "singular",
            "plural"});
            this.cbNumar.Location = new System.Drawing.Point(704, 140);
            this.cbNumar.Name = "cbNumar";
            this.cbNumar.Size = new System.Drawing.Size(122, 24);
            this.cbNumar.TabIndex = 8;
            // 
            // cbDeclinare
            // 
            this.cbDeclinare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbDeclinare.FormattingEnabled = true;
            this.cbDeclinare.Items.AddRange(new object[] {
            "subiect",
            "atribut",
            "coplement",
            "nume_predicativ"});
            this.cbDeclinare.Location = new System.Drawing.Point(704, 175);
            this.cbDeclinare.Name = "cbDeclinare";
            this.cbDeclinare.Size = new System.Drawing.Size(122, 24);
            this.cbDeclinare.TabIndex = 9;
            // 
            // cbProvenienta
            // 
            this.cbProvenienta.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbProvenienta.FormattingEnabled = true;
            this.cbProvenienta.Items.AddRange(new object[] {
            "adjectiv",
            "numeral",
            "compunere",
            "verb",
            "adverb",
            "conversiune"});
            this.cbProvenienta.Location = new System.Drawing.Point(704, 210);
            this.cbProvenienta.Name = "cbProvenienta";
            this.cbProvenienta.Size = new System.Drawing.Size(122, 24);
            this.cbProvenienta.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button2.Location = new System.Drawing.Point(15, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "Adauga";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbAfisare
            // 
            this.tbAfisare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbAfisare.Location = new System.Drawing.Point(228, 464);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.Size = new System.Drawing.Size(304, 60);
            this.tbAfisare.TabIndex = 14;
            this.tbAfisare.TextChanged += new System.EventHandler(this.tbAfisare_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button3.Location = new System.Drawing.Point(726, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 60);
            this.button3.TabIndex = 15;
            this.button3.Text = "Afisare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbExplicati
            // 
            this.tbExplicati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExplicati.Location = new System.Drawing.Point(629, 345);
            this.tbExplicati.Multiline = true;
            this.tbExplicati.Name = "tbExplicati";
            this.tbExplicati.Size = new System.Drawing.Size(198, 79);
            this.tbExplicati.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Explicatii";
            // 
            // tbOrigine
            // 
            this.tbOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigine.Location = new System.Drawing.Point(704, 310);
            this.tbOrigine.Name = "tbOrigine";
            this.tbOrigine.Size = new System.Drawing.Size(122, 28);
            this.tbOrigine.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 26;
            this.label7.Text = "Origine";
            // 
            // tbRegionalisme
            // 
            this.tbRegionalisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegionalisme.Location = new System.Drawing.Point(704, 275);
            this.tbRegionalisme.Name = "tbRegionalisme";
            this.tbRegionalisme.Size = new System.Drawing.Size(122, 28);
            this.tbRegionalisme.TabIndex = 25;
            // 
            // tbPronuntie
            // 
            this.tbPronuntie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPronuntie.Location = new System.Drawing.Point(704, 245);
            this.tbPronuntie.Name = "tbPronuntie";
            this.tbPronuntie.Size = new System.Drawing.Size(122, 28);
            this.tbPronuntie.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Regionalisme";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "Pronuntie";
            // 
            // tbCuvant
            // 
            this.tbCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvant.Location = new System.Drawing.Point(704, 35);
            this.tbCuvant.Name = "tbCuvant";
            this.tbCuvant.Size = new System.Drawing.Size(122, 28);
            this.tbCuvant.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Cuvant";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(607, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 60);
            this.button1.TabIndex = 32;
            this.button1.Text = "SCRIE BD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Substantiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 531);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCuvant);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbExplicati);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbOrigine);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRegionalisme);
            this.Controls.Add(this.tbPronuntie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbProvenienta);
            this.Controls.Add(this.cbDeclinare);
            this.Controls.Add(this.cbNumar);
            this.Controls.Add(this.cbClasificare);
            this.Controls.Add(this.cbGen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Substantiv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Substantiv";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intoarcereLaRomana1ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbGen;
        private System.Windows.Forms.ComboBox cbClasificare;
        private System.Windows.Forms.ComboBox cbNumar;
        private System.Windows.Forms.ComboBox cbDeclinare;
        private System.Windows.Forms.ComboBox cbProvenienta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox tbExplicati;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbOrigine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRegionalisme;
        private System.Windows.Forms.TextBox tbPronuntie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCuvant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem bazaDeDateToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}