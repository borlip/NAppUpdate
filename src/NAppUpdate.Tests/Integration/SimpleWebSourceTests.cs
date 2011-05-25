﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NAppUpdate.Framework.Sources;

namespace NAppUpdate.Tests.Integration
{
	[TestClass]
	public class SimpleWebSourceTests
	{
		public void can_download_non_utf_feed()
		{
			const string expected = "NHibernate.Profiler-Build-";

			var ws = new SimpleWebSource("http://builds.hibernatingrhinos.com/latest/nhprof");
			var str = ws.GetUpdatesFeed();

			Assert.AreEqual(expected, str.Substring(0, expected.Length));
		}
	}
}