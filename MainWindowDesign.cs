using System;
using System.Drawing;
using System.Windows.Forms;

//using Gtk;

namespace linuxcc2
{
    public partial class lccMainWindow : Form
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

            this.groupBox1 = new GroupBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.button1 = new Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();

            this.groupBox1.Location = new Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(600, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "First Step: Select your C&C big file";

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Big File: ";

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size: ";

            this.button1.Location = new Point(100,20);
            this.button1.Name = "button1";
            this.button1.Size = new Size(200, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Click me to choose big file";
            this.button1.UseVisualStyleBackColor = true;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);

            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(button1);
            this.Controls.Add(groupBox1);
            //this.Controls.Add(label1);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Linuxcc";
            this.Text = "LinuxC&C";
            //this.TopMost = true;
            //this.Load += new System.EventHandler(this.FormEditCity_Load);
            //this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        //private FolderBrowserDialog folderBrowserDialog1;


    }
}
