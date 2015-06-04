/*
 * Created by SharpDevelop.
 * User: Simon Henley
 * Date: 04/06/2015
 * Time: 21:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace IronPytonTest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button_run_script = new System.Windows.Forms.Button();
			this.label_response = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_run_script
			// 
			this.button_run_script.Location = new System.Drawing.Point(98, 34);
			this.button_run_script.Name = "button_run_script";
			this.button_run_script.Size = new System.Drawing.Size(96, 37);
			this.button_run_script.TabIndex = 0;
			this.button_run_script.Text = "Run script";
			this.button_run_script.UseVisualStyleBackColor = true;
			this.button_run_script.Click += new System.EventHandler(this.Button_run_scriptClick);
			// 
			// label_response
			// 
			this.label_response.Location = new System.Drawing.Point(12, 124);
			this.label_response.Name = "label_response";
			this.label_response.Size = new System.Drawing.Size(979, 89);
			this.label_response.TabIndex = 1;
			this.label_response.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 276);
			this.Controls.Add(this.label_response);
			this.Controls.Add(this.button_run_script);
			this.Name = "MainForm";
			this.Text = "IronPytonTest";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_response;
		private System.Windows.Forms.Button button_run_script;
	}
}
