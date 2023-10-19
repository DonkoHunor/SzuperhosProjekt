using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
	public class Batman : ISzuperhos, IMilliardos
	{
		private double lelemenyesseg;

		public Batman()
		{
			this.lelemenyesseg = 100;
		}

		public void KutyutKeszit()
		{
			this.lelemenyesseg += 50;
		}

		public bool LegyoziE(ISzuperhos szuperhos)
		{
			return szuperhos.MekkoraAzEreje() < this.lelemenyesseg;
		}

		public double MekkoraAzEreje()
		{
			return this.lelemenyesseg * 2;
		}

		public override string ToString()
		{
			return $"Batman: leleményesség: {this.lelemenyesseg}";
		}
	}
}
