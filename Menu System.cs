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
	public partial class MenuSystem : Form
	{
		public MenuSystem()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 
		 * Date: 11/7/2019
		 * 
		 * Purpose: 
		 * The program Menu System will allow the user to selct from a BMI Calculator, Quadratic Formula, Distance Formula, Factorials & Battle Damage.
		 */

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnBattleDamage_Click(object sender, EventArgs e)
		{
			// Open Battle Damage
			Battle_Damage newScreen = new Battle_Damage();
			newScreen.Show();
		}

		private void btnBMI_Click(object sender, EventArgs e)
		{
			// Open BMI Calculator
			BMI_Calculator newScreen = new BMI_Calculator();
			newScreen.Show();
		}

		private void btnQuadratic_Click(object sender, EventArgs e)
		{
			// Open Quadratic Formula
			Quadratic_Formula newScreen = new Quadratic_Formula();
			newScreen.Show();
		}

		private void btnFactorials_Click(object sender, EventArgs e)
		{
			// Open Factorials
			Factorials newScreen = new Factorials();
			newScreen.Show();
		}

		private void btnDistance_Click(object sender, EventArgs e)
		{
			// Opem Distance Formula
			Distance_Formula newScreen = new Distance_Formula();
			newScreen.Show();
		}
	}
}
