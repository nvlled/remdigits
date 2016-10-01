namespace RemDigits
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.remNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digit length:";
            // 
            // numLength
            // 
            this.numLength.Location = new System.Drawing.Point(103, 13);
            this.numLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(62, 22);
            this.numLength.TabIndex = 2;
            this.numLength.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.Location = new System.Drawing.Point(259, 145);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // remNum
            // 
            this.remNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remNum.Location = new System.Drawing.Point(12, 41);
            this.remNum.Name = "remNum";
            this.remNum.ReadOnly = true;
            this.remNum.Size = new System.Drawing.Size(624, 98);
            this.remNum.TabIndex = 5;
            this.remNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.remNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remNum_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remember the digits shown on the screen one by one";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 220);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(648, 25);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 20);
            this.toolStripStatusLabel1.Text = "Progress";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 245);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remNum);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(1200, 290);
            this.Name = "MainForm";
            this.Text = "Remember Digits";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.TextBox remNum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
    }
}

