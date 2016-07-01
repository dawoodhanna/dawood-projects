/*
 * Created by SharpDevelop.
 * User: dawood
 * Date: 2016-07-01
 * Time: 1:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using hello_world;

namespace hello_world_Test
{
	[TestFixture]
	public class hello_world_UnitTest
	{
		[Test]
		public void TestMethod()
		{
			// TODO: Add your test.
			hello_world.Program.SetUp();
			Assert.AreEqual(99,hello_world.Program.number);
		}
	}
}
