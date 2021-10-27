
using CefSharp;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelHead = new MetroFramework.Controls.MetroPanel();
            this.relbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.loader = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rightbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.panelBody = new System.Windows.Forms.Panel();
            this.PanelHead.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHead
            // 
            this.PanelHead.AllowDrop = true;
            this.PanelHead.AutoSize = true;
            this.PanelHead.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelHead.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelHead.Controls.Add(this.relbtn);
            this.PanelHead.Controls.Add(this.button1);
            this.PanelHead.Controls.Add(this.metroPanel3);
            this.PanelHead.Controls.Add(this.rightbtn);
            this.PanelHead.Controls.Add(this.leftbtn);
            this.PanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHead.HorizontalScrollbarBarColor = true;
            this.PanelHead.HorizontalScrollbarHighlightOnWheel = false;
            this.PanelHead.HorizontalScrollbarSize = 10;
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(1064, 58);
            this.PanelHead.TabIndex = 2;
            this.PanelHead.VerticalScrollbarBarColor = true;
            this.PanelHead.VerticalScrollbarHighlightOnWheel = false;
            this.PanelHead.VerticalScrollbarSize = 10;
            // 
            // relbtn
            // 
            this.relbtn.BackgroundImage = global::WinFormsApp1.Properties.Resources.icons8_refresh_30__1_;
            this.relbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.relbtn.Location = new System.Drawing.Point(111, 23);
            this.relbtn.Name = "relbtn";
            this.relbtn.Size = new System.Drawing.Size(36, 32);
            this.relbtn.TabIndex = 3;
            this.relbtn.UseVisualStyleBackColor = true;
            this.relbtn.Click += new System.EventHandler(this.relbtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(1005, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 32);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.loader);
            this.metroPanel3.Controls.Add(this.pictureBox1);
            this.metroPanel3.Controls.Add(this.textBox1);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(153, 23);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(846, 32);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // loader
            // 
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.Image = ((System.Drawing.Image)(resources.GetObject("loader.Image")));
            this.loader.Location = new System.Drawing.Point(3, 3);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(33, 24);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loader.TabIndex = 3;
            this.loader.TabStop = false;
            this.loader.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.icons8_lock_24;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(846, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // rightbtn
            // 
            this.rightbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightbtn.BackgroundImage")));
            this.rightbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightbtn.Location = new System.Drawing.Point(69, 23);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(36, 32);
            this.rightbtn.TabIndex = 4;
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftbtn.BackgroundImage")));
            this.leftbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftbtn.Location = new System.Drawing.Point(27, 23);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(36, 32);
            this.leftbtn.TabIndex = 5;
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // panelBody
            // 
            this.panelBody.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 58);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1064, 512);
            this.panelBody.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 570);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.PanelHead);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelHead.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void rightbtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void metroPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private MetroFramework.Controls.MetroPanel PanelHead;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button relbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox loader;
        private Panel panelBody;
    }
}