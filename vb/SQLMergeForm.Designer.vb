<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class SQLMergeForm
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents SMergeDone As System.Windows.Forms.Button
	Public WithEvents DoSMerge As System.Windows.Forms.Button
	Public WithEvents DestTable As System.Windows.Forms.TextBox
	Public WithEvents SrcTable As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SQLMergeForm))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.SMergeDone = New System.Windows.Forms.Button
		Me.DoSMerge = New System.Windows.Forms.Button
		Me.DestTable = New System.Windows.Forms.TextBox
		Me.SrcTable = New System.Windows.Forms.TextBox
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "SQL Merge Generation"
		Me.ClientSize = New System.Drawing.Size(258, 74)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "SQLMergeForm"
		Me.SMergeDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.SMergeDone.Text = "Ca&ncel"
		Me.SMergeDone.Size = New System.Drawing.Size(65, 25)
		Me.SMergeDone.Location = New System.Drawing.Point(184, 40)
		Me.SMergeDone.TabIndex = 5
		Me.SMergeDone.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SMergeDone.BackColor = System.Drawing.SystemColors.Control
		Me.SMergeDone.CausesValidation = True
		Me.SMergeDone.Enabled = True
		Me.SMergeDone.ForeColor = System.Drawing.SystemColors.ControlText
		Me.SMergeDone.Cursor = System.Windows.Forms.Cursors.Default
		Me.SMergeDone.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SMergeDone.TabStop = True
		Me.SMergeDone.Name = "SMergeDone"
		Me.DoSMerge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.DoSMerge.Text = "&OK"
		Me.DoSMerge.Size = New System.Drawing.Size(65, 25)
		Me.DoSMerge.Location = New System.Drawing.Point(8, 40)
		Me.DoSMerge.TabIndex = 4
		Me.DoSMerge.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DoSMerge.BackColor = System.Drawing.SystemColors.Control
		Me.DoSMerge.CausesValidation = True
		Me.DoSMerge.Enabled = True
		Me.DoSMerge.ForeColor = System.Drawing.SystemColors.ControlText
		Me.DoSMerge.Cursor = System.Windows.Forms.Cursors.Default
		Me.DoSMerge.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DoSMerge.TabStop = True
		Me.DoSMerge.Name = "DoSMerge"
		Me.DestTable.AutoSize = False
		Me.DestTable.Size = New System.Drawing.Size(49, 20)
		Me.DestTable.Location = New System.Drawing.Point(200, 8)
		Me.DestTable.TabIndex = 3
		Me.DestTable.Text = "l"
		Me.DestTable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DestTable.AcceptsReturn = True
		Me.DestTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.DestTable.BackColor = System.Drawing.SystemColors.Window
		Me.DestTable.CausesValidation = True
		Me.DestTable.Enabled = True
		Me.DestTable.ForeColor = System.Drawing.SystemColors.WindowText
		Me.DestTable.HideSelection = True
		Me.DestTable.ReadOnly = False
		Me.DestTable.Maxlength = 0
		Me.DestTable.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.DestTable.MultiLine = False
		Me.DestTable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.DestTable.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.DestTable.TabStop = True
		Me.DestTable.Visible = True
		Me.DestTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.DestTable.Name = "DestTable"
		Me.SrcTable.AutoSize = False
		Me.SrcTable.Size = New System.Drawing.Size(49, 20)
		Me.SrcTable.Location = New System.Drawing.Point(64, 8)
		Me.SrcTable.TabIndex = 1
		Me.SrcTable.Text = "r"
		Me.SrcTable.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SrcTable.AcceptsReturn = True
		Me.SrcTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.SrcTable.BackColor = System.Drawing.SystemColors.Window
		Me.SrcTable.CausesValidation = True
		Me.SrcTable.Enabled = True
		Me.SrcTable.ForeColor = System.Drawing.SystemColors.WindowText
		Me.SrcTable.HideSelection = True
		Me.SrcTable.ReadOnly = False
		Me.SrcTable.Maxlength = 0
		Me.SrcTable.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.SrcTable.MultiLine = False
		Me.SrcTable.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.SrcTable.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.SrcTable.TabStop = True
		Me.SrcTable.Visible = True
		Me.SrcTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.SrcTable.Name = "SrcTable"
		Me.Label2.Text = "Destination:"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(136, 9)
		Me.Label2.TabIndex = 2
		Me.Label2.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Source:"
		Me.Label1.Size = New System.Drawing.Size(49, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 9)
		Me.Label1.TabIndex = 0
		Me.Label1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(SMergeDone)
		Me.Controls.Add(DoSMerge)
		Me.Controls.Add(DestTable)
		Me.Controls.Add(SrcTable)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class