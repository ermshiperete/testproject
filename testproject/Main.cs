// Copyright (c) 2011, SIL International. All Rights Reserved.
// <copyright from='2011' to='2011' company='SIL International'>
// Copyright (c) 2011, SIL International. All Rights Reserved.
// Distributable under the terms of either the Common Public License or the
// GNU Lesser General Public License, as specified in the LICENSING.txt file.
// </copyright>
using System;

namespace testproject
{
// Some modified comment
	/// <summary>
	/// Main class for testing
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// Returns a arbitrary number
		/// </summary>
		public static int Number()
		{
			// bugfix
			return 7;
		}

		/// <summary>
		/// Gets the name of the project
		/// </summary>
		public static string Name
		{
			get { return "TestProject"; }
		}

		/// <summary>
		/// Gets the description for the project
		/// </summary>
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

