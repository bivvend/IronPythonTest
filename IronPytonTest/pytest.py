import clr
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')

import System.Drawing
import System.Windows.Forms

from System.Drawing import *
from System.Windows.Forms import *

class pytest(Form):
	def __init__(self):
		self.InitializeComponent()
	
	def InitializeComponent(self):
		self._button_send_back = System.Windows.Forms.Button()
		self.SuspendLayout()
		# 
		# button_send_back
		# 
		self._button_send_back.Location = System.Drawing.Point(77, 28)
		self._button_send_back.Name = "button_send_back"
		self._button_send_back.Size = System.Drawing.Size(119, 40)
		self._button_send_back.TabIndex = 0
		self._button_send_back.Text = txt
		self._button_send_back.UseVisualStyleBackColor = True
		self._button_send_back.Click += self.Button_send_backClick
		# 
		# pytest
		# 
		self.ClientSize = System.Drawing.Size(284, 261)
		self.Controls.Add(self._button_send_back)
		self.Name = "pytest"
		self.Text = "pytest"
		self.ResumeLayout(False)
		
		
	def Button_send_backClick(self, sender, e):
		global txt
		txt="hello from IronPython"
		self.Close()
		
		
form = pytest()
form.ShowDialog()
