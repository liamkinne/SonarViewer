/*
 * Created By: Simon Hogwood
 * Date: 25/10/2017
 * Time: 12:27 PM
 */

using System;
using System.Windows.Forms;

namespace sonarLidar
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
