namespace Menu_System
{
	partial class BMI_Calculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMI_Calculator));
			this.lblHeight = new System.Windows.Forms.Label();
			this.lblWeight = new System.Windows.Forms.Label();
			this.lbBmiText = new System.Windows.Forms.Label();
			this.txtHeight = new System.Windows.Forms.TextBox();
			this.txtWeight = new System.Windows.Forms.TextBox();
			this.lblBMI = new System.Windows.Forms.Label();
			this.btnCalculateBMI = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHeight.Location = new System.Drawing.Point(39, 208);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(120, 20);
			this.lblHeight.TabIndex = 0;
			this.lblHeight.Text = "Height (inches):";
			// 
			// lblWeight
			// 
			this.lblWeight.AutoSize = true;
			this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWeight.Location = new System.Drawing.Point(20, 246);
			this.lblWeight.Name = "lblWeight";
			this.lblWeight.Size = new System.Drawing.Size(130, 20);
			this.lblWeight.TabIndex = 1;
			this.lblWeight.Text = "Weight (pounds):";
			// 
			// lbBmiText
			// 
			this.lbBmiText.AutoSize = true;
			this.lbBmiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBmiText.Location = new System.Drawing.Point(108, 280);
			this.lbBmiText.Name = "lbBmiText";
			this.lbBmiText.Size = new System.Drawing.Size(42, 20);
			this.lbBmiText.TabIndex = 2;
			this.lbBmiText.Text = "BMI:";
			// 
			// txtHeight
			// 
			this.txtHeight.Location = new System.Drawing.Point(165, 208);
			this.txtHeight.Name = "txtHeight";
			this.txtHeight.Size = new System.Drawing.Size(100, 20);
			this.txtHeight.TabIndex = 3;
			this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtHeight_Validating);
			// 
			// txtWeight
			// 
			this.txtWeight.Location = new System.Drawing.Point(165, 248);
			this.txtWeight.Name = "txtWeight";
			this.txtWeight.Size = new System.Drawing.Size(100, 20);
			this.txtWeight.TabIndex = 4;
			this.txtWeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtWeight_Validating);
			// 
			// lblBMI
			// 
			this.lblBMI.AutoSize = true;
			this.lblBMI.BackColor = System.Drawing.Color.White;
			this.lblBMI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBMI.Location = new System.Drawing.Point(165, 281);
			this.lblBMI.Name = "lblBMI";
			this.lblBMI.Size = new System.Drawing.Size(2, 20);
			this.lblBMI.TabIndex = 5;
			// 
			// btnCalculateBMI
			// 
			this.btnCalculateBMI.Location = new System.Drawing.Point(306, 222);
			this.btnCalculateBMI.Name = "btnCalculateBMI";
			this.btnCalculateBMI.Size = new System.Drawing.Size(98, 32);
			this.btnCalculateBMI.TabIndex = 6;
			this.btnCalculateBMI.Text = "Calculate BMI";
			this.btnCalculateBMI.UseVisualStyleBackColor = true;
			this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(306, 260);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(98, 20);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(306, 286);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(98, 20);
			this.btnExit.TabIndex = 8;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(405, 179);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// BMI_Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RosyBrown;
			this.ClientSize = new System.Drawing.Size(429, 341);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalculateBMI);
			this.Controls.Add(this.lblBMI);
			this.Controls.Add(this.txtWeight);
			this.Controls.Add(this.txtHeight);
			this.Controls.Add(this.lbBmiText);
			this.Controls.Add(this.lblWeight);
			this.Controls.Add(this.lblHeight);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "BMI_Calculator";
			this.Text = "BMI Calculator";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.Label lblWeight;
		private System.Windows.Forms.Label lbBmiText;
		private System.Windows.Forms.TextBox txtHeight;
		private System.Windows.Forms.TextBox txtWeight;
		private System.Windows.Forms.Label lblBMI;
		private System.Windows.Forms.Button btnCalculateBMI;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}