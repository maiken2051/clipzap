<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class ClipZapMain
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
    Public WithEvents UnZap As System.Windows.Forms.Button
	Public WithEvents ClearAll As System.Windows.Forms.Button
	Public WithEvents DoubleSingle As System.Windows.Forms.CheckBox
	Public WithEvents QTBackslash As System.Windows.Forms.CheckBox
	Public WithEvents SuffixString As System.Windows.Forms.TextBox
	Public WithEvents AddCRLF As System.Windows.Forms.CheckBox
	Public WithEvents Done As System.Windows.Forms.Button
	Public WithEvents PrefixString As System.Windows.Forms.TextBox
	Public WithEvents WriteFmt As System.Windows.Forms.Button
	Public WithEvents Status As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents FileInsert As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents FileMerge As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents FileBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents FileExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents FileFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CommonJava As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CommonJavaScript As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CommonVB As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CommonBar0 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents CommonJSPImport As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents CommonCommon As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClipZapMain))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UnZap = New System.Windows.Forms.Button()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.DoubleSingle = New System.Windows.Forms.CheckBox()
        Me.QTBackslash = New System.Windows.Forms.CheckBox()
        Me.SuffixString = New System.Windows.Forms.TextBox()
        Me.AddCRLF = New System.Windows.Forms.CheckBox()
        Me.Done = New System.Windows.Forms.Button()
        Me.PrefixString = New System.Windows.Forms.TextBox()
        Me.WriteFmt = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.FileFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileInsert = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileMerge = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileBar0 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonCommon = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonJava = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonJavaScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonVB = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommonBar0 = New System.Windows.Forms.ToolStripSeparator()
        Me.CommonJSPImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuickToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FiddlerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToNetTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommaSepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDLFieldsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DDLFieldListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLParaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarkdownTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLColAddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QPrintableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlashesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLTableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLUpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnHTMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToURL = New System.Windows.Forms.ToolStripMenuItem()
        Me.HtmlFormatMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeFromFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CodeASPX = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeCSharp = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeFormatJScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeSQL = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeVB = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodeFormatJavaScript = New System.Windows.Forms.ToolStripMenuItem()
        Me.MySQLChecksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UnZap
        '
        Me.UnZap.BackColor = System.Drawing.SystemColors.Control
        Me.UnZap.Cursor = System.Windows.Forms.Cursors.Default
        Me.UnZap.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnZap.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UnZap.Location = New System.Drawing.Point(175, 163)
        Me.UnZap.Name = "UnZap"
        Me.UnZap.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.UnZap.Size = New System.Drawing.Size(65, 25)
        Me.UnZap.TabIndex = 10
        Me.UnZap.Text = "&UnZap"
        Me.UnZap.UseVisualStyleBackColor = False
        '
        'ClearAll
        '
        Me.ClearAll.BackColor = System.Drawing.SystemColors.Control
        Me.ClearAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClearAll.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ClearAll.Location = New System.Drawing.Point(15, 195)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ClearAll.Size = New System.Drawing.Size(65, 25)
        Me.ClearAll.TabIndex = 6
        Me.ClearAll.Text = "&Clear"
        Me.ClearAll.UseVisualStyleBackColor = False
        '
        'DoubleSingle
        '
        Me.DoubleSingle.BackColor = System.Drawing.SystemColors.Control
        Me.DoubleSingle.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleSingle.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoubleSingle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DoubleSingle.Location = New System.Drawing.Point(15, 139)
        Me.DoubleSingle.Name = "DoubleSingle"
        Me.DoubleSingle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DoubleSingle.Size = New System.Drawing.Size(225, 17)
        Me.DoubleSingle.TabIndex = 4
        Me.DoubleSingle.Text = "Double single quotes"
        Me.DoubleSingle.UseVisualStyleBackColor = False
        '
        'QTBackslash
        '
        Me.QTBackslash.BackColor = System.Drawing.SystemColors.Control
        Me.QTBackslash.Cursor = System.Windows.Forms.Cursors.Default
        Me.QTBackslash.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTBackslash.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QTBackslash.Location = New System.Drawing.Point(15, 115)
        Me.QTBackslash.Name = "QTBackslash"
        Me.QTBackslash.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.QTBackslash.Size = New System.Drawing.Size(225, 17)
        Me.QTBackslash.TabIndex = 3
        Me.QTBackslash.Text = "Backslash double quotes"
        Me.QTBackslash.UseVisualStyleBackColor = False
        '
        'SuffixString
        '
        Me.SuffixString.AcceptsReturn = True
        Me.SuffixString.BackColor = System.Drawing.SystemColors.Window
        Me.SuffixString.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SuffixString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuffixString.ForeColor = System.Drawing.SystemColors.WindowText
        Me.SuffixString.Location = New System.Drawing.Point(49, 59)
        Me.SuffixString.MaxLength = 0
        Me.SuffixString.Name = "SuffixString"
        Me.SuffixString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SuffixString.Size = New System.Drawing.Size(193, 29)
        Me.SuffixString.TabIndex = 1
        '
        'AddCRLF
        '
        Me.AddCRLF.BackColor = System.Drawing.SystemColors.Control
        Me.AddCRLF.Cursor = System.Windows.Forms.Cursors.Default
        Me.AddCRLF.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCRLF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddCRLF.Location = New System.Drawing.Point(15, 91)
        Me.AddCRLF.Name = "AddCRLF"
        Me.AddCRLF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.AddCRLF.Size = New System.Drawing.Size(225, 17)
        Me.AddCRLF.TabIndex = 2
        Me.AddCRLF.Text = "Append + VbCrLf"
        Me.AddCRLF.UseVisualStyleBackColor = False
        '
        'Done
        '
        Me.Done.BackColor = System.Drawing.SystemColors.Control
        Me.Done.Cursor = System.Windows.Forms.Cursors.Default
        Me.Done.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Done.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Done.Location = New System.Drawing.Point(175, 195)
        Me.Done.Name = "Done"
        Me.Done.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Done.Size = New System.Drawing.Size(65, 25)
        Me.Done.TabIndex = 7
        Me.Done.Text = "Cl&ose"
        Me.Done.UseVisualStyleBackColor = False
        '
        'PrefixString
        '
        Me.PrefixString.AcceptsReturn = True
        Me.PrefixString.BackColor = System.Drawing.SystemColors.Window
        Me.PrefixString.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PrefixString.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrefixString.ForeColor = System.Drawing.SystemColors.WindowText
        Me.PrefixString.Location = New System.Drawing.Point(49, 33)
        Me.PrefixString.MaxLength = 0
        Me.PrefixString.Name = "PrefixString"
        Me.PrefixString.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PrefixString.Size = New System.Drawing.Size(193, 29)
        Me.PrefixString.TabIndex = 0
        '
        'WriteFmt
        '
        Me.WriteFmt.BackColor = System.Drawing.SystemColors.Control
        Me.WriteFmt.Cursor = System.Windows.Forms.Cursors.Default
        Me.WriteFmt.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteFmt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.WriteFmt.Location = New System.Drawing.Point(15, 163)
        Me.WriteFmt.Name = "WriteFmt"
        Me.WriteFmt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.WriteFmt.Size = New System.Drawing.Size(65, 25)
        Me.WriteFmt.TabIndex = 5
        Me.WriteFmt.Text = "&Zap"
        Me.WriteFmt.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.BackColor = System.Drawing.SystemColors.Control
        Me.Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Status.Cursor = System.Windows.Forms.Cursors.Default
        Me.Status.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Status.Location = New System.Drawing.Point(15, 227)
        Me.Status.Name = "Status"
        Me.Status.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Status.Size = New System.Drawing.Size(225, 20)
        Me.Status.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(63, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Suffix:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(64, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Prefix:"
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileFile, Me.CommonCommon, Me.QuickToolStripMenuItem, Me.HtmlFormatMenu})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(252, 38)
        Me.MainMenu1.TabIndex = 13
        '
        'FileFile
        '
        Me.FileFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileInsert, Me.FileMerge, Me.FileBar0, Me.FileExit})
        Me.FileFile.Name = "FileFile"
        Me.FileFile.Size = New System.Drawing.Size(56, 34)
        Me.FileFile.Text = "&File"
        '
        'FileInsert
        '
        Me.FileInsert.Name = "FileInsert"
        Me.FileInsert.Size = New System.Drawing.Size(189, 34)
        Me.FileInsert.Text = "SQL Insert"
        '
        'FileMerge
        '
        Me.FileMerge.Name = "FileMerge"
        Me.FileMerge.Size = New System.Drawing.Size(189, 34)
        Me.FileMerge.Text = "SQL Merge"
        '
        'FileBar0
        '
        Me.FileBar0.Name = "FileBar0"
        Me.FileBar0.Size = New System.Drawing.Size(186, 6)
        '
        'FileExit
        '
        Me.FileExit.Name = "FileExit"
        Me.FileExit.Size = New System.Drawing.Size(189, 34)
        Me.FileExit.Text = "E&xit"
        '
        'CommonCommon
        '
        Me.CommonCommon.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.CommonJava, Me.CommonJavaScript, Me.CommonVB, Me.CommonBar0, Me.CommonJSPImport})
        Me.CommonCommon.Name = "CommonCommon"
        Me.CommonCommon.Size = New System.Drawing.Size(110, 34)
        Me.CommonCommon.Text = "&Common"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(185, 34)
        Me.ToolStripMenuItem1.Text = "&In"
        '
        'CommonJava
        '
        Me.CommonJava.Name = "CommonJava"
        Me.CommonJava.Size = New System.Drawing.Size(185, 34)
        Me.CommonJava.Text = "&Java"
        '
        'CommonJavaScript
        '
        Me.CommonJavaScript.Name = "CommonJavaScript"
        Me.CommonJavaScript.Size = New System.Drawing.Size(185, 34)
        Me.CommonJavaScript.Text = "Java&Script"
        '
        'CommonVB
        '
        Me.CommonVB.Name = "CommonVB"
        Me.CommonVB.Size = New System.Drawing.Size(185, 34)
        Me.CommonVB.Text = "&VB"
        '
        'CommonBar0
        '
        Me.CommonBar0.Name = "CommonBar0"
        Me.CommonBar0.Size = New System.Drawing.Size(182, 6)
        '
        'CommonJSPImport
        '
        Me.CommonJSPImport.Name = "CommonJSPImport"
        Me.CommonJSPImport.Size = New System.Drawing.Size(185, 34)
        Me.CommonJSPImport.Text = "JSP &Import"
        '
        'QuickToolStripMenuItem
        '
        Me.QuickToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NetToolStripMenuItem, Me.CommaSepToolStripMenuItem, Me.DDLFieldsToolStripMenuItem, Me.DDLFieldListToolStripMenuItem, Me.HTMLToolStripMenuItem, Me.HTMLParaToolStripMenuItem, Me.MarkdownTableToolStripMenuItem, Me.MySQLChecksToolStripMenuItem, Me.MySQLColAddToolStripMenuItem, Me.QPrintableToolStripMenuItem, Me.QuotesToolStripMenuItem, Me.SlashesToolStripMenuItem, Me.SQLTableToolStripMenuItem, Me.SQLUpdateToolStripMenuItem, Me.TicksToolStripMenuItem, Me.UnHTMLToolStripMenuItem, Me.UnURL, Me.ToURL})
        Me.QuickToolStripMenuItem.Name = "QuickToolStripMenuItem"
        Me.QuickToolStripMenuItem.Size = New System.Drawing.Size(78, 34)
        Me.QuickToolStripMenuItem.Text = "&Quick"
        '
        'NetToolStripMenuItem
        '
        Me.NetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.DataTableToolStripMenuItem, Me.FiddlerToolStripMenuItem, Me.ToNetTableToolStripMenuItem})
        Me.NetToolStripMenuItem.Name = "NetToolStripMenuItem"
        Me.NetToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.NetToolStripMenuItem.Text = ".Net"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 34)
        Me.ToolStripMenuItem2.Text = "&BCStatic"
        '
        'DataTableToolStripMenuItem
        '
        Me.DataTableToolStripMenuItem.Name = "DataTableToolStripMenuItem"
        Me.DataTableToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.DataTableToolStripMenuItem.Text = "&DataTable"
        '
        'FiddlerToolStripMenuItem
        '
        Me.FiddlerToolStripMenuItem.Name = "FiddlerToolStripMenuItem"
        Me.FiddlerToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.FiddlerToolStripMenuItem.Text = "&Fiddler"
        '
        'ToNetTableToolStripMenuItem
        '
        Me.ToNetTableToolStripMenuItem.Name = "ToNetTableToolStripMenuItem"
        Me.ToNetTableToolStripMenuItem.Size = New System.Drawing.Size(206, 34)
        Me.ToNetTableToolStripMenuItem.Text = "To .&Net Table"
        '
        'CommaSepToolStripMenuItem
        '
        Me.CommaSepToolStripMenuItem.Name = "CommaSepToolStripMenuItem"
        Me.CommaSepToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.CommaSepToolStripMenuItem.Text = "&CommaSep"
        '
        'DDLFieldsToolStripMenuItem
        '
        Me.DDLFieldsToolStripMenuItem.Name = "DDLFieldsToolStripMenuItem"
        Me.DDLFieldsToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.DDLFieldsToolStripMenuItem.Text = "DDL Fields"
        '
        'DDLFieldListToolStripMenuItem
        '
        Me.DDLFieldListToolStripMenuItem.Name = "DDLFieldListToolStripMenuItem"
        Me.DDLFieldListToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.DDLFieldListToolStripMenuItem.Text = "DDL Field List"
        '
        'HTMLToolStripMenuItem
        '
        Me.HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        Me.HTMLToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.HTMLToolStripMenuItem.Text = "&HTML"
        '
        'HTMLParaToolStripMenuItem
        '
        Me.HTMLParaToolStripMenuItem.Name = "HTMLParaToolStripMenuItem"
        Me.HTMLParaToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.HTMLParaToolStripMenuItem.Text = "HTML &Para"
        '
        'MarkdownTableToolStripMenuItem
        '
        Me.MarkdownTableToolStripMenuItem.Name = "MarkdownTableToolStripMenuItem"
        Me.MarkdownTableToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.MarkdownTableToolStripMenuItem.Text = "Markdown Table"
        '
        'MySQLColAddToolStripMenuItem
        '
        Me.MySQLColAddToolStripMenuItem.Name = "MySQLColAddToolStripMenuItem"
        Me.MySQLColAddToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.MySQLColAddToolStripMenuItem.Text = "MySQL Col Add"
        '
        'QPrintableToolStripMenuItem
        '
        Me.QPrintableToolStripMenuItem.Name = "QPrintableToolStripMenuItem"
        Me.QPrintableToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.QPrintableToolStripMenuItem.Text = "QPrintable"
        '
        'QuotesToolStripMenuItem
        '
        Me.QuotesToolStripMenuItem.Name = "QuotesToolStripMenuItem"
        Me.QuotesToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.QuotesToolStripMenuItem.Text = "&Quotes"
        '
        'SlashesToolStripMenuItem
        '
        Me.SlashesToolStripMenuItem.Name = "SlashesToolStripMenuItem"
        Me.SlashesToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.SlashesToolStripMenuItem.Text = "Slashes"
        '
        'SQLTableToolStripMenuItem
        '
        Me.SQLTableToolStripMenuItem.Name = "SQLTableToolStripMenuItem"
        Me.SQLTableToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.SQLTableToolStripMenuItem.Text = "&SQL Table"
        '
        'SQLUpdateToolStripMenuItem
        '
        Me.SQLUpdateToolStripMenuItem.Name = "SQLUpdateToolStripMenuItem"
        Me.SQLUpdateToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.SQLUpdateToolStripMenuItem.Text = "SQL Update"
        '
        'TicksToolStripMenuItem
        '
        Me.TicksToolStripMenuItem.Name = "TicksToolStripMenuItem"
        Me.TicksToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.TicksToolStripMenuItem.Text = "&Ticks"
        '
        'UnHTMLToolStripMenuItem
        '
        Me.UnHTMLToolStripMenuItem.Name = "UnHTMLToolStripMenuItem"
        Me.UnHTMLToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.UnHTMLToolStripMenuItem.Text = "&UnHTML"
        '
        'UnURL
        '
        Me.UnURL.Name = "UnURL"
        Me.UnURL.Size = New System.Drawing.Size(238, 34)
        Me.UnURL.Text = "UnURL"
        '
        'ToURL
        '
        Me.ToURL.Name = "ToURL"
        Me.ToURL.Size = New System.Drawing.Size(238, 34)
        Me.ToURL.Text = "URL"
        '
        'HtmlFormatMenu
        '
        Me.HtmlFormatMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodeFromFile, Me.ToolStripMenuItem3, Me.CodeASPX, Me.CodeCSharp, Me.CodeFormatJScript, Me.CodeSQL, Me.CodeVB, Me.CodeFormatJavaScript})
        Me.HtmlFormatMenu.Name = "HtmlFormatMenu"
        Me.HtmlFormatMenu.Size = New System.Drawing.Size(135, 34)
        Me.HtmlFormatMenu.Text = "Co&deformat"
        '
        'CodeFromFile
        '
        Me.CodeFromFile.Name = "CodeFromFile"
        Me.CodeFromFile.Size = New System.Drawing.Size(197, 34)
        Me.CodeFromFile.Text = "From File..."
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(194, 6)
        '
        'CodeASPX
        '
        Me.CodeASPX.Name = "CodeASPX"
        Me.CodeASPX.Size = New System.Drawing.Size(197, 34)
        Me.CodeASPX.Text = "ASPX/HTML"
        '
        'CodeCSharp
        '
        Me.CodeCSharp.Name = "CodeCSharp"
        Me.CodeCSharp.Size = New System.Drawing.Size(197, 34)
        Me.CodeCSharp.Text = "C#"
        '
        'CodeFormatJScript
        '
        Me.CodeFormatJScript.Name = "CodeFormatJScript"
        Me.CodeFormatJScript.Size = New System.Drawing.Size(197, 34)
        Me.CodeFormatJScript.Text = "JavaScript"
        '
        'CodeSQL
        '
        Me.CodeSQL.Name = "CodeSQL"
        Me.CodeSQL.Size = New System.Drawing.Size(197, 34)
        Me.CodeSQL.Text = "SQL"
        '
        'CodeVB
        '
        Me.CodeVB.Name = "CodeVB"
        Me.CodeVB.Size = New System.Drawing.Size(197, 34)
        Me.CodeVB.Text = "VB"
        '
        'CodeFormatJavaScript
        '
        Me.CodeFormatJavaScript.Name = "CodeFormatJavaScript"
        Me.CodeFormatJavaScript.Size = New System.Drawing.Size(197, 34)
        Me.CodeFormatJavaScript.Text = "JavaScript"
        '
        'MySQLChecksToolStripMenuItem
        '
        Me.MySQLChecksToolStripMenuItem.Name = "MySQLChecksToolStripMenuItem"
        Me.MySQLChecksToolStripMenuItem.Size = New System.Drawing.Size(238, 34)
        Me.MySQLChecksToolStripMenuItem.Text = "MySQL Checks"
        '
        'ClipZapMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(252, 256)
        Me.Controls.Add(Me.UnZap)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.DoubleSingle)
        Me.Controls.Add(Me.QTBackslash)
        Me.Controls.Add(Me.SuffixString)
        Me.Controls.Add(Me.AddCRLF)
        Me.Controls.Add(Me.Done)
        Me.Controls.Add(Me.PrefixString)
        Me.Controls.Add(Me.WriteFmt)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 48)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ClipZapMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Clipboard zapper"
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuickToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLParaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnHTMLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SlashesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommaSepToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLUpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DDLFieldsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DDLFieldListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HtmlFormatMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeFromFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeCSharp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CodeASPX As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeSQL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeVB As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeFormatJScript As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CodeFormatJavaScript As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToURL As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarkdownTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QPrintableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiddlerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToNetTableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MySQLColAddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TicksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MySQLChecksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
#End Region 
End Class