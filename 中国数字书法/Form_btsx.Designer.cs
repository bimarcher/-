﻿namespace 中国数字书法
{
    partial class Form_btsx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_btsx));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_cd = new System.Windows.Forms.Panel();
            this.btn_fh = new System.Windows.Forms.Button();
            this.btn_lmdb = new System.Windows.Forms.Button();
            this.btn_zxjz = new System.Windows.Forms.Button();
            this.btn_dzjs = new System.Windows.Forms.Button();
            this.btn_spsx = new System.Windows.Forms.Button();
            this.btn_btsx = new System.Windows.Forms.Button();
            this.btn_rjjs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel_cd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1226, 719);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 6);
            this.panel1.TabIndex = 13;
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
            // panel_cd
            // 
            this.panel_cd.BackColor = System.Drawing.Color.Transparent;
            this.panel_cd.Controls.Add(this.btn_fh);
            this.panel_cd.Controls.Add(this.btn_lmdb);
            this.panel_cd.Controls.Add(this.btn_zxjz);
            this.panel_cd.Controls.Add(this.btn_dzjs);
            this.panel_cd.Controls.Add(this.btn_spsx);
            this.panel_cd.Controls.Add(this.btn_btsx);
            this.panel_cd.Controls.Add(this.btn_rjjs);
            this.panel_cd.Location = new System.Drawing.Point(5, 1);
            this.panel_cd.Name = "panel_cd";
            this.panel_cd.Size = new System.Drawing.Size(1360, 69);
            this.panel_cd.TabIndex = 12;
            // 
            // btn_fh
            // 
            this.btn_fh.BackColor = System.Drawing.Color.Transparent;
            this.btn_fh.FlatAppearance.BorderSize = 0;
            this.btn_fh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fh.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_fh.Location = new System.Drawing.Point(1223, 21);
            this.btn_fh.Name = "btn_fh";
            this.btn_fh.Size = new System.Drawing.Size(134, 42);
            this.btn_fh.TabIndex = 2;
            this.btn_fh.Text = "返回";
            this.btn_fh.UseVisualStyleBackColor = false;
            this.btn_fh.Click += new System.EventHandler(this.btn_fh_Click);
            // 
            // btn_lmdb
            // 
            this.btn_lmdb.BackColor = System.Drawing.Color.Transparent;
            this.btn_lmdb.FlatAppearance.BorderSize = 0;
            this.btn_lmdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lmdb.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_lmdb.Location = new System.Drawing.Point(999, 21);
            this.btn_lmdb.Name = "btn_lmdb";
            this.btn_lmdb.Size = new System.Drawing.Size(134, 42);
            this.btn_lmdb.TabIndex = 1;
            this.btn_lmdb.Text = "临摹对比";
            this.btn_lmdb.UseVisualStyleBackColor = false;
            this.btn_lmdb.Click += new System.EventHandler(this.btn_lmdb_Click);
            // 
            // btn_zxjz
            // 
            this.btn_zxjz.BackColor = System.Drawing.Color.Transparent;
            this.btn_zxjz.FlatAppearance.BorderSize = 0;
            this.btn_zxjz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_zxjz.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_zxjz.Location = new System.Drawing.Point(844, 21);
            this.btn_zxjz.Name = "btn_zxjz";
            this.btn_zxjz.Size = new System.Drawing.Size(134, 42);
            this.btn_zxjz.TabIndex = 1;
            this.btn_zxjz.Text = "在线集字";
            this.btn_zxjz.UseVisualStyleBackColor = false;
            this.btn_zxjz.Click += new System.EventHandler(this.btn_zxjz_Click);
            // 
            // btn_dzjs
            // 
            this.btn_dzjs.BackColor = System.Drawing.Color.Transparent;
            this.btn_dzjs.FlatAppearance.BorderSize = 0;
            this.btn_dzjs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dzjs.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_dzjs.Location = new System.Drawing.Point(694, 21);
            this.btn_dzjs.Name = "btn_dzjs";
            this.btn_dzjs.Size = new System.Drawing.Size(134, 42);
            this.btn_dzjs.TabIndex = 1;
            this.btn_dzjs.Text = "单字检索";
            this.btn_dzjs.UseVisualStyleBackColor = false;
            this.btn_dzjs.Click += new System.EventHandler(this.btn_dzjs_Click);
            // 
            // btn_spsx
            // 
            this.btn_spsx.BackColor = System.Drawing.Color.Transparent;
            this.btn_spsx.FlatAppearance.BorderSize = 0;
            this.btn_spsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_spsx.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_spsx.Location = new System.Drawing.Point(539, 21);
            this.btn_spsx.Name = "btn_spsx";
            this.btn_spsx.Size = new System.Drawing.Size(134, 42);
            this.btn_spsx.TabIndex = 1;
            this.btn_spsx.Text = "视频赏析";
            this.btn_spsx.UseVisualStyleBackColor = false;
            this.btn_spsx.Click += new System.EventHandler(this.btn_spsx_Click);
            // 
            // btn_btsx
            // 
            this.btn_btsx.BackColor = System.Drawing.Color.Transparent;
            this.btn_btsx.FlatAppearance.BorderSize = 0;
            this.btn_btsx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_btsx.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_btsx.Location = new System.Drawing.Point(368, 21);
            this.btn_btsx.Name = "btn_btsx";
            this.btn_btsx.Size = new System.Drawing.Size(134, 42);
            this.btn_btsx.TabIndex = 1;
            this.btn_btsx.Text = "碑帖赏析";
            this.btn_btsx.UseVisualStyleBackColor = false;
            this.btn_btsx.Click += new System.EventHandler(this.btn_btsx_Click);
            // 
            // btn_rjjs
            // 
            this.btn_rjjs.BackColor = System.Drawing.Color.Transparent;
            this.btn_rjjs.FlatAppearance.BorderSize = 0;
            this.btn_rjjs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rjjs.Font = new System.Drawing.Font("华文行楷", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_rjjs.Location = new System.Drawing.Point(205, 21);
            this.btn_rjjs.Name = "btn_rjjs";
            this.btn_rjjs.Size = new System.Drawing.Size(134, 42);
            this.btn_rjjs.TabIndex = 0;
            this.btn_rjjs.Text = "软件介绍";
            this.btn_rjjs.UseVisualStyleBackColor = false;
            this.btn_rjjs.Click += new System.EventHandler(this.btn_rjjs_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1287, 506);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(595, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 30);
            this.label1.TabIndex = 15;
            this.label1.Text = "王羲之碑帖";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(143, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1108, 494);
            this.panel3.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(996, 459);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form_btsx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel_cd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_btsx";
            this.Text = "中国数字书法";
            this.Load += new System.EventHandler(this.Form_btsx_Load);
            this.panel1.ResumeLayout(false);
            this.panel_cd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_cd;
        private System.Windows.Forms.Button btn_fh;
        private System.Windows.Forms.Button btn_lmdb;
        private System.Windows.Forms.Button btn_zxjz;
        private System.Windows.Forms.Button btn_dzjs;
        private System.Windows.Forms.Button btn_spsx;
        private System.Windows.Forms.Button btn_btsx;
        private System.Windows.Forms.Button btn_rjjs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}