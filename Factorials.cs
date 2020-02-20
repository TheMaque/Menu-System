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
	public partial class Factorials : Form
	{
		public Factorials()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 
		 * Date: 11/7/2019
		 * 
		 * Purpose: 
		 * The program Factorial will allow the user to put user input in fro finding the factorial of a specific number.
		 */
		
			// Global Variable
		int factorialNumber;
		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// Varibale Decorations
			decimal factorial = 1;

			for (int counter = 1; counter <= factorialNumber; counter++)
			{
				factorial = factorial * counter;

			}
			txtAnswer.Text = factorial.ToString();
		}

		private void txtNumber_Validating(object sender, CancelEventArgs e)
		{
			// Validate if number
			try
			{
				factorialNumber = int.Parse(txtNumber.Text);
			}
			catch
			{
				MessageBox.Show("Invlaid Number. Please Try Again.");
				txtNumber.Clear();
				txtNumber.Focus();
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			// Close program
			this.Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Clear contents
			txtNumber.Clear();
			txtAnswer.Clear();
		}
	}
}
