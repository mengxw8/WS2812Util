namespace WS2812Util
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            addPicBtn = new Button();
            generatePythonArray = new Button();
            generateClangArray = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            picBox = new PictureBox();
            arrayTxb = new TextBox();
            toBase64Btn = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(784, 461);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(addPicBtn);
            flowLayoutPanel1.Controls.Add(generatePythonArray);
            flowLayoutPanel1.Controls.Add(generateClangArray);
            flowLayoutPanel1.Controls.Add(toBase64Btn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(778, 54);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // addPicBtn
            // 
            addPicBtn.Location = new Point(3, 3);
            addPicBtn.Name = "addPicBtn";
            addPicBtn.Size = new Size(116, 32);
            addPicBtn.TabIndex = 0;
            addPicBtn.Text = "添加图片";
            addPicBtn.UseVisualStyleBackColor = true;
            addPicBtn.Click += addPicBtn_Click;
            // 
            // generatePythonArray
            // 
            generatePythonArray.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            generatePythonArray.Location = new Point(125, 3);
            generatePythonArray.Name = "generatePythonArray";
            generatePythonArray.Size = new Size(237, 32);
            generatePythonArray.TabIndex = 1;
            generatePythonArray.Text = "生成图像数据Python列表代码";
            generatePythonArray.UseVisualStyleBackColor = true;
            generatePythonArray.Click += generatePythonArray_Click;
            // 
            // generateClangArray
            // 
            generateClangArray.Location = new Point(368, 3);
            generateClangArray.Name = "generateClangArray";
            generateClangArray.Size = new Size(178, 32);
            generateClangArray.TabIndex = 2;
            generateClangArray.Text = "生成图像数据C语言数组代码";
            generateClangArray.UseVisualStyleBackColor = true;
            generateClangArray.Click += generateClangArray_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(arrayTxb, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(778, 395);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(picBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 389);
            panel1.TabIndex = 0;
            // 
            // picBox
            // 
            picBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            picBox.Location = new Point(36, 93);
            picBox.Name = "picBox";
            picBox.Size = new Size(217, 200);
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            picBox.TabIndex = 0;
            picBox.TabStop = false;
            picBox.Paint += picBox_Paint;
            picBox.Resize += picBox_Resize;
            // 
            // arrayTxb
            // 
            arrayTxb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            arrayTxb.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            arrayTxb.Location = new Point(303, 3);
            arrayTxb.Multiline = true;
            arrayTxb.Name = "arrayTxb";
            arrayTxb.ScrollBars = ScrollBars.Both;
            arrayTxb.Size = new Size(472, 389);
            arrayTxb.TabIndex = 1;
            // 
            // toBase64Btn
            // 
            toBase64Btn.Location = new Point(552, 3);
            toBase64Btn.Name = "toBase64Btn";
            toBase64Btn.Size = new Size(146, 32);
            toBase64Btn.TabIndex = 3;
            toBase64Btn.Text = "转Base64字符串";
            toBase64Btn.UseVisualStyleBackColor = true;
            toBase64Btn.Click += toBase64Btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "图片像素点转数组小工具";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addPicBtn;
        private Button generatePythonArray;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private PictureBox picBox;
        private TextBox arrayTxb;
        private Button generateClangArray;
        private Button toBase64Btn;
    }
}