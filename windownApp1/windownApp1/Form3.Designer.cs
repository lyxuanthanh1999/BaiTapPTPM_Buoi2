namespace windownApp1
{
    partial class Form3
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
            this.pnBan = new System.Windows.Forms.Panel();
            this.tbNhapSo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnBan
            // 
            this.pnBan.Location = new System.Drawing.Point(53, 81);
            this.pnBan.Name = "pnBan";
            this.pnBan.Size = new System.Drawing.Size(524, 337);
            this.pnBan.TabIndex = 0;
            // 
            // tbNhapSo
            // 
            this.tbNhapSo.Location = new System.Drawing.Point(53, 26);
            this.tbNhapSo.Name = "tbNhapSo";
            this.tbNhapSo.Size = new System.Drawing.Size(307, 22);
            this.tbNhapSo.TabIndex = 1;
            this.tbNhapSo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNhapSo_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(502, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Bắt Đầu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbNhapSo);
            this.Controls.Add(this.pnBan);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBan;
        private System.Windows.Forms.TextBox tbNhapSo;
        private System.Windows.Forms.Button button2;
    }
}