/*
 * Created by SharpDevelop.
 * User: dawood
 * Date: 2016-07-01
 * Time: 10:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hello_world
{
	public class Program
		
	{
		public static int number;
		public static void SetUp()
		{
		number=99;	
		}
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Hello World!");
			SetUp();
			Console.WriteLine("number ;  "+number);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}