namespace Ristinollapeli
{
    partial class Ristinolla2
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
            this.pellabel = new System.Windows.Forms.Label();
            this.Enimilabel = new System.Windows.Forms.Label();
            this.enimibox = new System.Windows.Forms.TextBox();
            this.Snimilabel = new System.Windows.Forms.Label();
            this.Snimibox = new System.Windows.Forms.TextBox();
            this.Svuosilabel = new System.Windows.Forms.Label();
            this.Svuosibox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pellabel
            // 
            this.pellabel.AutoSize = true;
            this.pellabel.Location = new System.Drawing.Point(74, 81);
            this.pellabel.Name = "pellabel";
            this.pellabel.Size = new System.Drawing.Size(102, 25);
            this.pellabel.TabIndex = 0;
            this.pellabel.Text = "Pelaajan:";
            // 
            // Enimilabel
            // 
            this.Enimilabel.AutoSize = true;
            this.Enimilabel.Location = new System.Drawing.Point(223, 80);
            this.Enimilabel.Name = "Enimilabel";
            this.Enimilabel.Size = new System.Drawing.Size(87, 25);
            this.Enimilabel.TabIndex = 1;
            this.Enimilabel.Text = "etunimi:";
            // 
            // enimibox
            // 
            this.enimibox.Location = new System.Drawing.Point(357, 80);
            this.enimibox.Multiline = true;
            this.enimibox.Name = "enimibox";
            this.enimibox.Size = new System.Drawing.Size(211, 31);
            this.enimibox.TabIndex = 2;
            // 
            // Snimilabel
            // 
            this.Snimilabel.AutoSize = true;
            this.Snimilabel.Location = new System.Drawing.Point(204, 142);
            this.Snimilabel.Name = "Snimilabel";
            this.Snimilabel.Size = new System.Drawing.Size(106, 25);
            this.Snimilabel.TabIndex = 3;
            this.Snimilabel.Text = "Sukunimi:";
            // 
            // Snimibox
            // 
            this.Snimibox.Location = new System.Drawing.Point(357, 142);
            this.Snimibox.Multiline = true;
            this.Snimibox.Name = "Snimibox";
            this.Snimibox.Size = new System.Drawing.Size(211, 31);
            this.Snimibox.TabIndex = 4;
            // 
            // Svuosilabel
            // 
            this.Svuosilabel.AutoSize = true;
            this.Svuosilabel.Location = new System.Drawing.Point(158, 201);
            this.Svuosilabel.Name = "Svuosilabel";
            this.Svuosilabel.Size = new System.Drawing.Size(152, 25);
            this.Svuosilabel.TabIndex = 5;
            this.Svuosilabel.Text = "Syntymävuosi:";
            // 
            // Svuosibox
            // 
            this.Svuosibox.Location = new System.Drawing.Point(357, 201);
            this.Svuosibox.Multiline = true;
            this.Svuosibox.Name = "Svuosibox";
            this.Svuosibox.Size = new System.Drawing.Size(211, 31);
            this.Svuosibox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(443, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 56);
            this.button1.TabIndex = 7;
            this.button1.Text = "Pelaa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ristinolla2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 367);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Svuosibox);
            this.Controls.Add(this.Svuosilabel);
            this.Controls.Add(this.Snimibox);
            this.Controls.Add(this.Snimilabel);
            this.Controls.Add(this.enimibox);
            this.Controls.Add(this.Enimilabel);
            this.Controls.Add(this.pellabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(645, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(645, 438);
            this.Name = "Ristinolla2";
            this.Text = "Ristinolla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ristinolla2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pellabel;
        private System.Windows.Forms.Label Enimilabel;
        private System.Windows.Forms.TextBox enimibox;
        private System.Windows.Forms.Label Snimilabel;
        private System.Windows.Forms.TextBox Snimibox;
        private System.Windows.Forms.Label Svuosilabel;
        private System.Windows.Forms.TextBox Svuosibox;
        private System.Windows.Forms.Button button1;
    }
}