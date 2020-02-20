using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_System
{
	public partial class BMI_Calculator : Form
	{
		public BMI_Calculator()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 
		 * Date: 11/7/2019
		 * 
		 * Purpose: 
		 * The program BMI Calculator will allow the user to put in input for weight and height to find bmi using the formula.
		 */

		double weight, height, bmi;

		private void btnCalculateBMI_Click(object sender, EventArgs e)
		{
			// Variable decorations


			// Variables to textbox
			weight = double.Parse(txtWeight.Text);
			height = double.Parse(txtHeight.Text);

			// Compute BMI
			bmi = 703 * (weight / Math.Pow(height, 2));
			lblBMI.Text = bmi.ToString("N");



		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// Clear content
			txtHeight.Clear();
			txtWeight.Clear();
			lblBMI.Text = null;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Close program
			this.Close();
		}
		// Validate if input entered is a number
		private double ValidateIsNumber(TextBox txt2Check)
		{
			try
			{
				return double.Parse(txt2Check.Text);
			}
			catch
			{
				txt2Check.BackColor = Color.Red;
				MessageBox.Show("That is valid input. Try again");
				txt2Check.Clear();
				txt2Check.Focus();
				txt2Check.BackColor = Color.White;
				return Double.NaN;
			}
		}

		private void txtWeight_Validating(object sender, CancelEventArgs e)
		{
			weight = ValidateIsNumber(txtWeight);
			AllTermsEntered();
		}

		//  Show if all terms are entered
		private void AllTermsEntered()
		{
			if (txtHeight.Text != "" && txtHeight.Text != "")
			{
				btnCalculateBMI.Enabled = true;
				btnClear.Enabled = true;
				btnCalculateBMI.BackColor = Color.LightGreen;
				btnCalculateBMI.Focus();
			}
			else
			{
				btnCalculateBMI.Enabled = false;
				btnClear.Enabled = false;
			}
		}
		// Validate
		private void txtHeight_Validating(object sender, CancelEventArgs e)
		{
			height = ValidateIsNumber(txtHeight);
			AllTermsEntered();
		}
	}
}
