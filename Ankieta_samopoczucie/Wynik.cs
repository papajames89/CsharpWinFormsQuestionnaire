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
	public partial class Wynik : Form
	{




		public Wynik()
		{
			InitializeComponent();
	

			
			if (Form1.result >= 4.5)
			{
				WpictureBox5.BringToFront();
				textBox1.Text = "Bardzo dobrze";
			}

			else if (Form1.result >= 3.5 && Form1.result < 4.5)
			{
				WpictureBox4.BringToFront();
				textBox1.Text = "Dobrze";
			}

			else if (Form1.result >= 2.5 && Form1.result < 3.5)
			{
				WpictureBox3.BringToFront();
				textBox1.Text = "Przecietnie";
			}

			else if (Form1.result >= 1.5 && Form1.result < 2.5)
			{
				WpictureBox2.BringToFront();
				textBox1.Text = "Zle";
			}

			else
			{
				WpictureBox1.BringToFront();
				textBox1.Text = "Bardzo zle";
			}
			

		}
		
		private void Wynik_Load(object sender, EventArgs e)
		{
			
		
			
		}
		

	}
}
