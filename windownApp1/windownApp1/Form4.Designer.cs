namespace windownApp1
{
    partial class Form4
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
            this.pnBanCo = new System.Windows.Forms.Panel();
            this.btnChoiLai = new System.Windows.Forms.Button();
            this.bntBatDau = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tbNguoiChoi2 = new System.Windows.Forms.TextBox();
            this.tbNguoiChoi1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnBanCo
            // 
            this.pnBanCo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnBanCo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBanCo.Location = new System.Drawing.Point(12, 12);
            this.pnBanCo.Name = "pnBanCo";
            this.pnBanCo.Size = new System.Drawing.Size(767, 633);
            this.pnBanCo.TabIndex = 0;
            this.pnBanCo.Visible = false;
            // 
            // btnChoiLai
            // 
            this.btnChoiLai.Location = new System.Drawing.Point(1075, 348);
            this.btnChoiLai.Name = "btnChoiLai";
            this.btnChoiLai.Size = new System.Drawing.Size(75, 23);
            this.btnChoiLai.TabIndex = 1;
            this.btnChoiLai.Text = "Chơi Lại";
            this.btnChoiLai.UseVisualStyleBackColor = true;
            this.btnChoiLai.Click += new System.EventHandler(this.btnChoiLai_Click);
            // 
            // bntBatDau
            // 
            this.bntBatDau.Location = new System.Drawing.Point(855, 348);
            this.bntBatDau.Name = "bntBatDau";
            this.bntBatDau.Size = new System.Drawing.Size(75, 23);
            this.bntBatDau.TabIndex = 1;
            this.bntBatDau.Text = "Bắt Đầu";
            this.bntBatDau.UseVisualStyleBackColor = true;
            this.bntBatDau.Click += new System.EventHandler(this.bntBatDau_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(855, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(295, 23);
            this.progressBar1.Step = 5;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 2;
            // 
            // tbNguoiChoi2
            // 
            this.tbNguoiChoi2.Location = new System.Drawing.Point(855, 263);
            this.tbNguoiChoi2.Name = "tbNguoiChoi2";
            this.tbNguoiChoi2.Size = new System.Drawing.Size(295, 22);
            this.tbNguoiChoi2.TabIndex = 3;
            // 
            // tbNguoiChoi1
            // 
            this.tbNguoiChoi1.Location = new System.Drawing.Point(855, 225);
            this.tbNguoiChoi1.Name = "tbNguoiChoi1";
            this.tbNguoiChoi1.Size = new System.Drawing.Size(295, 22);
            this.tbNguoiChoi1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 667);
            this.Controls.Add(this.tbNguoiChoi1);
            this.Controls.Add(this.tbNguoiChoi2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.bntBatDau);
            this.Controls.Add(this.btnChoiLai);
            this.Controls.Add(this.pnBanCo);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBanCo;
        private System.Windows.Forms.Button btnChoiLai;
        private System.Windows.Forms.Button bntBatDau;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tbNguoiChoi2;
        private System.Windows.Forms.TextBox tbNguoiChoi1;
        private System.Windows.Forms.Timer timer1;
    }
}