namespace CalculatorWin
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
            btnCalculate = new Button();
            tbNum1 = new TextBox();
            tbNum2 = new TextBox();
            cbOp = new ComboBox();
            lblAns = new Label();
            lbleq = new Label();
            SuspendLayout();
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculate.Location = new Point(333, 251);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(148, 57);
            btnCalculate.TabIndex = 0;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // tbNum1
            // 
            tbNum1.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNum1.Location = new Point(96, 138);
            tbNum1.Name = "tbNum1";
            tbNum1.Size = new Size(121, 43);
            tbNum1.TabIndex = 1;
            tbNum1.TextAlign = HorizontalAlignment.Center;
            tbNum1.TextChanged += tbNum1_TextChanged;
            // 
            // tbNum2
            // 
            tbNum2.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbNum2.Location = new Point(392, 138);
            tbNum2.Name = "tbNum2";
            tbNum2.Size = new Size(121, 43);
            tbNum2.TabIndex = 2;
            tbNum2.TextAlign = HorizontalAlignment.Center;
            tbNum2.TextChanged += tbNum2_TextChanged;
            // 
            // cbOp
            // 
            cbOp.BackColor = SystemColors.Info;
            cbOp.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbOp.FormattingEnabled = true;
            cbOp.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOp.Location = new Point(260, 138);
            cbOp.Name = "cbOp";
            cbOp.Size = new Size(90, 44);
            cbOp.TabIndex = 3;
            cbOp.SelectedIndexChanged += cbOp_SelectedIndexChanged;
            // 
            // lblAns
            // 
            lblAns.AutoSize = true;
            lblAns.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAns.Location = new Point(594, 141);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(0, 36);
            lblAns.TabIndex = 4;
            // 
            // lbleq
            // 
            lbleq.AutoSize = true;
            lbleq.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbleq.Location = new Point(541, 141);
            lbleq.Name = "lbleq";
            lbleq.Size = new Size(36, 36);
            lbleq.TabIndex = 5;
            lbleq.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbleq);
            Controls.Add(lblAns);
            Controls.Add(cbOp);
            Controls.Add(tbNum2);
            Controls.Add(tbNum1);
            Controls.Add(btnCalculate);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalculate;
        private TextBox tbNum1;
        private TextBox tbNum2;
        private ComboBox cbOp;
        private Label lblAns;
        private Label lbleq;
    }
}