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
	public partial class Distance_Formula : Form
	{
		public Distance_Formula()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 
		 * Date: 11/7/2019
		 * 
		 * Purpose: 
		 * The program Distance Formula will allow you to put numbers in to each point to find the distance between those points finding the distance formula.
		 *
		 */

		// Variable Decorations
		int x1, x2, y1, y2;
		double distance;

		private void btnCompute_Click(object sender, EventArgs e)
		{

			// Variable to text boxes
			x1 = int.Parse(txtX1.Text);
			x2 = int.Parse(txtX2.Text);
			y1 = int.Parse(txtY1.Text);
			y2 = int.Parse(txtY2.Text);


			// Compute distance 
			distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			lblDistance.Text = distance.ToString("N");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lblDistance.Text = null;
			txtX1.Clear();
			txtX2.Clear();
			txtY1.Clear();
			txtY2.Clear();
		}

		// Validate Data
		private void txtY1_Validating(object sender, CancelEventArgs e)
		{
			y1.ToString();
			ValidateIsNumber(txtY1);
			AllTermsEntered();
		}

		private void txtX2_Validating(object sender, CancelEventArgs e)
		{
			x2.ToString();
			ValidateIsNumber(txtX2);
			AllTermsEntered();
		}

		private void txtY2_Validating(object sender, CancelEventArgs e)
		{
			y2.ToString();
			ValidateIsNumber(txtY2);
			AllTermsEntered();
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
				MessageBox.Show("That is not valid input. Try again");
				txt2Check.Clear();
				txt2Check.Focus();
				txt2Check.BackColor = Color.White;
				return Double.NaN;
			}
		}

		// Validate if all terms entered
		private void AllTermsEntered()
		{
			if (txtX2.Text != "" && txtX1.Text != "" && txtY1.Text != "" && txtY2.Text != "")
			{
				btnCompute.Enabled = true;
				btnReset.Enabled = true;
				btnCompute.BackColor = Color.LightGreen;
				btnCompute.Focus();
				MessageBox.Show("Please Choose A Character To Enter Imput");
			}
			else
			{
				btnCompute.Enabled = false;
				btnReset.Enabled = false;
			}
		}

		private void txtX1_Validating(object sender, CancelEventArgs e)
		{
			x1.ToString();
			ValidateIsNumber(txtX1);
			AllTermsEntered();
		}
	}
}


