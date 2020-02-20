namespace Menu_System
{
	partial class Quadratic_Formula
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
			this.btnSolve = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.grpSolutions = new System.Windows.Forms.GroupBox();
			this.txtSolutionX2 = new System.Windows.Forms.Label();
			this.txtSolutionX1 = new System.Windows.Forms.Label();
			this.lblX2 = new System.Windows.Forms.Label();
			this.lblX1 = new System.Windows.Forms.Label();
			this.grpEqTerms = new System.Windows.Forms.GroupBox();
			this.txtTermC = new System.Windows.Forms.TextBox();
			this.lblTermC = new System.Windows.Forms.Label();
			this.txtTermB = new System.Windows.Forms.TextBox();
			this.lblTermB = new System.Windows.Forms.Label();
			this.txtTermA = new System.Windows.Forms.TextBox();
			this.lblTermA = new System.Windows.Forms.Label();
			this.grpSolutions.SuspendLayout();
			this.grpEqTerms.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSolve
			// 
			this.btnSolve.Enabled = false;
			this.btnSolve.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSolve.Location = new System.Drawing.Point(12, 179);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(272, 39);
			this.btnSolve.TabIndex = 11;
			this.btnSolve.Text = "Solve";
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
			// 
			// btnReset
			// 
			this.btnReset.Enabled = false;
			this.btnReset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(305, 179);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(272, 39);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// grpSolutions
			// 
			this.grpSolutions.BackColor = System.Drawing.Color.AntiqueWhite;
			this.grpSolutions.Controls.Add(this.txtSolutionX2);
			this.grpSolutions.Controls.Add(this.txtSolutionX1);
			this.grpSolutions.Controls.Add(this.lblX2);
			this.grpSolutions.Controls.Add(this.lblX1);
			this.grpSolutions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpSolutions.Location = new System.Drawing.Point(254, 12);
			this.grpSolutions.Name = "grpSolutions";
			this.grpSolutions.Size = new System.Drawing.Size(323, 161);
			this.grpSolutions.TabIndex = 9;
			this.grpSolutions.TabStop = false;
			this.grpSolutions.Text = "Solutions";
			// 
			// txtSolutionX2
			// 
			this.txtSolutionX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSolutionX2.Location = new System.Drawing.Point(51, 87);
			this.txtSolutionX2.Name = "txtSolutionX2";
			this.txtSolutionX2.Size = new System.Drawing.Size(257, 27);
			this.txtSolutionX2.TabIndex = 8;
			this.txtSolutionX2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtSolutionX1
			// 
			this.txtSolutionX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSolutionX1.Location = new System.Drawing.Point(51, 54);
			this.txtSolutionX1.Name = "txtSolutionX1";
			this.txtSolutionX1.Size = new System.Drawing.Size(257, 27);
			this.txtSolutionX1.TabIndex = 7;
			this.txtSolutionX1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblX2
			// 
			this.lblX2.AutoSize = true;
			this.lblX2.Location = new System.Drawing.Point(13, 90);
			this.lblX2.Name = "lblX2";
			this.lblX2.Size = new System.Drawing.Size(32, 21);
			this.lblX2.TabIndex = 4;
			this.lblX2.Text = "X2:";
			// 
			// lblX1
			// 
			this.lblX1.AutoSize = true;
			this.lblX1.Location = new System.Drawing.Point(13, 57);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(32, 21);
			this.lblX1.TabIndex = 2;
			this.lblX1.Text = "X1:";
			// 
			// grpEqTerms
			// 
			this.grpEqTerms.BackColor = System.Drawing.Color.AntiqueWhite;
			this.grpEqTerms.Controls.Add(this.txtTermC);
			this.grpEqTerms.Controls.Add(this.lblTermC);
			this.grpEqTerms.Controls.Add(this.txtTermB);
			this.grpEqTerms.Controls.Add(this.lblTermB);
			this.grpEqTerms.Controls.Add(this.txtTermA);
			this.grpEqTerms.Controls.Add(this.lblTermA);
			this.grpEqTerms.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpEqTerms.Location = new System.Drawing.Point(12, 12);
			this.grpEqTerms.Name = "grpEqTerms";
			this.grpEqTerms.Size = new System.Drawing.Size(227, 161);
			this.grpEqTerms.TabIndex = 8;
			this.grpEqTerms.TabStop = false;
			this.grpEqTerms.Text = "Equation Terms";
			// 
			// txtTermC
			// 
			this.txtTermC.Location = new System.Drawing.Point(101, 108);
			this.txtTermC.Name = "txtTermC";
			this.txtTermC.Size = new System.Drawing.Size(101, 27);
			this.txtTermC.TabIndex = 3;
			this.txtTermC.Validating += new System.ComponentModel.CancelEventHandler(this.txtTermC_Validating);
			// 
			// lblTermC
			// 
			this.lblTermC.AutoSize = true;
			this.lblTermC.Location = new System.Drawing.Point(22, 111);
			this.lblTermC.Name = "lblTermC";
			this.lblTermC.Size = new System.Drawing.Size(73, 21);
			this.lblTermC.TabIndex = 4;
			this.lblTermC.Text = "Term C: ";
			// 
			// txtTermB
			// 
			this.txtTermB.Location = new System.Drawing.Point(101, 75);
			this.txtTermB.Name = "txtTermB";
			this.txtTermB.Size = new System.Drawing.Size(101, 27);
			this.txtTermB.TabIndex = 2;
			this.txtTermB.Validating += new System.ComponentModel.CancelEventHandler(this.txtTermB_Validating);
			// 
			// lblTermB
			// 
			this.lblTermB.AutoSize = true;
			this.lblTermB.Location = new System.Drawing.Point(22, 78);
			this.lblTermB.Name = "lblTermB";
			this.lblTermB.Size = new System.Drawing.Size(69, 21);
			this.lblTermB.TabIndex = 2;
			this.lblTermB.Text = "Term B: ";
			// 
			// txtTermA
			// 
			this.txtTermA.Location = new System.Drawing.Point(101, 42);
			this.txtTermA.Name = "txtTermA";
			this.txtTermA.Size = new System.Drawing.Size(101, 27);
			this.txtTermA.TabIndex = 1;
			this.txtTermA.Validating += new System.ComponentModel.CancelEventHandler(this.txtTermA_Validating);
			// 
			// lblTermA
			// 
			this.lblTermA.AutoSize = true;
			this.lblTermA.Location = new System.Drawing.Point(22, 45);
			this.lblTermA.Name = "lblTermA";
			this.lblTermA.Size = new System.Drawing.Size(73, 21);
			this.lblTermA.TabIndex = 0;
			this.lblTermA.Text = "Term A: ";
			// 
			// Quadratic_Formula
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Navy;
			this.ClientSize = new System.Drawing.Size(597, 233);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.grpSolutions);
			this.Controls.Add(this.grpEqTerms);
			this.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Name = "Quadratic_Formula";
			this.Text = "Quadratic Formula";
			this.Load += new System.EventHandler(this.Quadratic_Formula_Load);
			this.grpSolutions.ResumeLayout(false);
			this.grpSolutions.PerformLayout();
			this.grpEqTerms.ResumeLayout(false);
			this.grpEqTerms.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSolve;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.GroupBox grpSolutions;
		private System.Windows.Forms.Label txtSolutionX2;
		private System.Windows.Forms.Label txtSolutionX1;
		private System.Windows.Forms.Label lblX2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.GroupBox grpEqTerms;
		private System.Windows.Forms.TextBox txtTermC;
		private System.Windows.Forms.Label lblTermC;
		private System.Windows.Forms.TextBox txtTermB;
		private System.Windows.Forms.Label lblTermB;
		private System.Windows.Forms.TextBox txtTermA;
		private System.Windows.Forms.Label lblTermA;
	}
}