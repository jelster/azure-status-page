﻿using System;
using System.IO;

namespace azure_status_page.core
{
	public class DirectoryEx
	{		
		public static void Copy(string sourceDir, string targetDir, bool overwrite = false)
		{
			Directory.CreateDirectory(targetDir);

			foreach (var file in Directory.GetFiles(sourceDir))
				File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), overwrite);

			foreach (var directory in Directory.GetDirectories(sourceDir))
				DirectoryEx.Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)), overwrite);
		}
	}
}
