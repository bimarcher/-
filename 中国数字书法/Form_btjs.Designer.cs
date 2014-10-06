namespace 中国数字书法
{
    partial class Form_btjs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_btjs));
            this.pboxshow = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fd = new System.Windows.Forms.Button();
            this.btn_fh = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_content = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxshow)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxshow
            // 
            this.pboxshow.BackColor = System.Drawing.Color.Transparent;
            this.pboxshow.Location = new System.Drawing.Point(221, 183);
            this.pboxshow.Name = "pboxshow";
            this.pboxshow.Size = new System.Drawing.Size(910, 300);
            this.pboxshow.TabIndex = 0;
            this.pboxshow.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(50, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1241, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btn_fd
            // 
            this.btn_fd.BackColor = System.Drawing.Color.Transparent;
            this.btn_fd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fd.BackgroundImage")));
            this.btn_fd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fd.FlatAppearance.BorderSize = 0;
            this.btn_fd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fd.Location = new System.Drawing.Point(1116, 678);
            this.btn_fd.Name = "btn_fd";
            this.btn_fd.Size = new System.Drawing.Size(90, 45);
            this.btn_fd.TabIndex = 2;
            this.btn_fd.UseVisualStyleBackColor = false;
            this.btn_fd.Click += new System.EventHandler(this.btn_fd_Click);
            // 
            // btn_fh
            // 
            this.btn_fh.BackColor = System.Drawing.Color.Transparent;
            this.btn_fh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fh.BackgroundImage")));
            this.btn_fh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fh.FlatAppearance.BorderSize = 0;
            this.btn_fh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fh.Location = new System.Drawing.Point(1246, 674);
            this.btn_fh.Name = "btn_fh";
            this.btn_fh.Size = new System.Drawing.Size(90, 45);
            this.btn_fh.TabIndex = 3;
            this.btn_fh.UseVisualStyleBackColor = false;
            this.btn_fh.Click += new System.EventHandler(this.btn_fh_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.Color.Transparent;
            this.btn_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev.FlatAppearance.BorderSize = 0;
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_prev.ForeColor = System.Drawing.Color.Green;
            this.btn_prev.Location = new System.Drawing.Point(52, 356);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(30, 100);
            this.btn_prev.TabIndex = 4;
            this.btn_prev.Text = "上\r\n\r\n一\r\n\r\n幅";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next.FlatAppearance.BorderSize = 0;
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("华文楷体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_next.ForeColor = System.Drawing.Color.Green;
            this.btn_next.Location = new System.Drawing.Point(1261, 356);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(30, 100);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "下\r\n\r\n一\r\n\r\n幅";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_title.ForeColor = System.Drawing.Color.Green;
            this.lb_title.Location = new System.Drawing.Point(163, 541);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(67, 14);
            this.lb_title.TabIndex = 6;
            this.lb_title.Text = "兰亭序集";
            // 
            // lb_content
            // 
            this.lb_content.AutoSize = true;
            this.lb_content.BackColor = System.Drawing.Color.Transparent;
            this.lb_content.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_content.ForeColor = System.Drawing.Color.Green;
            this.lb_content.Location = new System.Drawing.Point(166, 571);
            this.lb_content.Name = "lb_content";
            this.lb_content.Size = new System.Drawing.Size(945, 42);
            this.lb_content.TabIndex = 7;
            this.lb_content.Text = "    神龙本兰亭集序，是唐朝冯承素摹本。纸本，行书，纵24.5cm，横69.9cm。存世兰亭集序摹墨迹以“神龙本”为最著，因卷首有唐中宗李显神龙年号\r\n小印，故" +
    "称「神龙本」，以便与其它摹本相区别。此本摹写精细，笔法、墨气、行款、神韵，都得以体现，公认为是最好的摹本。现藏于北京故宫博物\r\n院。";
            // 
            // Form_btjs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1360, 742);
            this.Controls.Add(this.lb_content);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_fh);
            this.Controls.Add(this.btn_fd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxshow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_btjs";
            this.Text = "中国数字书法";
            this.Load += new System.EventHandler(this.Form_btjs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxshow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxshow;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fd;
        private System.Windows.Forms.Button btn_fh;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_content;
    }
}