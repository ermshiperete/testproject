// Copyright (c) 2011, SIL International. All Rights Reserved.
// <copyright from='2011' to='2011' company='SIL International'>
// Copyright (c) 2011, SIL International. All Rights Reserved.
// Distributable under the terms of either the Common Public License or the
// GNU Lesser General Public License, as specified in the LICENSING.txt file.
// </copyright>
using System;
using NUnit.Framework;
using testproject;

namespace testprojectTests
{
	[TestFixture]
	public class Test
	{
		[Test]
		public void TestCase()
		{
			Assert.AreEqual(8, MainClass.Number());
		}

		[Test]
		public void Number()
		{
			Assert.AreEqual(8, MainClass.Number());
		}

		[Test]
		public void Name()
		{
			Assert.AreEqual("TestProject", MainClass.Name);
		}

		[Test]
		public void Description()
		{
			Assert.AreEqual("Project description", MainClass.Description);
		}

		[Test]
		public void MissingTest()
		{
			Assert.AreEqual(1, MainClass.Untested);
		}

		[Test]
		public void SomeTest()
		{
			Assert.AreEqual(2, MainClass.Some);
		}

		[Test]
		public void Three()
		{
			Assert.AreEqual(3, MainClass.Three);
		}
	}
}

