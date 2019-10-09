namespace PanelScrollExample_CSharp
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
            this.GunaHScrollBar1 = new Guna.UI.WinForms.GunaHScrollBar();
            this.GunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GunaHScrollBar1
            // 
            this.GunaHScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaHScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.GunaHScrollBar1.LargeChange = 10;
            this.GunaHScrollBar1.Location = new System.Drawing.Point(28, 393);
            this.GunaHScrollBar1.Maximum = 100;
            this.GunaHScrollBar1.Name = "GunaHScrollBar1";
            this.GunaHScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.GunaHScrollBar1.Size = new System.Drawing.Size(200, 10);
            this.GunaHScrollBar1.TabIndex = 4;
            this.GunaHScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.GunaHScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaHScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // GunaVScrollBar1
            // 
            this.GunaVScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GunaVScrollBar1.LargeChange = 10;
            this.GunaVScrollBar1.Location = new System.Drawing.Point(623, 48);
            this.GunaVScrollBar1.Maximum = 100;
            this.GunaVScrollBar1.Name = "GunaVScrollBar1";
            this.GunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.Silver;
            this.GunaVScrollBar1.Size = new System.Drawing.Size(10, 200);
            this.GunaVScrollBar1.TabIndex = 2;
            this.GunaVScrollBar1.ThumbColor = System.Drawing.Color.DimGray;
            this.GunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.Gray;
            this.GunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.DarkGray;
            // 
            // Panel1
            // 
            this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel1.AutoScroll = true;
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Location = new System.Drawing.Point(28, 37);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(589, 332);
            this.Panel1.TabIndex = 3;
            this.Panel1.Resize += new System.EventHandler(this.Panel1_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 441);
            this.Controls.Add(this.GunaHScrollBar1);
            this.Controls.Add(this.GunaVScrollBar1);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        internal Guna.UI.WinForms.GunaHScrollBar GunaHScrollBar1;
        internal Guna.UI.WinForms.GunaVScrollBar GunaVScrollBar1;
        internal System.Windows.Forms.Panel Panel1;
    }
}

