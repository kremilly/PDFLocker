namespace PDFLocker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openBtn = new System.Windows.Forms.Button();
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.protectBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.showPass = new System.Windows.Forms.CheckBox();
            this.permitAcessibilityExtractContent = new System.Windows.Forms.CheckBox();
            this.permitAnnotations = new System.Windows.Forms.CheckBox();
            this.permitExtractContent = new System.Windows.Forms.CheckBox();
            this.permitAssembleDocument = new System.Windows.Forms.CheckBox();
            this.permitFullQualityPrint = new System.Windows.Forms.CheckBox();
            this.permitFormsFill = new System.Windows.Forms.CheckBox();
            this.passSize = new System.Windows.Forms.NumericUpDown();
            this.permitPrintDocument = new System.Windows.Forms.CheckBox();
            this.permitModifyDocument = new System.Windows.Forms.CheckBox();
            this.passGenGroup = new System.Windows.Forms.GroupBox();
            this.allowSymbolsCheck = new System.Windows.Forms.CheckBox();
            this.allowNumbersCheck = new System.Windows.Forms.CheckBox();
            this.allowUpperCheck = new System.Windows.Forms.CheckBox();
            this.Size = new System.Windows.Forms.Label();
            this.genPass = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.outputFileTxt = new System.Windows.Forms.TextBox();
            this.outputBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectAllPermissions = new System.Windows.Forms.LinkLabel();
            this.deleteOriginalFile = new System.Windows.Forms.CheckBox();
            this.openOutputFile = new System.Windows.Forms.CheckBox();
            this.creditsLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).BeginInit();
            this.passGenGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openBtn.Location = new System.Drawing.Point(307, 27);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Browse";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // pathTxt
            // 
            this.pathTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathTxt.BackColor = System.Drawing.Color.White;
            this.pathTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pathTxt.Location = new System.Drawing.Point(12, 27);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.ReadOnly = true;
            this.pathTxt.Size = new System.Drawing.Size(289, 23);
            this.pathTxt.TabIndex = 2;
            this.pathTxt.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input file:";
            // 
            // protectBtn
            // 
            this.protectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.protectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.protectBtn.Location = new System.Drawing.Point(301, 416);
            this.protectBtn.Name = "protectBtn";
            this.protectBtn.Size = new System.Drawing.Size(81, 23);
            this.protectBtn.TabIndex = 4;
            this.protectBtn.Text = "Protect";
            this.protectBtn.UseVisualStyleBackColor = true;
            this.protectBtn.Click += new System.EventHandler(this.protectBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // genBtn
            // 
            this.genBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genBtn.Location = new System.Drawing.Point(6, 125);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(154, 23);
            this.genBtn.TabIndex = 6;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // passTxt
            // 
            this.passTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTxt.Location = new System.Drawing.Point(12, 81);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(370, 23);
            this.passTxt.TabIndex = 7;
            // 
            // statusLbl
            // 
            this.statusLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(12, 420);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 15);
            this.statusLbl.TabIndex = 9;
            // 
            // showPass
            // 
            this.showPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showPass.AutoSize = true;
            this.showPass.Checked = true;
            this.showPass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPass.Location = new System.Drawing.Point(274, 56);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(108, 19);
            this.showPass.TabIndex = 10;
            this.showPass.Text = "Show password";
            this.showPass.UseVisualStyleBackColor = true;
            this.showPass.CheckedChanged += new System.EventHandler(this.showPass_CheckedChanged);
            // 
            // permitAcessibilityExtractContent
            // 
            this.permitAcessibilityExtractContent.AutoSize = true;
            this.permitAcessibilityExtractContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitAcessibilityExtractContent.Location = new System.Drawing.Point(6, 22);
            this.permitAcessibilityExtractContent.Name = "permitAcessibilityExtractContent";
            this.permitAcessibilityExtractContent.Size = new System.Drawing.Size(170, 19);
            this.permitAcessibilityExtractContent.TabIndex = 11;
            this.permitAcessibilityExtractContent.Text = "Acessibility Extract Content";
            this.permitAcessibilityExtractContent.UseVisualStyleBackColor = true;
            // 
            // permitAnnotations
            // 
            this.permitAnnotations.AutoSize = true;
            this.permitAnnotations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitAnnotations.Location = new System.Drawing.Point(6, 47);
            this.permitAnnotations.Name = "permitAnnotations";
            this.permitAnnotations.Size = new System.Drawing.Size(91, 19);
            this.permitAnnotations.TabIndex = 12;
            this.permitAnnotations.Text = "Annotations";
            this.permitAnnotations.UseVisualStyleBackColor = true;
            // 
            // permitExtractContent
            // 
            this.permitExtractContent.AutoSize = true;
            this.permitExtractContent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitExtractContent.Location = new System.Drawing.Point(6, 97);
            this.permitExtractContent.Name = "permitExtractContent";
            this.permitExtractContent.Size = new System.Drawing.Size(108, 19);
            this.permitExtractContent.TabIndex = 14;
            this.permitExtractContent.Text = "Extract Content";
            this.permitExtractContent.UseVisualStyleBackColor = true;
            // 
            // permitAssembleDocument
            // 
            this.permitAssembleDocument.AutoSize = true;
            this.permitAssembleDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitAssembleDocument.Location = new System.Drawing.Point(6, 72);
            this.permitAssembleDocument.Name = "permitAssembleDocument";
            this.permitAssembleDocument.Size = new System.Drawing.Size(136, 19);
            this.permitAssembleDocument.TabIndex = 13;
            this.permitAssembleDocument.Text = "Assemble Document";
            this.permitAssembleDocument.UseVisualStyleBackColor = true;
            // 
            // permitFullQualityPrint
            // 
            this.permitFullQualityPrint.AutoSize = true;
            this.permitFullQualityPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitFullQualityPrint.Location = new System.Drawing.Point(6, 147);
            this.permitFullQualityPrint.Name = "permitFullQualityPrint";
            this.permitFullQualityPrint.Size = new System.Drawing.Size(114, 19);
            this.permitFullQualityPrint.TabIndex = 16;
            this.permitFullQualityPrint.Text = "Full Quality Print";
            this.permitFullQualityPrint.UseVisualStyleBackColor = true;
            // 
            // permitFormsFill
            // 
            this.permitFormsFill.AutoSize = true;
            this.permitFormsFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitFormsFill.Location = new System.Drawing.Point(6, 122);
            this.permitFormsFill.Name = "permitFormsFill";
            this.permitFormsFill.Size = new System.Drawing.Size(77, 19);
            this.permitFormsFill.TabIndex = 15;
            this.permitFormsFill.Text = "Forms Fill";
            this.permitFormsFill.UseVisualStyleBackColor = true;
            // 
            // passSize
            // 
            this.passSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passSize.Location = new System.Drawing.Point(42, 22);
            this.passSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.passSize.Name = "passSize";
            this.passSize.Size = new System.Drawing.Size(118, 23);
            this.passSize.TabIndex = 17;
            this.passSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // permitPrintDocument
            // 
            this.permitPrintDocument.AutoSize = true;
            this.permitPrintDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitPrintDocument.Location = new System.Drawing.Point(6, 197);
            this.permitPrintDocument.Name = "permitPrintDocument";
            this.permitPrintDocument.Size = new System.Drawing.Size(110, 19);
            this.permitPrintDocument.TabIndex = 19;
            this.permitPrintDocument.Text = "Print Document";
            this.permitPrintDocument.UseVisualStyleBackColor = true;
            // 
            // permitModifyDocument
            // 
            this.permitModifyDocument.AutoSize = true;
            this.permitModifyDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.permitModifyDocument.Location = new System.Drawing.Point(6, 172);
            this.permitModifyDocument.Name = "permitModifyDocument";
            this.permitModifyDocument.Size = new System.Drawing.Size(123, 19);
            this.permitModifyDocument.TabIndex = 18;
            this.permitModifyDocument.Text = "Modify Document";
            this.permitModifyDocument.UseVisualStyleBackColor = true;
            // 
            // passGenGroup
            // 
            this.passGenGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passGenGroup.Controls.Add(this.allowSymbolsCheck);
            this.passGenGroup.Controls.Add(this.allowNumbersCheck);
            this.passGenGroup.Controls.Add(this.allowUpperCheck);
            this.passGenGroup.Controls.Add(this.Size);
            this.passGenGroup.Controls.Add(this.genBtn);
            this.passGenGroup.Controls.Add(this.passSize);
            this.passGenGroup.Location = new System.Drawing.Point(216, 181);
            this.passGenGroup.Name = "passGenGroup";
            this.passGenGroup.Size = new System.Drawing.Size(166, 153);
            this.passGenGroup.TabIndex = 20;
            this.passGenGroup.TabStop = false;
            this.passGenGroup.Text = "Password generator";
            this.passGenGroup.Visible = false;
            // 
            // allowSymbolsCheck
            // 
            this.allowSymbolsCheck.AutoSize = true;
            this.allowSymbolsCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allowSymbolsCheck.Location = new System.Drawing.Point(6, 100);
            this.allowSymbolsCheck.Name = "allowSymbolsCheck";
            this.allowSymbolsCheck.Size = new System.Drawing.Size(152, 19);
            this.allowSymbolsCheck.TabIndex = 24;
            this.allowSymbolsCheck.Text = "Allow special characters";
            this.allowSymbolsCheck.UseVisualStyleBackColor = true;
            // 
            // allowNumbersCheck
            // 
            this.allowNumbersCheck.AutoSize = true;
            this.allowNumbersCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allowNumbersCheck.Location = new System.Drawing.Point(6, 76);
            this.allowNumbersCheck.Name = "allowNumbersCheck";
            this.allowNumbersCheck.Size = new System.Drawing.Size(106, 19);
            this.allowNumbersCheck.TabIndex = 23;
            this.allowNumbersCheck.Text = "Allow numbers";
            this.allowNumbersCheck.UseVisualStyleBackColor = true;
            // 
            // allowUpperCheck
            // 
            this.allowUpperCheck.AutoSize = true;
            this.allowUpperCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allowUpperCheck.Location = new System.Drawing.Point(6, 51);
            this.allowUpperCheck.Name = "allowUpperCheck";
            this.allowUpperCheck.Size = new System.Drawing.Size(113, 19);
            this.allowUpperCheck.TabIndex = 22;
            this.allowUpperCheck.Text = "Allow uppercase";
            this.allowUpperCheck.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(6, 26);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(30, 15);
            this.Size.TabIndex = 22;
            this.Size.Text = "Size:";
            this.Size.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genPass
            // 
            this.genPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genPass.AutoSize = true;
            this.genPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genPass.Location = new System.Drawing.Point(138, 56);
            this.genPass.Name = "genPass";
            this.genPass.Size = new System.Drawing.Size(130, 19);
            this.genPass.TabIndex = 21;
            this.genPass.Text = "Password generator";
            this.genPass.UseVisualStyleBackColor = true;
            this.genPass.CheckedChanged += new System.EventHandler(this.genPass_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Output file:";
            // 
            // outputFileTxt
            // 
            this.outputFileTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileTxt.BackColor = System.Drawing.Color.White;
            this.outputFileTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFileTxt.Location = new System.Drawing.Point(12, 124);
            this.outputFileTxt.Name = "outputFileTxt";
            this.outputFileTxt.ReadOnly = true;
            this.outputFileTxt.Size = new System.Drawing.Size(289, 23);
            this.outputFileTxt.TabIndex = 23;
            this.outputFileTxt.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // outputBtn
            // 
            this.outputBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputBtn.Location = new System.Drawing.Point(307, 124);
            this.outputBtn.Name = "outputBtn";
            this.outputBtn.Size = new System.Drawing.Size(75, 23);
            this.outputBtn.TabIndex = 22;
            this.outputBtn.Text = "Browse";
            this.outputBtn.UseVisualStyleBackColor = true;
            this.outputBtn.Click += new System.EventHandler(this.outputBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.selectAllPermissions);
            this.groupBox1.Controls.Add(this.permitModifyDocument);
            this.groupBox1.Controls.Add(this.permitAcessibilityExtractContent);
            this.groupBox1.Controls.Add(this.permitAnnotations);
            this.groupBox1.Controls.Add(this.permitAssembleDocument);
            this.groupBox1.Controls.Add(this.permitExtractContent);
            this.groupBox1.Controls.Add(this.permitPrintDocument);
            this.groupBox1.Controls.Add(this.permitFormsFill);
            this.groupBox1.Controls.Add(this.permitFullQualityPrint);
            this.groupBox1.Location = new System.Drawing.Point(12, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 224);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // selectAllPermissions
            // 
            this.selectAllPermissions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllPermissions.AutoSize = true;
            this.selectAllPermissions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.selectAllPermissions.Location = new System.Drawing.Point(145, 0);
            this.selectAllPermissions.Name = "selectAllPermissions";
            this.selectAllPermissions.Size = new System.Drawing.Size(53, 15);
            this.selectAllPermissions.TabIndex = 26;
            this.selectAllPermissions.TabStop = true;
            this.selectAllPermissions.Text = "Select all";
            this.selectAllPermissions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectAllPermissions_LinkClicked);
            // 
            // deleteOriginalFile
            // 
            this.deleteOriginalFile.AutoSize = true;
            this.deleteOriginalFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteOriginalFile.Location = new System.Drawing.Point(12, 153);
            this.deleteOriginalFile.Name = "deleteOriginalFile";
            this.deleteOriginalFile.Size = new System.Drawing.Size(121, 19);
            this.deleteOriginalFile.TabIndex = 20;
            this.deleteOriginalFile.Text = "Delete original file";
            this.deleteOriginalFile.UseVisualStyleBackColor = true;
            // 
            // openOutputFile
            // 
            this.openOutputFile.AutoSize = true;
            this.openOutputFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openOutputFile.Location = new System.Drawing.Point(269, 153);
            this.openOutputFile.Name = "openOutputFile";
            this.openOutputFile.Size = new System.Drawing.Size(113, 19);
            this.openOutputFile.TabIndex = 26;
            this.openOutputFile.Text = "Open output file";
            this.openOutputFile.UseVisualStyleBackColor = true;
            // 
            // creditsLink
            // 
            this.creditsLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creditsLink.AutoSize = true;
            this.creditsLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.creditsLink.Location = new System.Drawing.Point(191, 420);
            this.creditsLink.Name = "creditsLink";
            this.creditsLink.Size = new System.Drawing.Size(104, 15);
            this.creditsLink.TabIndex = 27;
            this.creditsLink.TabStop = true;
            this.creditsLink.Text = "By: @thesilvacesar";
            this.creditsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(394, 451);
            this.Controls.Add(this.creditsLink);
            this.Controls.Add(this.openOutputFile);
            this.Controls.Add(this.deleteOriginalFile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outputFileTxt);
            this.Controls.Add(this.outputBtn);
            this.Controls.Add(this.genPass);
            this.Controls.Add(this.passGenGroup);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.protectBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pathTxt);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Locker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passSize)).EndInit();
            this.passGenGroup.ResumeLayout(false);
            this.passGenGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openBtn;
        private TextBox pathTxt;
        private Label label1;
        private Button protectBtn;
        private Label label2;
        private Button genBtn;
        private TextBox passTxt;
        private Label statusLbl;
        private CheckBox showPass;
        private CheckBox permitAcessibilityExtractContent;
        private CheckBox permitAnnotations;
        private CheckBox permitExtractContent;
        private CheckBox permitAssembleDocument;
        private CheckBox permitFullQualityPrint;
        private CheckBox permitFormsFill;
        private NumericUpDown passSize;
        private CheckBox permitPrintDocument;
        private CheckBox permitModifyDocument;
        private GroupBox passGenGroup;
        private CheckBox genPass;
        private Label Size;
        private CheckBox allowSymbolsCheck;
        private CheckBox allowNumbersCheck;
        private CheckBox allowUpperCheck;
        private System.Windows.Forms.Timer timer;
        private Label label4;
        private TextBox outputFileTxt;
        private Button outputBtn;
        private GroupBox groupBox1;
        private CheckBox deleteOriginalFile;
        private LinkLabel selectAllPermissions;
        private CheckBox openOutputFile;
        private LinkLabel creditsLink;
    }
}