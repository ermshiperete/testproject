// Copyright (c) 2011, SIL International. All Rights Reserved.
// <copyright from='2011' to='2011' company='SIL International'>
// Copyright (c) 2011, SIL International. All Rights Reserved.
// Distributable under the terms of either the Common Public License or the
// GNU Lesser General Public License, as specified in the LICENSING.txt file.
// </copyright>
using System;

// Comment
namespace testproject
{
	class MainClass
	{
		public static int Number()
		{
			return 7;
		}

		public static string Name
		{
			get { return "TestProject"; }
		}

		public static string Project
		{
			get { return "This is the name of the project"; }
		}

		public static string Description
		{
			get { return "Project description";}
		}

		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}

