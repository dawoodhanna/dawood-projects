/*
 * Created by SharpDevelop.
 * User: dawood
 * Date: 2016-07-01
 * Time: 11:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using hello_world;

namespace hello_world
{
	[TestFixture]
	public class hello_world_Test
	{
		
		[Test]
		public void TestMethod()
		{
			Program.SetUp();
			Assert.AreEqual(99,Program.number);
		}
	}
}
