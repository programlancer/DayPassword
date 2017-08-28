using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayPassword
{
    public partial class DailyPassword : Form
    {

        DateTime today = DateTime.Now;
        String formText;

        public DailyPassword()
        {
            InitializeComponent();

            this.labelDig1.Text = (today.Day / 10).ToString();
            this.labelDig2.Text = ((int)today.DayOfWeek + 1).ToString();
            this.labelDig3.Text = (today.Day % 10).ToString();
            this.labelDig4.Text = (Int16.Parse(labelDig1.Text + labelDig2.Text + labelDig3.Text) % 4).ToString();

            formText = this.Text;
            //this.Text = this.labelDig1.Text + this.labelDig2.Text + this.labelDig3.Text + this.labelDig4.Text;

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelAsterisk.Text + labelDig1.Text + labelDig2.Text + labelDig3.Text + labelDig4.Text);
        }

        private void toolStripMenuItemHideTray_Click(object sender, EventArgs e)
        {

        }

        private void DailyPassword_Deactivate(object sender, EventArgs e)
        {
            //this.Text = formText + " " + this.labelDig1.Text + this.labelDig2.Text + this.labelDig3.Text + this.labelDig4.Text;
            this.Text = this.labelDig1.Text + this.labelDig2.Text + this.labelDig3.Text + this.labelDig4.Text;
        }

        private void DailyPassword_Activated(object sender, EventArgs e)
        {
            this.Text = formText;
        }
    }
}
