namespace 中国数字书法
{
    partial class Form_btfd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_btfd));
            this.pboxfdshow = new System.Windows.Forms.PictureBox();
            this.btn_fd = new System.Windows.Forms.Button();
            this.btn_hy = new System.Windows.Forms.Button();
            this.btn_fh = new System.Windows.Forms.Button();
            this.panelshow = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxfdshow)).BeginInit();
            this.panelshow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pboxfdshow
            // 
            this.pboxfdshow.BackColor = System.Drawing.Color.Transparent;
            this.pboxfdshow.Location = new System.Drawing.Point(0, 0);
            this.pboxfdshow.Name = "pboxfdshow";
            this.pboxfdshow.Size = new System.Drawing.Size(1200, 525);
            this.pboxfdshow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboxfdshow.TabIndex = 0;
            this.pboxfdshow.TabStop = false;
            // 
            // btn_fd
            // 
            this.btn_fd.BackColor = System.Drawing.Color.Green;
            this.btn_fd.FlatAppearance.BorderSize = 0;
            this.btn_fd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fd.Font = new System.Drawing.Font("华文宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_fd.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_fd.Location = new System.Drawing.Point(1012, 703);
            this.btn_fd.Name = "btn_fd";
            this.btn_fd.Size = new System.Drawing.Size(50, 23);
            this.btn_fd.TabIndex = 1;
            this.btn_fd.Text = "放大";
            this.btn_fd.UseVisualStyleBackColor = false;
            this.btn_fd.Click += new System.EventHandler(this.btn_fd_Click);
            // 
            // btn_hy
            // 
            this.btn_hy.BackColor = System.Drawing.Color.Green;
            this.btn_hy.FlatAppearance.BorderSize = 0;
            this.btn_hy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hy.Font = new System.Drawing.Font("华文宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_hy.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_hy.Location = new System.Drawing.Point(1100, 703);
            this.btn_hy.Name = "btn_hy";
            this.btn_hy.Size = new System.Drawing.Size(50, 23);
            this.btn_hy.TabIndex = 2;
            this.btn_hy.Text = "还原";
            this.btn_hy.UseVisualStyleBackColor = false;
            this.btn_hy.Click += new System.EventHandler(this.btn_hy_Click);
            // 
            // btn_fh
            // 
            this.btn_fh.BackColor = System.Drawing.Color.Green;
            this.btn_fh.FlatAppearance.BorderSize = 0;
            this.btn_fh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fh.Font = new System.Drawing.Font("华文宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_fh.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_fh.Location = new System.Drawing.Point(1189, 703);
            this.btn_fh.Name = "btn_fh";
            this.btn_fh.Size = new System.Drawing.Size(50, 23);
            this.btn_fh.TabIndex = 3;
            this.btn_fh.Text = "返回";
            this.btn_fh.UseVisualStyleBackColor = false;
            this.btn_fh.Click += new System.EventHandler(this.btn_fh_Click);
            // 
            // panelshow
            // 
            this.panelshow.AutoScroll = true;
            this.panelshow.BackColor = System.Drawing.Color.Transparent;
            this.panelshow.Controls.Add(this.pboxfdshow);
            this.panelshow.Location = new System.Drawing.Point(87, 126);
            this.panelshow.Name = "panelshow";
            this.panelshow.Size = new System.Drawing.Size(1200, 525);
            this.panelshow.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form_btfd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.btn_fh);
            this.Controls.Add(this.btn_hy);
            this.Controls.Add(this.btn_fd);
            this.Controls.Add(this.panelshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_btfd";
            this.Text = "中国数字书法";
            this.Load += new System.EventHandler(this.Form_btfd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxfdshow)).EndInit();
            this.panelshow.ResumeLayout(false);
            this.panelshow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxfdshow;
        private System.Windows.Forms.Button btn_fd;
        private System.Windows.Forms.Button btn_hy;
        private System.Windows.Forms.Button btn_fh;
        private System.Windows.Forms.Panel panelshow;
        private System.Windows.Forms.ImageList imageList1;
    }
}