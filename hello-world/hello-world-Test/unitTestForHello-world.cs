/*
 * Created by SharpDevelop.
 * User: dawood
 * Date: 2016-07-01
 * Time: 2:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using hello_world;

namespace hello_world_Test
{
	[TestFixture]
	public class unitTestForHello_world
	{
		[Test]
		public void TestMethod()
		{
			hello_world.Program.SetUp();
			Assert.AreEqual(105,hello_world.Program.number);
		}
	}
}
