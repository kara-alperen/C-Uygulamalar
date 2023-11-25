﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaireÇizme
{
	public class Program
	{
		static void Main(string[] args)
		{
			Circle circle = new Circle();

			Console.Write("Çizmek istediğiniz dairenin yarıçapını giriniz: ");
			int radius = int.Parse(Console.ReadLine());

			circle.DrawCircle(radius);

			Console.ReadKey();
		}
	}
}