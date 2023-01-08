
namespace Proiect_GlejaruCostin
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.adauga11 = new Proiect_GlejaruCostin.Adauga1();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button1.Location = new System.Drawing.Point(308, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Catre &Romana";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button2.Location = new System.Drawing.Point(648, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Catre &Engleza";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.button3.Location = new System.Drawing.Point(912, 449);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 58);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Iesire";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // adauga11
            // 
            this.adauga11.Location = new System.Drawing.Point(947, 1);
            this.adauga11.Name = "adauga11";
            this.adauga11.Size = new System.Drawing.Size(178, 28);
            this.adauga11.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1127, 557);
            this.Controls.Add(this.adauga11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private Adauga1 adauga11;
    }
}