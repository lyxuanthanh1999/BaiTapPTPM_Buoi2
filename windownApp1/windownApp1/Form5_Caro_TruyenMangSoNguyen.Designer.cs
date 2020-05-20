namespace windownApp1
{
    partial class Form5_Caro_TruyenMangSoNguyen
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
            this.tbNguoiChoi1 = new System.Windows.Forms.TextBox();
            this.tbNguoiChoi2 = new System.Windows.Forms.TextBox();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNguoiChoi1
            // 
            this.tbNguoiChoi1.Enabled = false;
            this.tbNguoiChoi1.Location = new System.Drawing.Point(852, 199);
            this.tbNguoiChoi1.Name = "tbNguoiChoi1";
            this.tbNguoiChoi1.Size = new System.Drawing.Size(295, 22);
            this.tbNguoiChoi1.TabIndex = 7;
            this.tbNguoiChoi1.Text = "Player1";
            // 
            // tbNguoiChoi2
            // 
            this.tbNguoiChoi2.Enabled = false;
            this.tbNguoiChoi2.Location = new System.Drawing.Point(852, 237);
            this.tbNguoiChoi2.Name = "tbNguoiChoi2";
            this.tbNguoiChoi2.Size = new System.Drawing.Size(295, 22);
            this.tbNguoiChoi2.TabIndex = 8;
            this.tbNguoiChoi2.Text = "Player2";
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(852, 281);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(75, 23);
            this.btnChoiLai.TabIndex = 5;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // Form5_Caro_TruyenMangSoNguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 667);
            this.Controls.Add(this.tbNguoiChoi1);
            this.Controls.Add(this.tbNguoiChoi2);
            this.Controls.Add(this.btnChoiLai);
            this.Name = "Form5_Caro_TruyenMangSoNguyen";
            this.Text = "Form5_Caro_TruyenMangSoNguyen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNguoiChoi1;
        private System.Windows.Forms.TextBox tbNguoiChoi2;
        private System.Windows.Forms.Button btnChoiLai;
    }
}