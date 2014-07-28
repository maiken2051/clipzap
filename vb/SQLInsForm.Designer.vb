<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class SQLInsForm
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
    Public WithEvents TblName As System.Windows.Forms.TextBox
	Public WithEvents Done As System.Windows.Forms.Button
	Public WithEvents DoIt As System.Windows.Forms.Button
	Public WithEvents FNList As System.Windows.Forms.TextBox
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Status As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SQLInsForm))
        Me.TblName = New System.Windows.Forms.TextBox
        Me.Done = New System.Windows.Forms.Button
        Me.DoIt = New System.Windows.Forms.Button
        Me.FNList = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Status = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TblName
        '
        Me.TblName.AcceptsReturn = True
        Me.TblName.BackColor = System.Drawing.SystemColors.Window
        Me.TblName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TblName.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TblName.Location = New System.Drawing.Point(88, 8)
        Me.TblName.MaxLength = 0
        Me.TblName.Name = "TblName"
        Me.TblName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TblName.Size = New System.Drawing.Size(369, 20)
        Me.TblName.TabIndex = 0
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.SystemColors.Control
        Me.Done.Cursor = System.Windows.Forms.Cursors.Default
        Me.Done.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Done.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Done.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Done.Location = New System.Drawing.Point(88, 64)
        Me.Done.Name = "Done"
        Me.Done.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Done.Size = New System.Drawing.Size(65, 25)
        Me.Done.TabIndex = 3
        Me.Done.Text = "Cl&ose"
        Me.Done.UseVisualStyleBackColor = False
        '
        'DoIt
        '
        Me.DoIt.BackColor = System.Drawing.SystemColors.Control
        Me.DoIt.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoIt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoIt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DoIt.Location = New System.Drawing.Point(8, 64)
        Me.DoIt.Name = "DoIt"
        Me.DoIt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DoIt.Size = New System.Drawing.Size(65, 25)
        Me.DoIt.TabIndex = 2
        Me.DoIt.Text = "&Zap"
        Me.DoIt.UseVisualStyleBackColor = False
        '
        'FNList
        '
        Me.FNList.AcceptsReturn = True
        Me.FNList.BackColor = System.Drawing.SystemColors.Window
        Me.FNList.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FNList.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FNList.Location = New System.Drawing.Point(88, 32)
        Me.FNList.MaxLength = 0
        Me.FNList.Name = "FNList"
        Me.FNList.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FNList.Size = New System.Drawing.Size(369, 20)
        Me.FNList.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Table Name:"
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.Control
        Me.Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Status.Cursor = System.Windows.Forms.Cursors.Default
        Me.Status.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Status.Location = New System.Drawing.Point(8, 104)
        Me.Status.Name = "Status"
        Me.Status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Status.Size = New System.Drawing.Size(449, 20)
        Me.Status.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Field Names:"
        '
        'SQLInsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.Done
        Me.ClientSize = New System.Drawing.Size(468, 130)
        Me.Controls.Add(Me.TblName)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.DoIt)
        Me.Controls.Add(Me.FNList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 22)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SQLInsForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.Text = "SQL Insert"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
End Class