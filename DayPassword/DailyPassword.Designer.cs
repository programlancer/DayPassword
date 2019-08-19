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
            this.buttonOpenForm = new System.Windows.Forms.Button();
            this.buttonFill = new System.Windows.Forms.Button();
            this.textBoxAddToNotes = new System.Windows.Forms.TextBox();
            this.buttonAddToNotes = new System.Windows.Forms.Button();
            this.buttonShowNotes = new System.Windows.Forms.Button();
            this.buttonAddFromClipboard = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(91, 118);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(144, 23);
            this.buttonCopy.TabIndex = 0;
            this.buttonCopy.Text = "Copy to clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelAsterisk
            // 
            this.labelAsterisk.AutoSize = true;
            this.labelAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAsterisk.Location = new System.Drawing.Point(38, 52);
            this.labelAsterisk.Name = "labelAsterisk";
            this.labelAsterisk.Size = new System.Drawing.Size(29, 37);
            this.labelAsterisk.TabIndex = 1;
            this.labelAsterisk.Text = "*";
            // 
            // labelDig1
            // 
            this.labelDig1.AutoSize = true;
            this.labelDig1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig1.Location = new System.Drawing.Point(84, 52);
            this.labelDig1.Name = "labelDig1";
            this.labelDig1.Size = new System.Drawing.Size(33, 37);
            this.labelDig1.TabIndex = 2;
            this.labelDig1.Text = "1";
            // 
            // labelDig2
            // 
            this.labelDig2.AutoSize = true;
            this.labelDig2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig2.Location = new System.Drawing.Point(132, 52);
            this.labelDig2.Name = "labelDig2";
            this.labelDig2.Size = new System.Drawing.Size(35, 37);
            this.labelDig2.TabIndex = 3;
            this.labelDig2.Text = "2";
            // 
            // labelDig3
            // 
            this.labelDig3.AutoSize = true;
            this.labelDig3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig3.Location = new System.Drawing.Point(180, 52);
            this.labelDig3.Name = "labelDig3";
            this.labelDig3.Size = new System.Drawing.Size(35, 37);
            this.labelDig3.TabIndex = 4;
            this.labelDig3.Text = "3";
            // 
            // labelDig4
            // 
            this.labelDig4.AutoSize = true;
            this.labelDig4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDig4.Location = new System.Drawing.Point(228, 52);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // toolStripMenuItemHideTray
            // 
            this.toolStripMenuItemHideTray.Name = "toolStripMenuItemHideTray";
            this.toolStripMenuItemHideTray.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItemHideTray.Text = "Hide to Tray";
            this.toolStripMenuItemHideTray.Click += new System.EventHandler(this.toolStripMenuItemHideTray_Click);
            // 
            // buttonOpenForm
            // 
            this.buttonOpenForm.Location = new System.Drawing.Point(12, 357);
            this.buttonOpenForm.Name = "buttonOpenForm";
            this.buttonOpenForm.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenForm.TabIndex = 6;
            this.buttonOpenForm.Text = "Open Form";
            this.buttonOpenForm.UseVisualStyleBackColor = true;
            this.buttonOpenForm.Click += new System.EventHandler(this.buttonOpenForm_Click);
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(93, 357);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(75, 23);
            this.buttonFill.TabIndex = 7;
            this.buttonFill.Text = "Fill";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // textBoxAddToNotes
            // 
            this.textBoxAddToNotes.AllowDrop = true;
            this.textBoxAddToNotes.Location = new System.Drawing.Point(12, 213);
            this.textBoxAddToNotes.Name = "textBoxAddToNotes";
            this.textBoxAddToNotes.Size = new System.Drawing.Size(199, 20);
            this.textBoxAddToNotes.TabIndex = 8;
            // 
            // buttonAddToNotes
            // 
            this.buttonAddToNotes.Location = new System.Drawing.Point(220, 212);
            this.buttonAddToNotes.Name = "buttonAddToNotes";
            this.buttonAddToNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonAddToNotes.TabIndex = 9;
            this.buttonAddToNotes.Text = "Add to Notes";
            this.buttonAddToNotes.UseVisualStyleBackColor = true;
            this.buttonAddToNotes.Click += new System.EventHandler(this.buttonAddToNotes_Click);
            // 
            // buttonShowNotes
            // 
            this.buttonShowNotes.Location = new System.Drawing.Point(220, 259);
            this.buttonShowNotes.Name = "buttonShowNotes";
            this.buttonShowNotes.Size = new System.Drawing.Size(75, 23);
            this.buttonShowNotes.TabIndex = 10;
            this.buttonShowNotes.Text = "Show Notes";
            this.buttonShowNotes.UseVisualStyleBackColor = true;
            this.buttonShowNotes.Click += new System.EventHandler(this.buttonShowNotes_Click);
            // 
            // buttonAddFromClipboard
            // 
            this.buttonAddFromClipboard.Location = new System.Drawing.Point(12, 259);
            this.buttonAddFromClipboard.Name = "buttonAddFromClipboard";
            this.buttonAddFromClipboard.Size = new System.Drawing.Size(199, 23);
            this.buttonAddFromClipboard.TabIndex = 11;
            this.buttonAddFromClipboard.Text = "Add from clipboard";
            this.buttonAddFromClipboard.UseVisualStyleBackColor = true;
            this.buttonAddFromClipboard.Click += new System.EventHandler(this.buttonAddFromClipboard_Click);
            // 
            // DailyPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 392);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonAddFromClipboard);
            this.Controls.Add(this.buttonShowNotes);
            this.Controls.Add(this.buttonAddToNotes);
            this.Controls.Add(this.textBoxAddToNotes);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.buttonOpenForm);
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
        private System.Windows.Forms.Button buttonOpenForm;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.TextBox textBoxAddToNotes;
        private System.Windows.Forms.Button buttonAddToNotes;
        private System.Windows.Forms.Button buttonShowNotes;
        private System.Windows.Forms.Button buttonAddFromClipboard;
    }
}

