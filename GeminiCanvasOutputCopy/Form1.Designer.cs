namespace GeminiCanvasOutputCopy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rtbCode = new RichTextBox();
            label2 = new Label();
            tbPath = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label3 = new Label();
            tbReplace = new TextBox();
            button1 = new Button();
            btnVerwerk = new Button();
            label4 = new Label();
            lbStatus = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Canvas output";
            // 
            // rtbCode
            // 
            rtbCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbCode.Location = new Point(12, 27);
            rtbCode.Name = "rtbCode";
            rtbCode.Size = new Size(384, 411);
            rtbCode.TabIndex = 1;
            rtbCode.Text = "";
            rtbCode.WordWrap = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(402, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Code path";
            // 
            // tbPath
            // 
            tbPath.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tbPath.Location = new Point(402, 27);
            tbPath.Name = "tbPath";
            tbPath.Size = new Size(355, 23);
            tbPath.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(402, 68);
            label3.Name = "label3";
            label3.Size = new Size(209, 15);
            label3.TabIndex = 4;
            label3.Text = "Replace text (1 per line. Seperated by ;)";
            // 
            // tbReplace
            // 
            tbReplace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tbReplace.Location = new Point(402, 86);
            tbReplace.Multiline = true;
            tbReplace.Name = "tbReplace";
            tbReplace.ScrollBars = ScrollBars.Both;
            tbReplace.Size = new Size(386, 200);
            tbReplace.TabIndex = 5;
            tbReplace.Text = "EXAMPLE_YOUR_ID;12345678";
            tbReplace.WordWrap = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(763, 27);
            button1.Name = "button1";
            button1.Size = new Size(25, 23);
            button1.TabIndex = 6;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnVerwerk
            // 
            btnVerwerk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVerwerk.Location = new Point(402, 415);
            btnVerwerk.Name = "btnVerwerk";
            btnVerwerk.Size = new Size(386, 23);
            btnVerwerk.TabIndex = 7;
            btnVerwerk.Text = "Create / update files";
            btnVerwerk.UseVisualStyleBackColor = true;
            btnVerwerk.Click += btnVerwerk_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(402, 344);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Status";
            // 
            // lbStatus
            // 
            lbStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbStatus.BackColor = SystemColors.ActiveCaption;
            lbStatus.BorderStyle = BorderStyle.FixedSingle;
            lbStatus.ForeColor = SystemColors.ActiveCaptionText;
            lbStatus.Location = new Point(402, 364);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(386, 23);
            lbStatus.TabIndex = 9;
            lbStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbStatus);
            Controls.Add(label4);
            Controls.Add(btnVerwerk);
            Controls.Add(button1);
            Controls.Add(tbReplace);
            Controls.Add(label3);
            Controls.Add(tbPath);
            Controls.Add(label2);
            Controls.Add(rtbCode);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Gemini canvas output copy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbCode;
        private Label label2;
        private TextBox tbPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label3;
        private TextBox tbReplace;
        private Button button1;
        private Button btnVerwerk;
        private Label label4;
        private Label lbStatus;
    }
}
