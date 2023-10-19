using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
	public abstract class Bosszuallo : ISzuperhos
	{
		private double szuperero;
		private bool vanEGyengesege;

		public Bosszuallo(double szuperero, bool vanEGyengesege)
		{
			this.szuperero = szuperero;
			this.vanEGyengesege = vanEGyengesege;
		}

		public double Szuperero { get => szuperero; set => szuperero = value; }
		public bool VanEGyengesege { get => vanEGyengesege; set => vanEGyengesege = value; }

		public bool LegyoziE(ISzuperhos szuperhos)
		{
			if(szuperhos is Bosszuallo)
			{
				return ((Bosszuallo)szuperhos).vanEGyengesege && szuperhos.MekkoraAzEreje() < this.MekkoraAzEreje();
			}
			else
			{
				return szuperhos.MekkoraAzEreje() * 2 <= this.MekkoraAzEreje();
			}
		}

		public double MekkoraAzEreje()
		{
			return this.szuperero;
		}

		public abstract bool MegmentiAVilagot();

		public override string ToString()
		{
			string gyengeseg = "";
			if (this.vanEGyengesege)
			{
				gyengeseg = "van";
			}
			else { gyengeseg = "nincs"; }
			return $"Szupererő: {this.szuperero}; {gyengeseg} gyengesége";
		}
	}
}
