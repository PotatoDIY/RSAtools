namespace RSAtools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonNewRSA = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.buttonSignCheck = new System.Windows.Forms.Button();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyForSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTextForSign = new System.Windows.Forms.TextBox();
            this.textBoxSignedForSign = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyForSignCheck = new System.Windows.Forms.TextBox();
            this.textBoxTextForSignCheck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMsgForSignCheck = new System.Windows.Forms.Label();
            this.textBoxSignedTextForSignCheck = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEncodeForEncode = new System.Windows.Forms.TextBox();
            this.textBoxTextForEncode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxPublicKeyForEncode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxTextForDecode = new System.Windows.Forms.TextBox();
            this.textBoxEncodeTextForDecode = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxPrivateKeyForDecode = new System.Windows.Forms.TextBox();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.buttonSavePriKey = new System.Windows.Forms.Button();
            this.buttonSavePubKey = new System.Windows.Forms.Button();
            this.buttonOpenPrivateForSign = new System.Windows.Forms.Button();
            this.buttonOpenPublicKeyForSigncheck = new System.Windows.Forms.Button();
            this.buttonOpenPrivateKeyForDecode = new System.Windows.Forms.Button();
            this.buttonOpenPublicKeyForEncode = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewRSA
            // 
            this.buttonNewRSA.Location = new System.Drawing.Point(40, 26);
            this.buttonNewRSA.Name = "buttonNewRSA";
            this.buttonNewRSA.Size = new System.Drawing.Size(183, 75);
            this.buttonNewRSA.TabIndex = 0;
            this.buttonNewRSA.Text = "生成";
            this.buttonNewRSA.UseVisualStyleBackColor = true;
            this.buttonNewRSA.Click += new System.EventHandler(this.buttonNewRSA_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(530, 249);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(183, 75);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "使用私钥加签";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // buttonSignCheck
            // 
            this.buttonSignCheck.Location = new System.Drawing.Point(530, 320);
            this.buttonSignCheck.Name = "buttonSignCheck";
            this.buttonSignCheck.Size = new System.Drawing.Size(183, 75);
            this.buttonSignCheck.TabIndex = 2;
            this.buttonSignCheck.Text = "使用公钥验签";
            this.buttonSignCheck.UseVisualStyleBackColor = true;
            this.buttonSignCheck.Click += new System.EventHandler(this.buttonSignCheck_Click);
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(530, 320);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(183, 75);
            this.buttonEncode.TabIndex = 3;
            this.buttonEncode.Text = "使用公钥加密";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Location = new System.Drawing.Point(40, 150);
            this.textBoxPrivateKey.Multiline = true;
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(454, 376);
            this.textBoxPrivateKey.TabIndex = 5;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Location = new System.Drawing.Point(530, 150);
            this.textBoxPublicKey.Multiline = true;
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(454, 376);
            this.textBoxPublicKey.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(26, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1083, 628);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSavePubKey);
            this.tabPage1.Controls.Add(this.buttonSavePriKey);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxPrivateKey);
            this.tabPage1.Controls.Add(this.textBoxPublicKey);
            this.tabPage1.Controls.Add(this.buttonNewRSA);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1075, 596);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RSA 生成";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonOpenPrivateForSign);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBoxSignedForSign);
            this.tabPage2.Controls.Add(this.textBoxTextForSign);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxPrivateKeyForSign);
            this.tabPage2.Controls.Add(this.buttonSign);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1075, 596);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "私钥加签";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonOpenPublicKeyForSigncheck);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.textBoxSignedTextForSignCheck);
            this.tabPage3.Controls.Add(this.labelMsgForSignCheck);
            this.tabPage3.Controls.Add(this.textBoxTextForSignCheck);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxPublicKeyForSignCheck);
            this.tabPage3.Controls.Add(this.buttonSignCheck);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1075, 596);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "公钥验签";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonOpenPublicKeyForEncode);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxEncodeForEncode);
            this.tabPage4.Controls.Add(this.textBoxTextForEncode);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.textBoxPublicKeyForEncode);
            this.tabPage4.Controls.Add(this.buttonEncode);
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1075, 596);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "公钥加密";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonOpenPrivateKeyForDecode);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.textBoxTextForDecode);
            this.tabPage5.Controls.Add(this.textBoxEncodeTextForDecode);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBoxPrivateKeyForDecode);
            this.tabPage5.Controls.Add(this.buttonDecode);
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1075, 596);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "私钥解密";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.linkLabelGithub);
            this.tabPage6.Controls.Add(this.label15);
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1075, 596);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "关于";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "私钥";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "公钥";
            // 
            // textBoxPrivateKeyForSign
            // 
            this.textBoxPrivateKeyForSign.Location = new System.Drawing.Point(40, 100);
            this.textBoxPrivateKeyForSign.Multiline = true;
            this.textBoxPrivateKeyForSign.Name = "textBoxPrivateKeyForSign";
            this.textBoxPrivateKeyForSign.Size = new System.Drawing.Size(454, 415);
            this.textBoxPrivateKeyForSign.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "私钥";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "内容";
            // 
            // textBoxTextForSign
            // 
            this.textBoxTextForSign.Location = new System.Drawing.Point(530, 100);
            this.textBoxTextForSign.Multiline = true;
            this.textBoxTextForSign.Name = "textBoxTextForSign";
            this.textBoxTextForSign.Size = new System.Drawing.Size(454, 126);
            this.textBoxTextForSign.TabIndex = 10;
            // 
            // textBoxSignedForSign
            // 
            this.textBoxSignedForSign.Location = new System.Drawing.Point(530, 388);
            this.textBoxSignedForSign.Multiline = true;
            this.textBoxSignedForSign.Name = "textBoxSignedForSign";
            this.textBoxSignedForSign.Size = new System.Drawing.Size(454, 126);
            this.textBoxSignedForSign.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "签名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "公钥";
            // 
            // textBoxPublicKeyForSignCheck
            // 
            this.textBoxPublicKeyForSignCheck.Location = new System.Drawing.Point(40, 100);
            this.textBoxPublicKeyForSignCheck.Multiline = true;
            this.textBoxPublicKeyForSignCheck.Name = "textBoxPublicKeyForSignCheck";
            this.textBoxPublicKeyForSignCheck.Size = new System.Drawing.Size(454, 126);
            this.textBoxPublicKeyForSignCheck.TabIndex = 9;
            // 
            // textBoxTextForSignCheck
            // 
            this.textBoxTextForSignCheck.Location = new System.Drawing.Point(40, 320);
            this.textBoxTextForSignCheck.Multiline = true;
            this.textBoxTextForSignCheck.Name = "textBoxTextForSignCheck";
            this.textBoxTextForSignCheck.Size = new System.Drawing.Size(454, 126);
            this.textBoxTextForSignCheck.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "内容";
            // 
            // labelMsgForSignCheck
            // 
            this.labelMsgForSignCheck.AutoSize = true;
            this.labelMsgForSignCheck.Location = new System.Drawing.Point(743, 345);
            this.labelMsgForSignCheck.Name = "labelMsgForSignCheck";
            this.labelMsgForSignCheck.Size = new System.Drawing.Size(80, 18);
            this.labelMsgForSignCheck.TabIndex = 13;
            this.labelMsgForSignCheck.Text = "验签状态";
            // 
            // textBoxSignedTextForSignCheck
            // 
            this.textBoxSignedTextForSignCheck.Location = new System.Drawing.Point(530, 100);
            this.textBoxSignedTextForSignCheck.Multiline = true;
            this.textBoxSignedTextForSignCheck.Name = "textBoxSignedTextForSignCheck";
            this.textBoxSignedTextForSignCheck.Size = new System.Drawing.Size(454, 126);
            this.textBoxSignedTextForSignCheck.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "签名";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(526, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "加密后的字符串";
            // 
            // textBoxEncodeForEncode
            // 
            this.textBoxEncodeForEncode.Location = new System.Drawing.Point(530, 100);
            this.textBoxEncodeForEncode.Multiline = true;
            this.textBoxEncodeForEncode.Name = "textBoxEncodeForEncode";
            this.textBoxEncodeForEncode.Size = new System.Drawing.Size(454, 126);
            this.textBoxEncodeForEncode.TabIndex = 20;
            // 
            // textBoxTextForEncode
            // 
            this.textBoxTextForEncode.Location = new System.Drawing.Point(40, 320);
            this.textBoxTextForEncode.Multiline = true;
            this.textBoxTextForEncode.Name = "textBoxTextForEncode";
            this.textBoxTextForEncode.Size = new System.Drawing.Size(454, 126);
            this.textBoxTextForEncode.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "待加密的内容";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "公钥";
            // 
            // textBoxPublicKeyForEncode
            // 
            this.textBoxPublicKeyForEncode.Location = new System.Drawing.Point(40, 100);
            this.textBoxPublicKeyForEncode.Multiline = true;
            this.textBoxPublicKeyForEncode.Name = "textBoxPublicKeyForEncode";
            this.textBoxPublicKeyForEncode.Size = new System.Drawing.Size(454, 126);
            this.textBoxPublicKeyForEncode.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(530, 347);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "解密后的内容";
            // 
            // textBoxTextForDecode
            // 
            this.textBoxTextForDecode.Location = new System.Drawing.Point(530, 390);
            this.textBoxTextForDecode.Multiline = true;
            this.textBoxTextForDecode.Name = "textBoxTextForDecode";
            this.textBoxTextForDecode.Size = new System.Drawing.Size(454, 126);
            this.textBoxTextForDecode.TabIndex = 18;
            // 
            // textBoxEncodeTextForDecode
            // 
            this.textBoxEncodeTextForDecode.Location = new System.Drawing.Point(530, 100);
            this.textBoxEncodeTextForDecode.Multiline = true;
            this.textBoxEncodeTextForDecode.Name = "textBoxEncodeTextForDecode";
            this.textBoxEncodeTextForDecode.Size = new System.Drawing.Size(454, 126);
            this.textBoxEncodeTextForDecode.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(530, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 16;
            this.label13.Text = "待解密内容";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 15;
            this.label14.Text = "私钥";
            // 
            // textBoxPrivateKeyForDecode
            // 
            this.textBoxPrivateKeyForDecode.Location = new System.Drawing.Point(40, 100);
            this.textBoxPrivateKeyForDecode.Multiline = true;
            this.textBoxPrivateKeyForDecode.Name = "textBoxPrivateKeyForDecode";
            this.textBoxPrivateKeyForDecode.Size = new System.Drawing.Size(454, 415);
            this.textBoxPrivateKeyForDecode.TabIndex = 14;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(530, 251);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(183, 75);
            this.buttonDecode.TabIndex = 13;
            this.buttonDecode.Text = "使用私钥解密";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(40, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(771, 38);
            this.label15.TabIndex = 0;
            this.label15.Text = "一款RSA工具箱，集成了生成、加签、验签、加密、解密等功能。";
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(40, 95);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(341, 18);
            this.linkLabelGithub.TabIndex = 1;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "https://github.com/potatoDIY/RSAtools";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // buttonSavePriKey
            // 
            this.buttonSavePriKey.Location = new System.Drawing.Point(40, 534);
            this.buttonSavePriKey.Name = "buttonSavePriKey";
            this.buttonSavePriKey.Size = new System.Drawing.Size(454, 43);
            this.buttonSavePriKey.TabIndex = 9;
            this.buttonSavePriKey.Text = "保存私钥";
            this.buttonSavePriKey.UseVisualStyleBackColor = true;
            this.buttonSavePriKey.Click += new System.EventHandler(this.buttonSavePriKey_Click);
            // 
            // buttonSavePubKey
            // 
            this.buttonSavePubKey.Location = new System.Drawing.Point(530, 534);
            this.buttonSavePubKey.Name = "buttonSavePubKey";
            this.buttonSavePubKey.Size = new System.Drawing.Size(454, 43);
            this.buttonSavePubKey.TabIndex = 10;
            this.buttonSavePubKey.Text = "保存公钥";
            this.buttonSavePubKey.UseVisualStyleBackColor = true;
            this.buttonSavePubKey.Click += new System.EventHandler(this.buttonSavePubKey_Click);
            // 
            // buttonOpenPrivateForSign
            // 
            this.buttonOpenPrivateForSign.Location = new System.Drawing.Point(100, 30);
            this.buttonOpenPrivateForSign.Name = "buttonOpenPrivateForSign";
            this.buttonOpenPrivateForSign.Size = new System.Drawing.Size(153, 39);
            this.buttonOpenPrivateForSign.TabIndex = 13;
            this.buttonOpenPrivateForSign.Text = "打开私钥文件";
            this.buttonOpenPrivateForSign.UseVisualStyleBackColor = true;
            this.buttonOpenPrivateForSign.Click += new System.EventHandler(this.buttonOpenPrivateForSign_Click);
            // 
            // buttonOpenPublicKeyForSigncheck
            // 
            this.buttonOpenPublicKeyForSigncheck.Location = new System.Drawing.Point(100, 30);
            this.buttonOpenPublicKeyForSigncheck.Name = "buttonOpenPublicKeyForSigncheck";
            this.buttonOpenPublicKeyForSigncheck.Size = new System.Drawing.Size(153, 39);
            this.buttonOpenPublicKeyForSigncheck.TabIndex = 16;
            this.buttonOpenPublicKeyForSigncheck.Text = "打开公钥文件";
            this.buttonOpenPublicKeyForSigncheck.UseVisualStyleBackColor = true;
            this.buttonOpenPublicKeyForSigncheck.Click += new System.EventHandler(this.buttonOpenPublicKeyForSigncheck_Click);
            // 
            // buttonOpenPrivateKeyForDecode
            // 
            this.buttonOpenPrivateKeyForDecode.Location = new System.Drawing.Point(100, 30);
            this.buttonOpenPrivateKeyForDecode.Name = "buttonOpenPrivateKeyForDecode";
            this.buttonOpenPrivateKeyForDecode.Size = new System.Drawing.Size(153, 39);
            this.buttonOpenPrivateKeyForDecode.TabIndex = 20;
            this.buttonOpenPrivateKeyForDecode.Text = "打开私钥文件";
            this.buttonOpenPrivateKeyForDecode.UseVisualStyleBackColor = true;
            this.buttonOpenPrivateKeyForDecode.Click += new System.EventHandler(this.buttonOpenPrivateKeyForDecode_Click);
            // 
            // buttonOpenPublicKeyForEncode
            // 
            this.buttonOpenPublicKeyForEncode.Location = new System.Drawing.Point(100, 30);
            this.buttonOpenPublicKeyForEncode.Name = "buttonOpenPublicKeyForEncode";
            this.buttonOpenPublicKeyForEncode.Size = new System.Drawing.Size(153, 39);
            this.buttonOpenPublicKeyForEncode.TabIndex = 22;
            this.buttonOpenPublicKeyForEncode.Text = "打开公钥文件";
            this.buttonOpenPublicKeyForEncode.UseVisualStyleBackColor = true;
            this.buttonOpenPublicKeyForEncode.Click += new System.EventHandler(this.buttonOpenPublicKeyForEncode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 679);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA 工具箱";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNewRSA;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.Button buttonSignCheck;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxPrivateKey;
        private System.Windows.Forms.TextBox textBoxPublicKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSignedForSign;
        private System.Windows.Forms.TextBox textBoxTextForSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrivateKeyForSign;
        private System.Windows.Forms.Label labelMsgForSignCheck;
        private System.Windows.Forms.TextBox textBoxTextForSignCheck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPublicKeyForSignCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSignedTextForSignCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEncodeForEncode;
        private System.Windows.Forms.TextBox textBoxTextForEncode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxPublicKeyForEncode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxTextForDecode;
        private System.Windows.Forms.TextBox textBoxEncodeTextForDecode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxPrivateKeyForDecode;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonSavePubKey;
        private System.Windows.Forms.Button buttonSavePriKey;
        private System.Windows.Forms.Button buttonOpenPrivateForSign;
        private System.Windows.Forms.Button buttonOpenPublicKeyForSigncheck;
        private System.Windows.Forms.Button buttonOpenPublicKeyForEncode;
        private System.Windows.Forms.Button buttonOpenPrivateKeyForDecode;
    }
}

