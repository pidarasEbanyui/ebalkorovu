using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace ns0;

[GeneratedCode("MyTemplate", "11.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Never)]
internal class Form0 : WindowsFormsApplicationBase
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[STAThread]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
		}
		finally
		{
		}
		Class1.Form0_0.Run(args);
	}

	public Form0()
		: base(AuthenticationMode.Windows)
	{
		base.IsSingleInstance = true;
		base.EnableVisualStyles = false;
		base.SaveMySettingsOnExit = false;
		base.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
	}

	protected override void OnCreateMainForm()
	{
		base.MainForm = Class1.MyForms_0.loader;
	}
}
