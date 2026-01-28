namespace lab2
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
            txtInput = new TextBox();
            button1 = new Button();
            txtArrayInput = new TextBox();
            button2 = new Button();
            lblSumResult = new Label();
            lblResult = new Label();
            lblFiboResult = new Label();
            FiboCal = new Button();
            FiboInput = new TextBox();
            PowerCal = new Button();
            inputx = new TextBox();
            label1 = new Label();
            lblPowerResult = new Label();
            inputpower = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(68, 136);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(217, 23);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(68, 165);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFactorial_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(68, 48);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(217, 23);
            txtArrayInput.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(68, 77);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(68, 103);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(34, 15);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Sum:";
            lblSumResult.Click += label1_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(68, 191);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(55, 15);
            lblResult.TabIndex = 5;
            lblResult.Text = "Factorial:";
            lblResult.Click += label1_Click_1;
            // 
            // lblFiboResult
            // 
            lblFiboResult.AutoSize = true;
            lblFiboResult.Location = new Point(68, 276);
            lblFiboResult.Name = "lblFiboResult";
            lblFiboResult.Size = new Size(24, 15);
            lblFiboResult.TabIndex = 6;
            lblFiboResult.Text = "F =";
            // 
            // FiboCal
            // 
            FiboCal.Location = new Point(68, 250);
            FiboCal.Name = "FiboCal";
            FiboCal.Size = new Size(75, 23);
            FiboCal.TabIndex = 7;
            FiboCal.Text = "Calculate";
            FiboCal.UseVisualStyleBackColor = true;
            FiboCal.Click += FiboCal_Click;
            // 
            // FiboInput
            // 
            FiboInput.Location = new Point(68, 221);
            FiboInput.Name = "FiboInput";
            FiboInput.Size = new Size(217, 23);
            FiboInput.TabIndex = 8;
            // 
            // PowerCal
            // 
            PowerCal.Location = new Point(68, 373);
            PowerCal.Name = "PowerCal";
            PowerCal.Size = new Size(75, 23);
            PowerCal.TabIndex = 9;
            PowerCal.Text = "Calculate";
            PowerCal.UseVisualStyleBackColor = true;
            PowerCal.Click += button3_Click;
            // 
            // inputx
            // 
            inputx.Location = new Point(68, 318);
            inputx.Name = "inputx";
            inputx.Size = new Size(217, 23);
            inputx.TabIndex = 10;
            inputx.TextChanged += inputx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 399);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 11;
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(68, 399);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(43, 15);
            lblPowerResult.TabIndex = 12;
            lblPowerResult.Text = "Power:";
            lblPowerResult.Click += lblPowerResult_Click;
            // 
            // inputpower
            // 
            inputpower.Location = new Point(68, 344);
            inputpower.Name = "inputpower";
            inputpower.Size = new Size(217, 23);
            inputpower.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 321);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 14;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 347);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 15;
            label3.Text = "Power";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 461);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inputpower);
            Controls.Add(lblPowerResult);
            Controls.Add(label1);
            Controls.Add(inputx);
            Controls.Add(PowerCal);
            Controls.Add(FiboInput);
            Controls.Add(FiboCal);
            Controls.Add(lblFiboResult);
            Controls.Add(lblResult);
            Controls.Add(lblSumResult);
            Controls.Add(button2);
            Controls.Add(txtArrayInput);
            Controls.Add(button1);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button button1;
        private TextBox txtArrayInput;
        private Button button2;
        private Label lblSumResult;
        private Label lblResult;
        private Label lblFiboResult;
        private Button FiboCal;
        private TextBox FiboInput;
        private Button PowerCal;
        private TextBox inputx;
        private Label label1;
        private Label lblPowerResult;
        private TextBox inputpower;
        private Label label2;
        private Label label3;
    }
}
