﻿namespace 中国数字书法.demo
{
    partial class TestSqlite
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
            this.button1 = new System.Windows.Forms.Button();
            this.sqLiteConnection1 = new System.Data.SQLite.SQLiteConnection();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqLiteConnection1
            // 
            this.sqLiteConnection1.ConnectionString = "data source=D:\\WorkspaceVs\\中国数字书法\\中国数字书法\\db\\DigitalCalligraphy.sqlite;password=ad" +
    "min";
            this.sqLiteConnection1.DefaultDbType = System.Data.DbType.Object;
            this.sqLiteConnection1.DefaultTimeout = 30;
            this.sqLiteConnection1.DefaultTypeName = "";
            this.sqLiteConnection1.Flags = ((System.Data.SQLite.SQLiteConnectionFlags)((System.Data.SQLite.SQLiteConnectionFlags.LogCallbackException | System.Data.SQLite.SQLiteConnectionFlags.LogModuleException)));
            this.sqLiteConnection1.ParseViaFramework = false;
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            this.sqLiteCommand1.Connection = this.sqLiteConnection1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TestSqlite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "TestSqlite";
            this.Text = "TestSqlite";
            this.Load += new System.EventHandler(this.TestSqlite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Data.SQLite.SQLiteConnection sqLiteConnection1;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}