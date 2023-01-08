
namespace Proiect_GlejaruCostin
{
    partial class Engleza
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.principalMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazeDeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.Type = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPronuntie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPluralForm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOrigine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbExplicatii = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbAfisare = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button4 = new System.Windows.Forms.Button();
            this.desenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.salvareToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.bazeDeDateToolStripMenuItem,
            this.desenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1015, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalMenuToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // principalMenuToolStripMenuItem
            // 
            this.principalMenuToolStripMenuItem.Name = "principalMenuToolStripMenuItem";
            this.principalMenuToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.principalMenuToolStripMenuItem.Text = "Principal Menu";
            this.principalMenuToolStripMenuItem.Click += new System.EventHandler(this.principalMenuToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem,
            this.deserializareToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.salvareToolStripMenuItem.Text = "Salvare ";
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
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // bazeDeDateToolStripMenuItem
            // 
            this.bazeDeDateToolStripMenuItem.Name = "bazeDeDateToolStripMenuItem";
            this.bazeDeDateToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.bazeDeDateToolStripMenuItem.Text = "Baze de date";
            this.bazeDeDateToolStripMenuItem.Click += new System.EventHandler(this.bazeDeDateToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word";
            // 
            // tbWord
            // 
            this.tbWord.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbWord.Location = new System.Drawing.Point(146, 37);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(105, 22);
            this.tbWord.TabIndex = 2;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(12, 65);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(53, 24);
            this.Type.TabIndex = 3;
            this.Type.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "noun",
            "adjective",
            "pronoum",
            "verb"});
            this.cbType.Location = new System.Drawing.Point(146, 65);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(152, 24);
            this.cbType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pronunciation";
            // 
            // tbPronuntie
            // 
            this.tbPronuntie.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbPronuntie.Location = new System.Drawing.Point(146, 97);
            this.tbPronuntie.Multiline = true;
            this.tbPronuntie.Name = "tbPronuntie";
            this.tbPronuntie.Size = new System.Drawing.Size(152, 51);
            this.tbPronuntie.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plural form";
            // 
            // tbPluralForm
            // 
            this.tbPluralForm.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbPluralForm.Location = new System.Drawing.Point(146, 159);
            this.tbPluralForm.Name = "tbPluralForm";
            this.tbPluralForm.Size = new System.Drawing.Size(152, 22);
            this.tbPluralForm.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "UK Form";
            // 
            // tbUK
            // 
            this.tbUK.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbUK.Location = new System.Drawing.Point(146, 193);
            this.tbUK.Name = "tbUK";
            this.tbUK.Size = new System.Drawing.Size(152, 22);
            this.tbUK.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "US Form";
            // 
            // tbUS
            // 
            this.tbUS.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbUS.Location = new System.Drawing.Point(146, 236);
            this.tbUS.Name = "tbUS";
            this.tbUS.Size = new System.Drawing.Size(152, 22);
            this.tbUS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orgins";
            // 
            // tbOrigine
            // 
            this.tbOrigine.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbOrigine.Location = new System.Drawing.Point(146, 272);
            this.tbOrigine.Name = "tbOrigine";
            this.tbOrigine.Size = new System.Drawing.Size(152, 22);
            this.tbOrigine.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Explanations";
            // 
            // tbExplicatii
            // 
            this.tbExplicatii.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbExplicatii.Location = new System.Drawing.Point(146, 315);
            this.tbExplicatii.Multiline = true;
            this.tbExplicatii.Name = "tbExplicatii";
            this.tbExplicatii.Size = new System.Drawing.Size(277, 74);
            this.tbExplicatii.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(66, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 17;
            this.button1.Text = "&AddEn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbAfisare
            // 
            this.tbAfisare.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbAfisare.Location = new System.Drawing.Point(538, 33);
            this.tbAfisare.Multiline = true;
            this.tbAfisare.Name = "tbAfisare";
            this.tbAfisare.Size = new System.Drawing.Size(477, 193);
            this.tbAfisare.TabIndex = 18;
            this.tbAfisare.TextChanged += new System.EventHandler(this.tbAfisare_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button2.Location = new System.Drawing.Point(573, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 44);
            this.button2.TabIndex = 19;
            this.button2.Text = "&Display";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button3.Location = new System.Drawing.Point(710, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 44);
            this.button3.TabIndex = 20;
            this.button3.Text = "&Vizualizare";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 28);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.salveazaToolStripMenuItem.Text = "Salveaza";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button4.Location = new System.Drawing.Point(848, 266);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 44);
            this.button4.TabIndex = 21;
            this.button4.Text = "&SALVAREBD";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // desenToolStripMenuItem
            // 
            this.desenToolStripMenuItem.Name = "desenToolStripMenuItem";
            this.desenToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.desenToolStripMenuItem.Text = "Desen";
            this.desenToolStripMenuItem.Click += new System.EventHandler(this.desenToolStripMenuItem_Click);
            // 
            // Engleza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1015, 472);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbAfisare);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbExplicatii);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbOrigine);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbUS);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPluralForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPronuntie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Engleza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engleza";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPronuntie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPluralForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOrigine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbExplicatii;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbAfisare;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem principalMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazeDeDateToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem desenToolStripMenuItem;
    }
}