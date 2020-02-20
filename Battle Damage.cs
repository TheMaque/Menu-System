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
	public partial class Battle_Damage : Form
	{
		public Battle_Damage()
		{
			InitializeComponent();
		}
		/*
		 * Name: Reggie Telemaque
		 * 9/26/2019
		 * 
		 * Purpose: 
		 * The program Battle Damage wil calculate a users battle damage for a game based on user input.
		 *
		 * Formula From:
		 * https://www.wowhead.com/news=281913/battle-for-azeroth-new-formula-for-calculating-ability-damage
		 */

		private void btnComputeDamage_Click(object sender, EventArgs e)
		{
			int weaponDamage, attackPower;
			double weaponSpeed, damageMultiplier, battleDamage;

			weaponDamage = int.Parse(txtWeaponDamage.Text);
			attackPower = int.Parse(txtAttackPower.Text);
			weaponSpeed = double.Parse(txtWeaponSpeed.Text);
			damageMultiplier = double.Parse(txtDamageMultiplier.Text);
			// Compute Damage
			battleDamage = (weaponDamage + attackPower / 3.5 * weaponSpeed) * damageMultiplier;

			// Display Damage
			lblBattleDamage.Text = battleDamage.ToString("N");

			// Make Restrictions/ Prompt the user
			if (weaponDamage > 500)
				MessageBox.Show($"{weaponDamage} Weapon Damage cannot be more than 500.");
			else if (weaponDamage < 10)
				MessageBox.Show($"{weaponDamage} Weapon Damage cannot be less than 10.");

			// Restriciton for attack power
			if (attackPower > 10)
				MessageBox.Show($"{attackPower} Attack Power cannot be more than 10.");
			else if (attackPower < 1)
				MessageBox.Show($"{attackPower} Attack Power cannot be less than 1.");

			// Restriction for weapon speed
			if (weaponSpeed > 5.0)
				MessageBox.Show($"{weaponSpeed} Weapon Speed cannot be more than 5.0");
			else if (attackPower < 1.0)
				MessageBox.Show($"{weaponSpeed} Weapon Speed cannot be less than 1.0");

			// Restricition for damage multiplier
			if (weaponSpeed > 4.0)
				MessageBox.Show($"{damageMultiplier} Weapon Speed cannot be more than 4.0");
			else if (attackPower < 1.0)
				MessageBox.Show($"{damageMultiplier} Damage Multiplier cannot be less than 1.0");

			// Restriictions
			/* 
			 * Weapon Damage (Range: 10 to 500)
			 * Attack Power(Range: 1 to 10)
			 *  Weapon Speed(Range: 1.0 to 5.0)
			 * Damage Multiplier(Range: 1.0 to 4.0)
			 */

		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// Clear Text Boxes
			txtAttackPower.Clear();
			txtDamageMultiplier.Clear();
			txtWeaponDamage.Clear();
			txtWeaponSpeed.Clear();
			lblBattleDamage.Text = null;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
