namespace GifOptimizer
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
            this.sourceGif = new System.Windows.Forms.PictureBox();
            this.optimizedGif = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gifHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gifWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.colorReduction = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lossy = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.compressLevel = new System.Windows.Forms.ComboBox();
            this.optimizedbtn = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.Outputpath = new System.Windows.Forms.TextBox();
            this.BrowseOutPath = new System.Windows.Forms.Button();
            this.outputFileName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimizedGif)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorReduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossy)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceGif
            // 
            this.sourceGif.BackColor = System.Drawing.SystemColors.Control;
            this.sourceGif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceGif.Location = new System.Drawing.Point(28, 41);
            this.sourceGif.Name = "sourceGif";
            this.sourceGif.Size = new System.Drawing.Size(388, 377);
            this.sourceGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourceGif.TabIndex = 0;
            this.sourceGif.TabStop = false;
            this.sourceGif.Click += new System.EventHandler(this.sourceGif_Click);
            // 
            // optimizedGif
            // 
            this.optimizedGif.BackColor = System.Drawing.SystemColors.Control;
            this.optimizedGif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optimizedGif.Location = new System.Drawing.Point(545, 41);
            this.optimizedGif.Name = "optimizedGif";
            this.optimizedGif.Size = new System.Drawing.Size(370, 377);
            this.optimizedGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.optimizedGif.TabIndex = 1;
            this.optimizedGif.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Gif";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(543, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Optimized Gif";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gifHeight);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.gifWidth);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.colorReduction);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lossy);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.compressLevel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(28, 481);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // gifHeight
            // 
            this.gifHeight.Location = new System.Drawing.Point(673, 103);
            this.gifHeight.Name = "gifHeight";
            this.gifHeight.Size = new System.Drawing.Size(180, 22);
            this.gifHeight.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Height";
            // 
            // gifWidth
            // 
            this.gifWidth.Location = new System.Drawing.Point(673, 62);
            this.gifWidth.Name = "gifWidth";
            this.gifWidth.Size = new System.Drawing.Size(180, 22);
            this.gifWidth.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(670, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Width";
            // 
            // colorReduction
            // 
            this.colorReduction.Location = new System.Drawing.Point(356, 79);
            this.colorReduction.Name = "colorReduction";
            this.colorReduction.Size = new System.Drawing.Size(197, 22);
            this.colorReduction.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color Reduction";
            // 
            // lossy
            // 
            this.lossy.Location = new System.Drawing.Point(0, 102);
            this.lossy.Name = "lossy";
            this.lossy.Size = new System.Drawing.Size(171, 22);
            this.lossy.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lossy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compress Level";
            // 
            // compressLevel
            // 
            this.compressLevel.FormattingEnabled = true;
            this.compressLevel.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.compressLevel.Location = new System.Drawing.Point(0, 46);
            this.compressLevel.Name = "compressLevel";
            this.compressLevel.Size = new System.Drawing.Size(171, 24);
            this.compressLevel.TabIndex = 0;
            // 
            // optimizedbtn
            // 
            this.optimizedbtn.BackColor = System.Drawing.Color.Teal;
            this.optimizedbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimizedbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.optimizedbtn.Location = new System.Drawing.Point(382, 634);
            this.optimizedbtn.Name = "optimizedbtn";
            this.optimizedbtn.Size = new System.Drawing.Size(199, 40);
            this.optimizedbtn.TabIndex = 10;
            this.optimizedbtn.Text = "Optimize";
            this.optimizedbtn.UseVisualStyleBackColor = false;
            this.optimizedbtn.Click += new System.EventHandler(this.optimizedbtn_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseBtn.Location = new System.Drawing.Point(333, 13);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(85, 26);
            this.browseBtn.TabIndex = 11;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // sourcePath
            // 
            this.sourcePath.Enabled = false;
            this.sourcePath.Location = new System.Drawing.Point(28, 425);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(388, 20);
            this.sourcePath.TabIndex = 12;
            // 
            // Outputpath
            // 
            this.Outputpath.Location = new System.Drawing.Point(545, 455);
            this.Outputpath.Name = "Outputpath";
            this.Outputpath.Size = new System.Drawing.Size(283, 20);
            this.Outputpath.TabIndex = 13;
            // 
            // BrowseOutPath
            // 
            this.BrowseOutPath.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BrowseOutPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseOutPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowseOutPath.Location = new System.Drawing.Point(834, 452);
            this.BrowseOutPath.Name = "BrowseOutPath";
            this.BrowseOutPath.Size = new System.Drawing.Size(81, 24);
            this.BrowseOutPath.TabIndex = 14;
            this.BrowseOutPath.Text = "Browse";
            this.BrowseOutPath.UseVisualStyleBackColor = false;
            this.BrowseOutPath.Click += new System.EventHandler(this.BrowseOutPath_Click);
            // 
            // outputFileName
            // 
            this.outputFileName.Location = new System.Drawing.Point(587, 425);
            this.outputFileName.Name = "outputFileName";
            this.outputFileName.Size = new System.Drawing.Size(328, 20);
            this.outputFileName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(542, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(957, 692);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.outputFileName);
            this.Controls.Add(this.BrowseOutPath);
            this.Controls.Add(this.Outputpath);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.optimizedbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optimizedGif);
            this.Controls.Add(this.sourceGif);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Gif Optimizer ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.optimizedGif)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorReduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lossy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceGif;
        private System.Windows.Forms.PictureBox optimizedGif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gifHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gifWidth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown colorReduction;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown lossy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox compressLevel;
        private System.Windows.Forms.Button optimizedbtn;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.TextBox Outputpath;
        private System.Windows.Forms.Button BrowseOutPath;
        private System.Windows.Forms.TextBox outputFileName;
        private System.Windows.Forms.Label label8;
    }
}

