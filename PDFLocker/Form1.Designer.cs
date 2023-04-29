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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openBtn = new Button();
            pathTxt = new TextBox();
            label1 = new Label();
            protectBtn = new Button();
            label2 = new Label();
            genBtn = new Button();
            passTxt = new TextBox();
            statusLbl = new Label();
            showPass = new CheckBox();
            permitAcessibilityExtractContent = new CheckBox();
            permitAnnotations = new CheckBox();
            permitExtractContent = new CheckBox();
            permitAssembleDocument = new CheckBox();
            permitFullQualityPrint = new CheckBox();
            permitFormsFill = new CheckBox();
            passSize = new NumericUpDown();
            permitPrintDocument = new CheckBox();
            permitModifyDocument = new CheckBox();
            passGenGroup = new GroupBox();
            allowSymbolsCheck = new CheckBox();
            allowNumbersCheck = new CheckBox();
            allowUpperCheck = new CheckBox();
            Size = new Label();
            genPass = new CheckBox();
            timer = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            outputFileTxt = new TextBox();
            outputBtn = new Button();
            groupBox1 = new GroupBox();
            selectAllPermissions = new LinkLabel();
            deleteOriginalFile = new CheckBox();
            openOutputFile = new CheckBox();
            creditsLink = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)passSize).BeginInit();
            passGenGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // openBtn
            // 
            openBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            openBtn.Cursor = Cursors.Hand;
            openBtn.Location = new Point(307, 27);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(75, 23);
            openBtn.TabIndex = 0;
            openBtn.Text = "Browse";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // pathTxt
            // 
            pathTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pathTxt.BackColor = Color.White;
            pathTxt.BorderStyle = BorderStyle.FixedSingle;
            pathTxt.Location = new Point(12, 27);
            pathTxt.Name = "pathTxt";
            pathTxt.ReadOnly = true;
            pathTxt.Size = new Size(289, 23);
            pathTxt.TabIndex = 2;
            pathTxt.Click += openBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Input file:";
            // 
            // protectBtn
            // 
            protectBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            protectBtn.Cursor = Cursors.Hand;
            protectBtn.Location = new Point(301, 416);
            protectBtn.Name = "protectBtn";
            protectBtn.Size = new Size(81, 23);
            protectBtn.TabIndex = 4;
            protectBtn.Text = "Protect";
            protectBtn.UseVisualStyleBackColor = true;
            protectBtn.Click += protectBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            // 
            // genBtn
            // 
            genBtn.Cursor = Cursors.Hand;
            genBtn.Location = new Point(6, 125);
            genBtn.Name = "genBtn";
            genBtn.Size = new Size(154, 23);
            genBtn.TabIndex = 6;
            genBtn.Text = "Generate";
            genBtn.UseVisualStyleBackColor = true;
            genBtn.Click += genBtn_Click;
            // 
            // passTxt
            // 
            passTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passTxt.BorderStyle = BorderStyle.FixedSingle;
            passTxt.Location = new Point(12, 81);
            passTxt.Name = "passTxt";
            passTxt.Size = new Size(370, 23);
            passTxt.TabIndex = 7;
            // 
            // statusLbl
            // 
            statusLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            statusLbl.AutoSize = true;
            statusLbl.Location = new Point(12, 420);
            statusLbl.Name = "statusLbl";
            statusLbl.Size = new Size(0, 15);
            statusLbl.TabIndex = 9;
            // 
            // showPass
            // 
            showPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showPass.AutoSize = true;
            showPass.Checked = true;
            showPass.CheckState = CheckState.Checked;
            showPass.Cursor = Cursors.Hand;
            showPass.Location = new Point(274, 56);
            showPass.Name = "showPass";
            showPass.Size = new Size(108, 19);
            showPass.TabIndex = 10;
            showPass.Text = "Show password";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // permitAcessibilityExtractContent
            // 
            permitAcessibilityExtractContent.AutoSize = true;
            permitAcessibilityExtractContent.Cursor = Cursors.Hand;
            permitAcessibilityExtractContent.Location = new Point(6, 22);
            permitAcessibilityExtractContent.Name = "permitAcessibilityExtractContent";
            permitAcessibilityExtractContent.Size = new Size(170, 19);
            permitAcessibilityExtractContent.TabIndex = 11;
            permitAcessibilityExtractContent.Text = "Acessibility Extract Content";
            permitAcessibilityExtractContent.UseVisualStyleBackColor = true;
            // 
            // permitAnnotations
            // 
            permitAnnotations.AutoSize = true;
            permitAnnotations.Cursor = Cursors.Hand;
            permitAnnotations.Location = new Point(6, 47);
            permitAnnotations.Name = "permitAnnotations";
            permitAnnotations.Size = new Size(91, 19);
            permitAnnotations.TabIndex = 12;
            permitAnnotations.Text = "Annotations";
            permitAnnotations.UseVisualStyleBackColor = true;
            // 
            // permitExtractContent
            // 
            permitExtractContent.AutoSize = true;
            permitExtractContent.Cursor = Cursors.Hand;
            permitExtractContent.Location = new Point(6, 97);
            permitExtractContent.Name = "permitExtractContent";
            permitExtractContent.Size = new Size(108, 19);
            permitExtractContent.TabIndex = 14;
            permitExtractContent.Text = "Extract Content";
            permitExtractContent.UseVisualStyleBackColor = true;
            // 
            // permitAssembleDocument
            // 
            permitAssembleDocument.AutoSize = true;
            permitAssembleDocument.Cursor = Cursors.Hand;
            permitAssembleDocument.Location = new Point(6, 72);
            permitAssembleDocument.Name = "permitAssembleDocument";
            permitAssembleDocument.Size = new Size(136, 19);
            permitAssembleDocument.TabIndex = 13;
            permitAssembleDocument.Text = "Assemble Document";
            permitAssembleDocument.UseVisualStyleBackColor = true;
            // 
            // permitFullQualityPrint
            // 
            permitFullQualityPrint.AutoSize = true;
            permitFullQualityPrint.Cursor = Cursors.Hand;
            permitFullQualityPrint.Location = new Point(6, 147);
            permitFullQualityPrint.Name = "permitFullQualityPrint";
            permitFullQualityPrint.Size = new Size(114, 19);
            permitFullQualityPrint.TabIndex = 16;
            permitFullQualityPrint.Text = "Full Quality Print";
            permitFullQualityPrint.UseVisualStyleBackColor = true;
            // 
            // permitFormsFill
            // 
            permitFormsFill.AutoSize = true;
            permitFormsFill.Cursor = Cursors.Hand;
            permitFormsFill.Location = new Point(6, 122);
            permitFormsFill.Name = "permitFormsFill";
            permitFormsFill.Size = new Size(77, 19);
            permitFormsFill.TabIndex = 15;
            permitFormsFill.Text = "Forms Fill";
            permitFormsFill.UseVisualStyleBackColor = true;
            // 
            // passSize
            // 
            passSize.BorderStyle = BorderStyle.FixedSingle;
            passSize.Location = new Point(42, 22);
            passSize.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            passSize.Name = "passSize";
            passSize.Size = new Size(118, 23);
            passSize.TabIndex = 17;
            passSize.Value = new decimal(new int[] { 16, 0, 0, 0 });
            // 
            // permitPrintDocument
            // 
            permitPrintDocument.AutoSize = true;
            permitPrintDocument.Cursor = Cursors.Hand;
            permitPrintDocument.Location = new Point(6, 197);
            permitPrintDocument.Name = "permitPrintDocument";
            permitPrintDocument.Size = new Size(110, 19);
            permitPrintDocument.TabIndex = 19;
            permitPrintDocument.Text = "Print Document";
            permitPrintDocument.UseVisualStyleBackColor = true;
            // 
            // permitModifyDocument
            // 
            permitModifyDocument.AutoSize = true;
            permitModifyDocument.Cursor = Cursors.Hand;
            permitModifyDocument.Location = new Point(6, 172);
            permitModifyDocument.Name = "permitModifyDocument";
            permitModifyDocument.Size = new Size(123, 19);
            permitModifyDocument.TabIndex = 18;
            permitModifyDocument.Text = "Modify Document";
            permitModifyDocument.UseVisualStyleBackColor = true;
            // 
            // passGenGroup
            // 
            passGenGroup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            passGenGroup.Controls.Add(allowSymbolsCheck);
            passGenGroup.Controls.Add(allowNumbersCheck);
            passGenGroup.Controls.Add(allowUpperCheck);
            passGenGroup.Controls.Add(Size);
            passGenGroup.Controls.Add(genBtn);
            passGenGroup.Controls.Add(passSize);
            passGenGroup.Location = new Point(216, 181);
            passGenGroup.Name = "passGenGroup";
            passGenGroup.Size = new Size(166, 153);
            passGenGroup.TabIndex = 20;
            passGenGroup.TabStop = false;
            passGenGroup.Text = "Password generator";
            passGenGroup.Visible = false;
            // 
            // allowSymbolsCheck
            // 
            allowSymbolsCheck.AutoSize = true;
            allowSymbolsCheck.Cursor = Cursors.Hand;
            allowSymbolsCheck.Location = new Point(6, 100);
            allowSymbolsCheck.Name = "allowSymbolsCheck";
            allowSymbolsCheck.Size = new Size(152, 19);
            allowSymbolsCheck.TabIndex = 24;
            allowSymbolsCheck.Text = "Allow special characters";
            allowSymbolsCheck.UseVisualStyleBackColor = true;
            // 
            // allowNumbersCheck
            // 
            allowNumbersCheck.AutoSize = true;
            allowNumbersCheck.Cursor = Cursors.Hand;
            allowNumbersCheck.Location = new Point(6, 76);
            allowNumbersCheck.Name = "allowNumbersCheck";
            allowNumbersCheck.Size = new Size(106, 19);
            allowNumbersCheck.TabIndex = 23;
            allowNumbersCheck.Text = "Allow numbers";
            allowNumbersCheck.UseVisualStyleBackColor = true;
            // 
            // allowUpperCheck
            // 
            allowUpperCheck.AutoSize = true;
            allowUpperCheck.Cursor = Cursors.Hand;
            allowUpperCheck.Location = new Point(6, 51);
            allowUpperCheck.Name = "allowUpperCheck";
            allowUpperCheck.Size = new Size(113, 19);
            allowUpperCheck.TabIndex = 22;
            allowUpperCheck.Text = "Allow uppercase";
            allowUpperCheck.UseVisualStyleBackColor = true;
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Location = new Point(6, 26);
            Size.Name = "Size";
            Size.Size = new Size(30, 15);
            Size.TabIndex = 22;
            Size.Text = "Size:";
            Size.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genPass
            // 
            genPass.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            genPass.AutoSize = true;
            genPass.Cursor = Cursors.Hand;
            genPass.Location = new Point(138, 56);
            genPass.Name = "genPass";
            genPass.Size = new Size(130, 19);
            genPass.TabIndex = 21;
            genPass.Text = "Password generator";
            genPass.UseVisualStyleBackColor = true;
            genPass.CheckedChanged += genPass_CheckedChanged;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += timer_Tick;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 24;
            label4.Text = "Output file:";
            // 
            // outputFileTxt
            // 
            outputFileTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputFileTxt.BackColor = Color.White;
            outputFileTxt.BorderStyle = BorderStyle.FixedSingle;
            outputFileTxt.Location = new Point(12, 124);
            outputFileTxt.Name = "outputFileTxt";
            outputFileTxt.ReadOnly = true;
            outputFileTxt.Size = new Size(289, 23);
            outputFileTxt.TabIndex = 23;
            outputFileTxt.Click += outputBtn_Click;
            // 
            // outputBtn
            // 
            outputBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            outputBtn.Cursor = Cursors.Hand;
            outputBtn.Location = new Point(307, 124);
            outputBtn.Name = "outputBtn";
            outputBtn.Size = new Size(75, 23);
            outputBtn.TabIndex = 22;
            outputBtn.Text = "Browse";
            outputBtn.UseVisualStyleBackColor = true;
            outputBtn.Click += outputBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(selectAllPermissions);
            groupBox1.Controls.Add(permitModifyDocument);
            groupBox1.Controls.Add(permitAcessibilityExtractContent);
            groupBox1.Controls.Add(permitAnnotations);
            groupBox1.Controls.Add(permitAssembleDocument);
            groupBox1.Controls.Add(permitExtractContent);
            groupBox1.Controls.Add(permitPrintDocument);
            groupBox1.Controls.Add(permitFormsFill);
            groupBox1.Controls.Add(permitFullQualityPrint);
            groupBox1.Location = new Point(12, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(198, 224);
            groupBox1.TabIndex = 25;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permissions";
            // 
            // selectAllPermissions
            // 
            selectAllPermissions.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            selectAllPermissions.AutoSize = true;
            selectAllPermissions.LinkBehavior = LinkBehavior.HoverUnderline;
            selectAllPermissions.Location = new Point(145, 0);
            selectAllPermissions.Name = "selectAllPermissions";
            selectAllPermissions.Size = new Size(53, 15);
            selectAllPermissions.TabIndex = 26;
            selectAllPermissions.TabStop = true;
            selectAllPermissions.Text = "Select all";
            selectAllPermissions.LinkClicked += selectAllPermissions_LinkClicked;
            // 
            // deleteOriginalFile
            // 
            deleteOriginalFile.AutoSize = true;
            deleteOriginalFile.Cursor = Cursors.Hand;
            deleteOriginalFile.Location = new Point(12, 153);
            deleteOriginalFile.Name = "deleteOriginalFile";
            deleteOriginalFile.Size = new Size(121, 19);
            deleteOriginalFile.TabIndex = 20;
            deleteOriginalFile.Text = "Delete original file";
            deleteOriginalFile.UseVisualStyleBackColor = true;
            // 
            // openOutputFile
            // 
            openOutputFile.AutoSize = true;
            openOutputFile.Cursor = Cursors.Hand;
            openOutputFile.Location = new Point(269, 153);
            openOutputFile.Name = "openOutputFile";
            openOutputFile.Size = new Size(113, 19);
            openOutputFile.TabIndex = 26;
            openOutputFile.Text = "Open output file";
            openOutputFile.UseVisualStyleBackColor = true;
            // 
            // creditsLink
            // 
            creditsLink.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            creditsLink.AutoSize = true;
            creditsLink.LinkBehavior = LinkBehavior.HoverUnderline;
            creditsLink.Location = new Point(216, 420);
            creditsLink.Name = "creditsLink";
            creditsLink.Size = new Size(79, 15);
            creditsLink.TabIndex = 27;
            creditsLink.TabStop = true;
            creditsLink.Text = "By: @kremilly";
            creditsLink.LinkClicked += creditsLink_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            ClientSize = new Size(394, 451);
            Controls.Add(creditsLink);
            Controls.Add(openOutputFile);
            Controls.Add(deleteOriginalFile);
            Controls.Add(label4);
            Controls.Add(outputFileTxt);
            Controls.Add(outputBtn);
            Controls.Add(genPass);
            Controls.Add(passGenGroup);
            Controls.Add(showPass);
            Controls.Add(statusLbl);
            Controls.Add(passTxt);
            Controls.Add(label2);
            Controls.Add(protectBtn);
            Controls.Add(label1);
            Controls.Add(pathTxt);
            Controls.Add(openBtn);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PDF Locker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)passSize).EndInit();
            passGenGroup.ResumeLayout(false);
            passGenGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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