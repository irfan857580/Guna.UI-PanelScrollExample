using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PanelScrollExample_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper;
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper hScrollHelper;

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaHScrollBar1, true);
            vScrollHelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(Panel1, GunaVScrollBar1, true);
            Random r = new Random();

            for (int i = 0; i <= 40; i++)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = "Label " + i.ToString() + " ================================================================";
                lbl.Location = new Point(6, i * lbl.Height);
                Panel1.Controls.Add(lbl);
            }

            vScrollHelper.UpdateScrollBar();
            hScrollHelper.UpdateScrollBar();
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            if (vScrollHelper != null) vScrollHelper.UpdateScrollBar();
            if (hScrollHelper != null) hScrollHelper.UpdateScrollBar();
        }
    }
}
