namespace Menu_System
{
	partial class Battle_Damage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battle_Damage));
			this.lblBattleDamage = new System.Windows.Forms.Label();
			this.txtAttackPower = new System.Windows.Forms.TextBox();
			this.txtWeaponSpeed = new System.Windows.Forms.TextBox();
			this.txtDamageMultiplier = new System.Windows.Forms.TextBox();
			this.txtWeaponDamage = new System.Windows.Forms.TextBox();
			this.btnComputeDamage = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblBattleDamage
			// 
			this.lblBattleDamage.AutoSize = true;
			this.lblBattleDamage.BackColor = System.Drawing.Color.White;
			this.lblBattleDamage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblBattleDamage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblBattleDamage.Location = new System.Drawing.Point(152, 181);
			this.lblBattleDamage.Name = "lblBattleDamage";
			this.lblBattleDamage.Size = new System.Drawing.Size(2, 15);
			this.lblBattleDamage.TabIndex = 25;
			// 
			// txtAttackPower
			// 
			this.txtAttackPower.Location = new System.Drawing.Point(155, 62);
			this.txtAttackPower.Name = "txtAttackPower";
			this.txtAttackPower.Size = new System.Drawing.Size(100, 20);
			this.txtAttackPower.TabIndex = 2;
			// 
			// txtWeaponSpeed
			// 
			this.txtWeaponSpeed.Location = new System.Drawing.Point(155, 97);
			this.txtWeaponSpeed.Name = "txtWeaponSpeed";
			this.txtWeaponSpeed.Size = new System.Drawing.Size(100, 20);
			this.txtWeaponSpeed.TabIndex = 3;
			// 
			// txtDamageMultiplier
			// 
			this.txtDamageMultiplier.Location = new System.Drawing.Point(155, 138);
			this.txtDamageMultiplier.Name = "txtDamageMultiplier";
			this.txtDamageMultiplier.Size = new System.Drawing.Size(100, 20);
			this.txtDamageMultiplier.TabIndex = 4;
			// 
			// txtWeaponDamage
			// 
			this.txtWeaponDamage.Location = new System.Drawing.Point(155, 30);
			this.txtWeaponDamage.Name = "txtWeaponDamage";
			this.txtWeaponDamage.Size = new System.Drawing.Size(137, 20);
			this.txtWeaponDamage.TabIndex = 0;
			// 
			// btnComputeDamage
			// 
			this.btnComputeDamage.Location = new System.Drawing.Point(152, 216);
			this.btnComputeDamage.Name = "btnComputeDamage";
			this.btnComputeDamage.Size = new System.Drawing.Size(120, 28);
			this.btnComputeDamage.TabIndex = 5;
			this.btnComputeDamage.Text = "Calculate Damage";
			this.btnComputeDamage.UseVisualStyleBackColor = true;
			this.btnComputeDamage.Click += new System.EventHandler(this.btnComputeDamage_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(175, 250);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(71, 22);
			this.btnClear.TabIndex = 6;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(17, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Battle Damage:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(17, 145);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 13);
			this.label4.TabIndex = 17;
			this.label4.Text = "Damage Multiplier:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(17, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Weapon Speed:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(17, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Attack Power:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(17, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Weapon Damage:";
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(175, 277);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(71, 23);
			this.btnExit.TabIndex = 7;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.ErrorImage = null;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.InitialImage = null;
			this.pictureBox2.Location = new System.Drawing.Point(320, 65);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(111, 145);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// Battle_Damage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Maroon;
			this.ClientSize = new System.Drawing.Size(459, 312);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblBattleDamage);
			this.Controls.Add(this.txtAttackPower);
			this.Controls.Add(this.txtWeaponSpeed);
			this.Controls.Add(this.txtDamageMultiplier);
			this.Controls.Add(this.txtWeaponDamage);
			this.Controls.Add(this.btnComputeDamage);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Battle_Damage";
			this.Text = "3";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblBattleDamage;
		private System.Windows.Forms.TextBox txtAttackPower;
		private System.Windows.Forms.TextBox txtWeaponSpeed;
		private System.Windows.Forms.TextBox txtDamageMultiplier;
		private System.Windows.Forms.TextBox txtWeaponDamage;
		private System.Windows.Forms.Button btnComputeDamage;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnExit;
	}
}