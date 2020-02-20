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
	public partial class Quadratic_Formula : Form
	{
		public Quadratic_Formula()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 
		 * Date: 11/7/2019
		 * 
		 * Purpose: 
		 * The program Quadratic Formula will allow the user to put in input for x1 and x2 to find the quadratic formula. 
		 */

		double termA, termB, termC;
	

		private void btnSolve_Click(object sender, EventArgs e)
		{
			// Variables
			double discriminate = Math.Pow(termB, 2) - 4 * termA * termC;
			double xSol1, xSol2;

			// Determines if real number
			if (discriminate >= 0) // Real Numbers
			{
				xSol1 = (-termB + Math.Sqrt(discriminate)) / (2 * termA);
				xSol2 = (-termB + Math.Sqrt(discriminate)) / (2 * termA);


				txtSolutionX1.Text = xSol1.ToString("N15");
				txtSolutionX2.Text = xSol2.ToString("N15");
			}
			else
			{
				double beforeSign = termB / (2 * termA);
				double afterSign = Math.Sqrt(Math.Abs(discriminate)) / (2 * termA);

				txtSolutionX1.Text = beforeSign.ToString() + " + " + afterSign.ToString() + "\uD835\uDC56";
				txtSolutionX2.Text = beforeSign.ToString() + " - " + afterSign.ToString() + "\uD835\uDC56";
			}
		}


		private void btnReset_Click(object sender, EventArgs e)
		{
			txtTermA.Clear();
			txtTermB.Clear();
			txtTermC.Clear();
			txtSolutionX1.ResetText();
			txtSolutionX2.ResetText();
		}

			// Validate if all terms entered
		private void txtTermA_Validating(object sender, CancelEventArgs e)
		{
			termA = ValidateIsNumber(txtTermA);
			AllTermsEntered();
		}

		private void txtTermB_Validating(object sender, CancelEventArgs e)
		{
			termB = ValidateIsNumber(txtTermB);
			AllTermsEntered();
		}

		private void txtTermC_Validating(object sender, CancelEventArgs e)
		{
			termC = ValidateIsNumber(txtTermC);
			AllTermsEntered();
		}

		private void Quadratic_Formula_Load(object sender, EventArgs e)
		{
			lblX1.Text = "X\u2081";
			lblX2.Text = "X\u2082";
		}

		private double ValidateIsNumber(TextBox txt2Check)
		{
			try
			{
				return double.Parse(txt2Check.Text);
			}
			catch
			{
				txt2Check.BackColor = Color.Red;
				MessageBox.Show("That is not a valid number. Try again");
				txt2Check.Clear();
				txt2Check.Focus();
				txt2Check.BackColor = Color.White;
				return Double.NaN;
			}
		}
		private void AllTermsEntered()
		{
			if (txtTermA.Text != "" && txtTermB.Text != "" && txtTermC.Text != "")
			{
				btnSolve.Enabled = true;
				btnReset.Enabled = true;
				btnSolve.BackColor = Color.LightGreen;
				btnSolve.Focus();
			}
			else
			{
				btnSolve.Enabled = false;
				btnReset.Enabled = false;
			}
		}

	}
}
	

