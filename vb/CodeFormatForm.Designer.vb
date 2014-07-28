<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CodeFormatForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Me.CodeFormatFN = New System.Windows.Forms.TextBox()
        Me.OpenCodeFile = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileBtn = New System.Windows.Forms.Button()
        Me.FormatIt = New System.Windows.Forms.Button()
        Me.FormatSta = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(13, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(27, 13)
        Label1.TabIndex = 0
        Label1.Text = "File"
        '
        'CodeFormatFN
        '
        Me.CodeFormatFN.Location = New System.Drawing.Point(16, 29)
        Me.CodeFormatFN.Name = "CodeFormatFN"
        Me.CodeFormatFN.Size = New System.Drawing.Size(412, 20)
        Me.CodeFormatFN.TabIndex = 1
        '
        'OpenCodeFile
        '
        Me.OpenCodeFile.Filter = "All files|*.*|ASPX files|*.aspx;*.ashx|C# files|*.cs|HTML files|*.htm;*.html|Java" & _
    "Script Files|*.js|Visual Basic files|*.vb"
        '
        'OpenFileBtn
        '
        Me.OpenFileBtn.Location = New System.Drawing.Point(434, 28)
        Me.OpenFileBtn.Name = "OpenFileBtn"
        Me.OpenFileBtn.Size = New System.Drawing.Size(75, 23)
        Me.OpenFileBtn.TabIndex = 2
        Me.OpenFileBtn.Text = "&Browse"
        Me.OpenFileBtn.UseVisualStyleBackColor = True
        '
        'FormatIt
        '
        Me.FormatIt.Location = New System.Drawing.Point(16, 55)
        Me.FormatIt.Name = "FormatIt"
        Me.FormatIt.Size = New System.Drawing.Size(75, 23)
        Me.FormatIt.TabIndex = 3
        Me.FormatIt.Text = "&Format"
        Me.FormatIt.UseVisualStyleBackColor = True
        '
        'FormatSta
        '
        Me.FormatSta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FormatSta.Location = New System.Drawing.Point(13, 91)
        Me.FormatSta.Name = "FormatSta"
        Me.FormatSta.Size = New System.Drawing.Size(496, 23)
        Me.FormatSta.TabIndex = 4
        Me.FormatSta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(433, 58)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Cl&ose"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'CodeFormatForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 129)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.FormatSta)
        Me.Controls.Add(Me.FormatIt)
        Me.Controls.Add(Me.OpenFileBtn)
        Me.Controls.Add(Me.CodeFormatFN)
        Me.Controls.Add(Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CodeFormatForm"
        Me.Text = "Format Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CodeFormatFN As System.Windows.Forms.TextBox
    Friend WithEvents OpenCodeFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileBtn As System.Windows.Forms.Button
    Friend WithEvents FormatIt As System.Windows.Forms.Button
    Friend WithEvents FormatSta As System.Windows.Forms.Label
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
