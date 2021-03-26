using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ankieta_samopoczucie
{
	public partial class Form1 : Form
	{
		
		public static bool isOpen = false;
		public static double wynik = 0.0;
		public static double result;
		Wynik okno;

		public Form1()
		{
			InitializeComponent();
			pictureBox3.BringToFront();

		}

		public double srednia()
		{
			wynik = 0.0;

			if (radioButton1_1.Checked)
				wynik += 5;
			else if (radioButton1_2.Checked)
				wynik += 4;
			else if (radioButton1_3.Checked)
				wynik += 3;
			else if (radioButton1_4.Checked)
				wynik += 2;
			else if (radioButton1_5.Checked)
				wynik += 1;


			if (radioButton2_1.Checked)
				wynik += 5;
			else if (radioButton2_2.Checked)
				wynik += 4;
			else if (radioButton2_3.Checked)
				wynik += 3;
			else if (radioButton2_4.Checked)
				wynik += 2;
			else if (radioButton2_5.Checked)
				wynik += 1;


			if (radioButton3_1.Checked)
				wynik += 5;
			else if (radioButton3_2.Checked)
				wynik += 4;
			else if (radioButton3_3.Checked)
				wynik += 3;
			else if (radioButton3_4.Checked)
				wynik += 2;
			else if (radioButton3_5.Checked)
				wynik += 1;


			if (radioButton4_1.Checked)
				wynik += 5;
			else if (radioButton4_2.Checked)
				wynik += 4;
			else if (radioButton4_3.Checked)
				wynik += 3;
			else if (radioButton4_4.Checked)
				wynik += 2;
			else if (radioButton4_5.Checked)
				wynik += 1;


			if (radioButton5_1.Checked)
				wynik += 5;
			else if (radioButton5_2.Checked)
				wynik += 4;
			else if (radioButton5_3.Checked)
				wynik += 3;
			else if (radioButton5_4.Checked)
				wynik += 2;
			else if (radioButton5_5.Checked)
				wynik += 1;

			wynik /= 5;

			return wynik;
		}

		private bool CheckOpened(string name)
		{
			FormCollection fc = Application.OpenForms;

			foreach (Form frm in fc)
			{
				if (frm.Text == name)
				{
					return true;
				}
			}
			return false;
		}

		private void button1_Click(object sender, EventArgs e)
		{

			result = srednia();

			if (result >= 4.5)
			{
				pictureBox5.BringToFront();
			}

			else if (result >= 3.5 && result < 4.5)
			{
				pictureBox4.BringToFront();
			}

			else if (result >= 2.5 && result < 3.5)
			{
				pictureBox3.BringToFront();
			}

			else if (result >= 1.5 && result < 2.5)
			{
				pictureBox2.BringToFront();
			}

			else
			{
				pictureBox1.BringToFront();
			}

			

			//Wynik okno = new Wynik();
			

			if (CheckOpened("Wynik") == true)
			{


				if (result >= 4.5)
				{
					okno.WpictureBox5.BringToFront();
					okno.textBox1.Text = "Bardzo dobrze";
				}

				else if (result >= 3.5 && result < 4.5)
				{
					okno.WpictureBox4.BringToFront();
					okno.textBox1.Text = "Dobrze";
				}

				else if (result >= 2.5 && result < 3.5)
				{
					okno.WpictureBox3.BringToFront();
					okno.textBox1.Text = "Przecietnie";
				}

				else if (Form1.result >= 1.5 && Form1.result < 2.5)
				{
					okno.WpictureBox2.BringToFront();
					okno.textBox1.Text = "Zle";
				}

				else
				{
					okno.WpictureBox1.BringToFront();
					okno.textBox1.Text = "Bardzo zle";
				}
				okno.BringToFront();
				

			}
			if (CheckOpened("Wynik") == false)
			{
				okno = new Wynik();
				okno.Show();
			
			}

			



		}
	}
}
