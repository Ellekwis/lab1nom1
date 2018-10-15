/*
 * Created by SharpDevelop.
 * User: Артём
 * Date: 19.09.2018
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Лаб1_Ном1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			// TODO: Implement Functionality Here
			
			for(int i=1 ; i<10 ; i++)
				for(int j=1 ; j<10 ; j++)
					Console.Write(i.ToString()+"*"+j.ToString()+"="+Convert.ToString(i*j)+"\t");
			Console.WriteLine();
			Console.ReadKey ();
		}
	}
}