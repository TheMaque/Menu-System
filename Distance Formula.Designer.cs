namespace Menu_System
{
	partial class Distance_Formula
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Distance_Formula));
			this.btnCompute = new System.Windows.Forms.Button();
			this.lblX1 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtY1 = new System.Windows.Forms.TextBox();
			this.txtX1 = new System.Windows.Forms.TextBox();
			this.txtX2 = new System.Windows.Forms.TextBox();
			this.txtY2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblDistance = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCompute
			// 
			this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCompute.Location = new System.Drawing.Point(186, 150);
			this.btnCompute.Name = "btnCompute";
			this.btnCompute.Size = new System.Drawing.Size(125, 39);
			this.btnCompute.TabIndex = 5;
			this.btnCompute.Text = "Compute";
			this.btnCompute.UseVisualStyleBackColor = true;
			this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
			// 
			// lblX1
			// 
			this.lblX1.AutoSize = true;
			this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblX1.Location = new System.Drawing.Point(22, 21);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(43, 18);
			this.lblX1.TabIndex = 1;
			this.lblX1.Text = "X1 = ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(269, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "X2 = ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "Y1 = ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(269, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 18);
			this.label3.TabIndex = 4;
			this.label3.Text = "Y2 = ";
			// 
			// txtY1
			// 
			this.txtY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtY1.Location = new System.Drawing.Point(83, 68);
			this.txtY1.Name = "txtY1";
			this.txtY1.Size = new System.Drawing.Size(122, 24);
			this.txtY1.TabIndex = 2;
			this.txtY1.Validating += new System.ComponentModel.CancelEventHandler(this.txtY1_Validating);
			// 
			// txtX1
			// 
			this.txtX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX1.Location = new System.Drawing.Point(83, 19);
			this.txtX1.Name = "txtX1";
			this.txtX1.Size = new System.Drawing.Size(122, 24);
			this.txtX1.TabIndex = 1;
			this.txtX1.Validating += new System.ComponentModel.CancelEventHandler(this.txtX1_Validating);
			// 
			// txtX2
			// 
			this.txtX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtX2.Location = new System.Drawing.Point(330, 21);
			this.txtX2.Name = "txtX2";
			this.txtX2.Size = new System.Drawing.Size(122, 24);
			this.txtX2.TabIndex = 3;
			this.txtX2.Validating += new System.ComponentModel.CancelEventHandler(this.txtX2_Validating);
			// 
			// txtY2
			// 
			this.txtY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtY2.Location = new System.Drawing.Point(330, 70);
			this.txtY2.Name = "txtY2";
			this.txtY2.Size = new System.Drawing.Size(122, 24);
			this.txtY2.TabIndex = 4;
			this.txtY2.Validating += new System.ComponentModel.CancelEventHandler(this.txtY2_Validating);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(183, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 18);
			this.label4.TabIndex = 11;
			this.label4.Text = "D =";
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(187, 220);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(125, 26);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(86, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(309, 234);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(187, 195);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(125, 26);
			this.btnReset.TabIndex = 6;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblDistance
			// 
			this.lblDistance.AutoSize = true;
			this.lblDistance.BackColor = System.Drawing.Color.White;
			this.lblDistance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDistance.Location = new System.Drawing.Point(241, 111);
			this.lblDistance.Name = "lblDistance";
			this.lblDistance.Size = new System.Drawing.Size(2, 20);
			this.lblDistance.TabIndex = 17;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.DarkKhaki;
			this.groupBox1.Controls.Add(this.txtX2);
			this.groupBox1.Controls.Add(this.lblDistance);
			this.groupBox1.Controls.Add(this.btnCompute);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.lblX1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnExit);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtY2);
			this.groupBox1.Controls.Add(this.txtY1);
			this.groupBox1.Controls.Add(this.txtX1);
			this.groupBox1.Location = new System.Drawing.Point(12, 240);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(479, 253);
			this.groupBox1.TabIndex = 18;
			this.groupBox1.TabStop = false;
			// 
			// Distance_Formula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.ClientSize = new System.Drawing.Size(503, 505);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Distance_Formula";
			this.Text = "Distance Formula";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCompute;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtY1;
		private System.Windows.Forms.TextBox txtX1;
		private System.Windows.Forms.TextBox txtX2;
		private System.Windows.Forms.TextBox txtY2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblDistance;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}