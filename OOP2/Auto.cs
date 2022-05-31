using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
	internal class Auto
	{
		private string znacka;
		private float spotreba; //na 100 km 
		private int ujetoCelkem;
		private DateTime okamzikRozjezdu;
		private int dobaJizdyCelkem; // v sekundach
		public bool Jede { get; private set; }

		public Auto(string znacka, int spotreba)
		{
			this.znacka = znacka;
			this.spotreba = spotreba;
			ujetoCelkem = 0;
			dobaJizdyCelkem = 0;
			this.Jede = false;

		}

		public int VratUjeteKm()
		{
			return this.ujetoCelkem;
		}
		public void Rozjed()
		{
			if (this.Jede == false){
				this.Jede = true;
				this.okamzikRozjezdu = DateTime.Now;
			}
			else MessageBox.Show("Auto už jede!");
			
		}
		public void Zastav(int km)
		{
			if (this.Jede == true){
				this.Jede = false;
				this.ujetoCelkem += km;
				this.dobaJizdyCelkem += (DateTime.Now - this.okamzikRozjezdu).Seconds;}
			else MessageBox.Show("Auto už stojí!");
		}
		public float CelkovaSpotreba()
		{
			return this.ujetoCelkem * (this.spotreba / (float)100);
		}
		public override string ToString()
		{
			if (this.Jede == true){
				return "Auto jede, má značku " + this.znacka + ", spotřebu: " + this.spotreba + ", celkem ujelo kilometrů: " + this.ujetoCelkem + ", celkova doba vsech jizd je: " + this.dobaJizdyCelkem + " sekund";
			}
			else{
				return "Auto nejede, má značku " + this.znacka + ", spotřebu: " + this.spotreba + ", celkem ujelo kilometrů: " + this.ujetoCelkem + ", celkova doba vsech jizd je: " + this.dobaJizdyCelkem + " sekund";
			}
		}
	}
}
