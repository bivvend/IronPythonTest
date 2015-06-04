/*
 * Created by SharpDevelop.
 * User: Simon Henley
 * Date: 04/06/2015
 * Time: 21:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using IronPython.Hosting;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;

namespace IronPytonTest
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private ScriptEngine m_engine = Python.CreateEngine();
		private ScriptScope m_scope = null;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			m_scope = m_engine.CreateScope();
			m_scope.SetVariable("txt", "Hello from C#");

		}
		
		void Button_run_scriptClick(object sender, EventArgs e)
		{
			try
            {
				ScriptSource source = m_engine.CreateScriptSourceFromFile(@"D:\Github\IronPytonTest\IronPytonTest\pytest.py");
         		CompiledCode compiled = source.Compile();
    		    // Executes in the scope of Python
    			compiled.Execute(m_scope); 
    			label_response.Text=m_scope.GetVariable<string>("txt");
    			
            }
            catch (Exception ex)
            {
                label_response.Text = ex.ToString();
            }
		}
	}
}
