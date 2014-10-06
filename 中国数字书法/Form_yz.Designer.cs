namespace 中国数字书法
{
    partial class Form_yz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_yz));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tb_yzm = new System.Windows.Forms.TextBox();
            this.btn_yzdl = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1220, 599);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // tb_yzm
            // 
            this.tb_yzm.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_yzm.Location = new System.Drawing.Point(329, 320);
            this.tb_yzm.Name = "tb_yzm";
            this.tb_yzm.Size = new System.Drawing.Size(585, 38);
            this.tb_yzm.TabIndex = 1;
            // 
            // btn_yzdl
            // 
            this.btn_yzdl.BackColor = System.Drawing.Color.DarkGray;
            this.btn_yzdl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yzdl.FlatAppearance.BorderSize = 0;
            this.btn_yzdl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yzdl.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_yzdl.Location = new System.Drawing.Point(811, 409);
            this.btn_yzdl.Name = "btn_yzdl";
            this.btn_yzdl.Size = new System.Drawing.Size(103, 41);
            this.btn_yzdl.TabIndex = 2;
            this.btn_yzdl.Text = "验证";
            this.btn_yzdl.UseVisualStyleBackColor = false;
            this.btn_yzdl.Click += new System.EventHandler(this.btn_yzdl_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1167, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 6);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 6);
            this.panel2.TabIndex = 11;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(312, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "请输入您的验证码";
            // 
            // Form_yz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_yzdl);
            this.Controls.Add(this.tb_yzm);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_yz";
            this.Text = "Form_yz";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TextBox tb_yzm;
        private System.Windows.Forms.Button btn_yzdl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}