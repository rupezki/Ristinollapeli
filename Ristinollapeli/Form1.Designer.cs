namespace Ristinollapeli
{
    partial class Ristinolla1
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
            this.Nappi1 = new System.Windows.Forms.Button();
            this.Nappi2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nappi1
            // 
            this.Nappi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nappi1.Location = new System.Drawing.Point(45, 90);
            this.Nappi1.Name = "Nappi1";
            this.Nappi1.Size = new System.Drawing.Size(254, 126);
            this.Nappi1.TabIndex = 0;
            this.Nappi1.Text = "Pelaa yksin (tietokonetta vastaan)";
            this.Nappi1.UseVisualStyleBackColor = true;
            this.Nappi1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nappi2
            // 
            this.Nappi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nappi2.Location = new System.Drawing.Point(427, 90);
            this.Nappi2.Name = "Nappi2";
            this.Nappi2.Size = new System.Drawing.Size(254, 126);
            this.Nappi2.TabIndex = 1;
            this.Nappi2.Text = "Pelaa kaverin kanssa (vastakkain)";
            this.Nappi2.UseVisualStyleBackColor = true;
            this.Nappi2.Click += new System.EventHandler(this.Nappi2_Click);
            // 
            // Ristinolla1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 274);
            this.Controls.Add(this.Nappi2);
            this.Controls.Add(this.Nappi1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(772, 345);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(772, 345);
            this.Name = "Ristinolla1";
            this.Text = "Ristinolla";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Nappi1;
        private System.Windows.Forms.Button Nappi2;
    }
}

