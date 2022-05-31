using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
		Auto auto;
		private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "0"){
				MessageBox.Show("Musíš zadat značku a spotřebu.");
			}
			else{
				try{
					auto = new Auto(textBox1.Text, int.Parse(textBox2.Text));
					button2.Visible = true;
					button3.Visible = true;
					button4.Visible = true;
					label3.Visible = true;
					label4.Visible = true;
					label5.Visible = true;
					label6.Visible = true;
					textBox1.Enabled = false;
					textBox2.Enabled = false;
					button1.Enabled = false;
					textBox3.Visible = true;
					label5.Text = "Značka: " + textBox1.Text;
					label6.Text = "Spotřeba: " + textBox2.Text + " l/100km";
				}
				catch{
					MessageBox.Show("Spotřeba pouze v cislech!");
				}
			}
		}

        private void button4_Click(object sender, EventArgs e)
        {
			MessageBox.Show(auto.ToString());
		}

        private void button3_Click(object sender, EventArgs e)
        {
			auto.Rozjed();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			if (String.IsNullOrEmpty(textBox3.Text)){
				MessageBox.Show("Musíš zadat počet ujetých km!");
			}
			else{
				try{
					auto.Zastav(int.Parse(textBox3.Text));
					label3.Text = "Celkem ujeto: " + auto.VratUjeteKm().ToString() + " km";
					label4.Text = "Celkova spotreba: " + auto.CelkovaSpotreba().ToString("0.00") + " l";
				}
				catch{
					MessageBox.Show("Pouze cisla!");
				}
			}
		}
    }
}
