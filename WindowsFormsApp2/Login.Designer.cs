namespace projecte1
{
    partial class Login
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
            this.BotonRandom = new System.Windows.Forms.Button();
            this.CajaTextoRandom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotonRandom
            // 
            this.BotonRandom.Location = new System.Drawing.Point(139, 136);
            this.BotonRandom.Name = "BotonRandom";
            this.BotonRandom.Size = new System.Drawing.Size(75, 23);
            this.BotonRandom.TabIndex = 0;
            this.BotonRandom.Text = "button1";
            this.BotonRandom.UseVisualStyleBackColor = true;
            this.BotonRandom.Click += new System.EventHandler(this.BotonRandom_Click);
            // 
            // CajaTextoRandom
            // 
            this.CajaTextoRandom.Location = new System.Drawing.Point(372, 137);
            this.CajaTextoRandom.Name = "CajaTextoRandom";
            this.CajaTextoRandom.Size = new System.Drawing.Size(100, 22);
            this.CajaTextoRandom.TabIndex = 1;
            this.CajaTextoRandom.TextChanged += new System.EventHandler(this.CajaTextoRandom_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CajaTextoRandom);
            this.Controls.Add(this.BotonRandom);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonRandom;
        private System.Windows.Forms.TextBox CajaTextoRandom;
    }
}