using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SzuperhosProjekt
{
	public static class Kepregeny
	{
		public static List<ISzuperhos> szuperhosok = new List<ISzuperhos>();

		public static void Szereplok(string file)
		{
			using (StreamReader sr = new StreamReader(file))
			{
				while(!sr.EndOfStream)
				{
					string[] sor = sr.ReadLine().Split(' ');
					if (sor[0] == "Vasember")
					{
						Vasember vasember = new Vasember();
						for (int i = 0; i < Convert.ToInt32(sor[1]); i++)
						{
							vasember.KutyutKeszit();
						}
						szuperhosok.Add(vasember);
					}
					else if(sor[0] == "Batman")
					{
						Batman batman = new Batman();
						for (int i = 0; i < Convert.ToInt32(sor[1]); i++)
						{
							batman.KutyutKeszit();
						}
						szuperhosok.Add(batman);
					}
					else
					{
						throw new Exception("Nem jó érték a fájlban!");
					}
				}
			}
		}

		public static void Szuperhosok()
		{
			foreach (var i in szuperhosok)
			{
                Console.WriteLine(i.ToString());
            }
		}
	}
}
