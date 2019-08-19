using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

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

        private void buttonOpenForm_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddToNotes_Click(object sender, EventArgs e)
        {
            AppendToFile(textBoxAddToNotes.Text);

            textBoxAddToNotes.Text = "";
        }

        private void AppendToFile(string text)
        {
            using (StreamWriter sw = File.AppendText("DailyNotes.txt"))
            {
                sw.WriteLine(text);
            }
        }

        private void buttonShowNotes_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("DailyNotes.txt");
        }

        private void buttonAddFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                AppendToFile(Clipboard.GetText());
            }
        }

        public static IntPtr WinGetHandle(string wName)
        {
            foreach (System.Diagnostics.Process pList in System.Diagnostics.Process.GetProcesses())
                if (pList.MainWindowTitle.Contains(wName))
                    return pList.MainWindowHandle;

            return IntPtr.Zero;
        }

        private void buttonFill_Click(object sender, EventArgs e)
        {
            //IntPtr handle = WinGetHandle("ogin");
            //if (handle != IntPtr.Zero)
            //{
            //Process[] processes = Process.GetProcessesByName("ogin");
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowTitle.Contains("ogin"))
                {
                    DoExternalWrite(process.Handle, "אחראי");

                    //process.CloseMainWindow();
                    //process.Close();
                }

            }

            //}
        }

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string className, string lpszWindow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        private static extern int SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, string lParam);

        private const int WM_SETTEXT = 12;

        public void DoExternalWrite(IntPtr parent,string text)
        {
            //IntPtr parent = FindWindow("&lt;window class name&gt;", "&lt;window title" & gt;);
            IntPtr child = GetChildHandle(parent, "TextBox");

            SendMessage(child, WM_SETTEXT, IntPtr.Zero, text);
        }

        private IntPtr GetChildHandle(IntPtr parent, string className)
        {
            /* Here you need to perform some sort of function to obtain the child window handle, perhaps recursively
             */

            IntPtr child = FindWindowEx(parent, IntPtr.Zero, className, null);
            child = FindWindowEx(parent, child, className, null);

            /* You can use a tool like Spy++ to discover the hierachy on the Remedy 7 form, to find how many levels you need to search
             * to get to the textbox you want */

            return child;
        }
    }
}
