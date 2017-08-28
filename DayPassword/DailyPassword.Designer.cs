namespace DayPassword
{
    partial class DailyPassword
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
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelAsterisk = new System.Windows.Forms.Label();
            this.labelDig1 = new System.Windows.Forms.Label();
            this.labelDig2 = new System.Windows.Forms.Label();
            this.labelDig3 = new System.Windows.Forms.Label();
            this.labelDig4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemHideTray = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(82, 164);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(129, 23);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "Copy to clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelAsterisk
            // 
            this.labelAsterisk.AutoSize = true;
            this.labelAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAsterisk.Location = new System.Drawing.Point(34, 85);
            this.labelAsterisk.Name = "labelAsterisk";
            this.labelAsterisk.Size = new System.Drawing.Size(29, 37);
            this.labelAsterisk.TabIndex = 1;
            this.labelAsterisk.Text = "*";
            // 
            // labelDig1
            // 
            this.labelDig1.AutoSize = true;
            this.labelDig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig1.Location = new System.Drawing.Point(80, 85);
            this.labelDig1.Name = "labelDig1";
            this.labelDig1.Size = new System.Drawing.Size(33, 37);
            this.labelDig1.TabIndex = 2;
            this.labelDig1.Text = "1";
            // 
            // labelDig2
            // 
            this.labelDig2.AutoSize = true;
            this.labelDig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig2.Location = new System.Drawing.Point(128, 85);
            this.labelDig2.Name = "labelDig2";
            this.labelDig2.Size = new System.Drawing.Size(35, 37);
            this.labelDig2.TabIndex = 3;
            this.labelDig2.Text = "2";
            // 
            // labelDig3
            // 
            this.labelDig3.AutoSize = true;
            this.labelDig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig3.Location = new System.Drawing.Point(176, 85);
            this.labelDig3.Name = "labelDig3";
            this.labelDig3.Size = new System.Drawing.Size(35, 37);
            this.labelDig3.TabIndex = 4;
            this.labelDig3.Text = "3";
            // 
            // labelDig4
            // 
            this.labelDig4.AutoSize = true;
            this.labelDig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig4.Location = new System.Drawing.Point(224, 85);
            this.labelDig4.Name = "labelDig4";
            this.labelDig4.Size = new System.Drawing.Size(35, 37);
            this.labelDig4.TabIndex = 5;
            this.labelDig4.Text = "4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHideTray});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 26);
            // 
            // toolStripMenuItemHideTray
            // 
            this.toolStripMenuItemHideTray.Name = "toolStripMenuItemHideTray";
            this.toolStripMenuItemHideTray.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemHideTray.Text = "Hide to Tray";
            this.toolStripMenuItemHideTray.Click += new System.EventHandler(this.toolStripMenuItemHideTray_Click);
            // 
            // DailyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 272);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.labelDig4);
            this.Controls.Add(this.labelDig3);
            this.Controls.Add(this.labelDig2);
            this.Controls.Add(this.labelDig1);
            this.Controls.Add(this.labelAsterisk);
            this.Controls.Add(this.buttonCopy);
            this.MaximizeBox = false;
            this.Name = "DailyPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Password";
            this.Activated += new System.EventHandler(this.DailyPassword_Activated);
            this.Deactivate += new System.EventHandler(this.DailyPassword_Deactivate);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelAsterisk;
        private System.Windows.Forms.Label labelDig1;
        private System.Windows.Forms.Label labelDig2;
        private System.Windows.Forms.Label labelDig3;
        private System.Windows.Forms.Label labelDig4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHideTray;
    }
}

