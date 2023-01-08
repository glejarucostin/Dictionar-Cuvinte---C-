
namespace Proiect_GlejaruCostin
{
    partial class Adverb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adverb));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intoarcereLaRomana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intoarcereLaMainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisiereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbnAfisare = new System.Windows.Forms.Button();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tbExplicati = new System.Windows.Forms.TextBox();
            this.lb10 = new System.Windows.Forms.Label();
            this.tbOrigine = new System.Windows.Forms.TextBox();
            this.lb9 = new System.Windows.Forms.Label();
            this.tbRegionalisme = new System.Windows.Forms.TextBox();
            this.tbCuvant = new System.Windows.Forms.TextBox();
            this.tbPronuntie = new System.Windows.Forms.TextBox();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.cbFunctie = new System.Windows.Forms.ComboBox();
            this.cbContext = new System.Windows.Forms.ComboBox();
            this.cbGradComp = new System.Windows.Forms.ComboBox();
            this.cbCategorieAdverb = new System.Windows.Forms.ComboBox();
            this.cbTipAdverb = new System.Windows.Forms.ComboBox();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bazeDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.bazeDeDateToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intoarcereLaRomana1ToolStripMenuItem,
            this.intoarcereLaMainToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // intoarcereLaRomana1ToolStripMenuItem
            // 
            this.intoarcereLaRomana1ToolStripMenuItem.Name = "intoarcereLaRomana1ToolStripMenuItem";
            this.intoarcereLaRomana1ToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.intoarcereLaRomana1ToolStripMenuItem.Text = "Intoarcere la Romana1";
            this.intoarcereLaRomana1ToolStripMenuItem.Click += new System.EventHandler(this.intoarcereLaRomana1ToolStripMenuItem_Click);
            // 
            // intoarcereLaMainToolStripMenuItem
            // 
            this.intoarcereLaMainToolStripMenuItem.Name = "intoarcereLaMainToolStripMenuItem";
            this.intoarcereLaMainToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.intoarcereLaMainToolStripMenuItem.Text = "Intoarcere la Main";
            this.intoarcereLaMainToolStripMenuItem.Click += new System.EventHandler(this.intoarcereLaMainToolStripMenuItem_Click);
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
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Coral;
            this.btnAdauga.ForeColor = System.Drawing.Color.DarkOrchid;
            this.btnAdauga.Location = new System.Drawing.Point(16, 449);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(82, 51);
            this.btnAdauga.TabIndex = 1;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbnAfisare
            // 
            this.tbnAfisare.BackColor = System.Drawing.Color.Coral;
            this.tbnAfisare.ForeColor = System.Drawing.Color.DarkOrchid;
            this.tbnAfisare.Location = new System.Drawing.Point(823, 449);
            this.tbnAfisare.Name = "tbnAfisare";
            this.tbnAfisare.Size = new System.Drawing.Size(82, 51);
            this.tbnAfisare.TabIndex = 2;
            this.tbnAfisare.Text = "A&fisare";
            this.tbnAfisare.UseVisualStyleBackColor = false;
            this.tbnAfisare.Click += new System.EventHandler(this.tbnAfisare_Click);
            // 
            // tbAfisare
            // 
            this.tbAfisare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbAfisare.Location = new System.Drawing.Point(274, 449);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.Size = new System.Drawing.Size(366, 62);
            this.tbAfisare.TabIndex = 4;
            this.tbAfisare.TextChanged += new System.EventHandler(this.tbAfisare_TextChanged);
            // 
            // tbExplicati
            // 
            this.tbExplicati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExplicati.Location = new System.Drawing.Point(714, 343);
            this.tbExplicati.Multiline = true;
            this.tbExplicati.Name = "tbExplicati";
            this.tbExplicati.Size = new System.Drawing.Size(198, 79);
            this.tbExplicati.TabIndex = 31;
            // 
            // lb10
            // 
            this.lb10.AutoSize = true;
            this.lb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb10.Location = new System.Drawing.Point(13, 350);
            this.lb10.Name = "lb10";
            this.lb10.Size = new System.Drawing.Size(84, 24);
            this.lb10.TabIndex = 30;
            this.lb10.Text = "Explicatii";
            // 
            // tbOrigine
            // 
            this.tbOrigine.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigine.Location = new System.Drawing.Point(794, 310);
            this.tbOrigine.Name = "tbOrigine";
            this.tbOrigine.Size = new System.Drawing.Size(118, 28);
            this.tbOrigine.TabIndex = 29;
            // 
            // lb9
            // 
            this.lb9.AutoSize = true;
            this.lb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb9.Location = new System.Drawing.Point(13, 315);
            this.lb9.Name = "lb9";
            this.lb9.Size = new System.Drawing.Size(72, 24);
            this.lb9.TabIndex = 28;
            this.lb9.Text = "Origine";
            // 
            // tbRegionalisme
            // 
            this.tbRegionalisme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRegionalisme.Location = new System.Drawing.Point(794, 275);
            this.tbRegionalisme.Name = "tbRegionalisme";
            this.tbRegionalisme.Size = new System.Drawing.Size(118, 28);
            this.tbRegionalisme.TabIndex = 27;
            // 
            // tbCuvant
            // 
            this.tbCuvant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCuvant.Location = new System.Drawing.Point(794, 35);
            this.tbCuvant.Name = "tbCuvant";
            this.tbCuvant.Size = new System.Drawing.Size(118, 28);
            this.tbCuvant.TabIndex = 26;
            // 
            // tbPronuntie
            // 
            this.tbPronuntie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPronuntie.Location = new System.Drawing.Point(794, 245);
            this.tbPronuntie.Name = "tbPronuntie";
            this.tbPronuntie.Size = new System.Drawing.Size(118, 28);
            this.tbPronuntie.TabIndex = 25;
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.Location = new System.Drawing.Point(13, 280);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(125, 24);
            this.lb8.TabIndex = 24;
            this.lb8.Text = "Regionalisme";
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.Location = new System.Drawing.Point(13, 245);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(91, 24);
            this.lb7.TabIndex = 23;
            this.lb7.Text = "Pronuntie";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(13, 40);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(68, 24);
            this.lb1.TabIndex = 22;
            this.lb1.Text = "Cuvant";
            // 
            // cbFunctie
            // 
            this.cbFunctie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbFunctie.FormattingEnabled = true;
            this.cbFunctie.Items.AddRange(new object[] {
            "atribut",
            "nume_predicativ",
            "complement"});
            this.cbFunctie.Location = new System.Drawing.Point(794, 210);
            this.cbFunctie.Name = "cbFunctie";
            this.cbFunctie.Size = new System.Drawing.Size(118, 24);
            this.cbFunctie.TabIndex = 41;
            // 
            // cbContext
            // 
            this.cbContext.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbContext.FormattingEnabled = true;
            this.cbContext.Items.AddRange(new object[] {
            "demonstativ",
            "nehotarat",
            "negativ",
            "interogativ"});
            this.cbContext.Location = new System.Drawing.Point(794, 175);
            this.cbContext.Name = "cbContext";
            this.cbContext.Size = new System.Drawing.Size(118, 24);
            this.cbContext.TabIndex = 40;
            // 
            // cbGradComp
            // 
            this.cbGradComp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbGradComp.FormattingEnabled = true;
            this.cbGradComp.Items.AddRange(new object[] {
            "pozitiv",
            "comparativ",
            "superlativ"});
            this.cbGradComp.Location = new System.Drawing.Point(794, 140);
            this.cbGradComp.Name = "cbGradComp";
            this.cbGradComp.Size = new System.Drawing.Size(118, 24);
            this.cbGradComp.TabIndex = 39;
            // 
            // cbCategorieAdverb
            // 
            this.cbCategorieAdverb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbCategorieAdverb.FormattingEnabled = true;
            this.cbCategorieAdverb.Items.AddRange(new object[] {
            "loc",
            "timp",
            "mod"});
            this.cbCategorieAdverb.Location = new System.Drawing.Point(794, 105);
            this.cbCategorieAdverb.Name = "cbCategorieAdverb";
            this.cbCategorieAdverb.Size = new System.Drawing.Size(118, 24);
            this.cbCategorieAdverb.TabIndex = 38;
            // 
            // cbTipAdverb
            // 
            this.cbTipAdverb.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbTipAdverb.FormattingEnabled = true;
            this.cbTipAdverb.Items.AddRange(new object[] {
            "simplu",
            "compus"});
            this.cbTipAdverb.Location = new System.Drawing.Point(794, 70);
            this.cbTipAdverb.Name = "cbTipAdverb";
            this.cbTipAdverb.Size = new System.Drawing.Size(118, 24);
            this.cbTipAdverb.TabIndex = 37;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.Location = new System.Drawing.Point(13, 210);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(73, 24);
            this.lb6.TabIndex = 36;
            this.lb6.Text = "Functie";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.Location = new System.Drawing.Point(13, 175);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(74, 24);
            this.lb5.TabIndex = 35;
            this.lb5.Text = "Context";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(13, 140);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(152, 24);
            this.lb4.TabIndex = 34;
            this.lb4.Text = "Grad Comparatie";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(13, 105);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(91, 24);
            this.lb3.TabIndex = 33;
            this.lb3.Text = "Categorie";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(13, 75);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(37, 24);
            this.lb2.TabIndex = 32;
            this.lb2.Text = "Tip";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bazeDeDateToolStripMenuItem
            // 
            this.bazeDeDateToolStripMenuItem.Name = "bazeDeDateToolStripMenuItem";
            this.bazeDeDateToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bazeDeDateToolStripMenuItem.Text = "Baze de date";
            this.bazeDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazeDeDateToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(714, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 51);
            this.button1.TabIndex = 42;
            this.button1.Text = "Salvare BD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Adverb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(915, 515);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbFunctie);
            this.Controls.Add(this.cbContext);
            this.Controls.Add(this.cbGradComp);
            this.Controls.Add(this.cbCategorieAdverb);
            this.Controls.Add(this.cbTipAdverb);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbExplicati);
            this.Controls.Add(this.lb10);
            this.Controls.Add(this.tbOrigine);
            this.Controls.Add(this.lb9);
            this.Controls.Add(this.tbRegionalisme);
            this.Controls.Add(this.tbCuvant);
            this.Controls.Add(this.tbPronuntie);
            this.Controls.Add(this.lb8);
            this.Controls.Add(this.lb7);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.tbnAfisare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Adverb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adverb";
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
        private System.Windows.Forms.ToolStripMenuItem intoarcereLaRomana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intoarcereLaMainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button tbnAfisare;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox tbExplicati;
        private System.Windows.Forms.Label lb10;
        private System.Windows.Forms.TextBox tbOrigine;
        private System.Windows.Forms.Label lb9;
        private System.Windows.Forms.TextBox tbRegionalisme;
        private System.Windows.Forms.TextBox tbCuvant;
        private System.Windows.Forms.TextBox tbPronuntie;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ComboBox cbFunctie;
        private System.Windows.Forms.ComboBox cbContext;
        private System.Windows.Forms.ComboBox cbGradComp;
        private System.Windows.Forms.ComboBox cbCategorieAdverb;
        private System.Windows.Forms.ComboBox cbTipAdverb;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisiereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem bazeDeDateToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}