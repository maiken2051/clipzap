Option Strict Off
Option Explicit On
Imports System.Text

Friend Class SQLMergeForm
	Inherits System.Windows.Forms.Form
	'
	' SQL merge generation
	'
	
	Private Sub SMergeDone_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles SMergeDone.Click
		'
		' Done
		'
		
		Me.Hide()
		
	End Sub
	
	Private Sub DoSMerge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DoSMerge.Click
		'
		' Do the actual thing
		'
        Dim sa As New StringBuilder()
		
		Dim src As String
		
		src = My.Computer.Clipboard.GetText()
		
        Dim flist(), f As String
		Dim i As String
		Dim fct As Short
		Dim st, dt As String
		Dim lct As Short
		
		st = SrcTable.Text
		dt = DestTable.Text
		
        flist = Split(src, ",")
		
        sa.AppendLine("when matched then update set")
		
		fct = 0
		
		For	Each f In flist
            flist(fct) = Trim(Replace(Replace(f, vbCr, ""), vbLf, ""))
			fct = fct + 1
		Next f
		
		fct = 0
		
		lct = 0
		
		For	Each f In flist
            i = f
			
			If fct > 0 Then
				lct = lct + 1
                sa.AppendLine(",")
			End If
			
            sa.Append(vbTab & dt & "." & i & " = " & st & "." & i)
			
			fct = fct + 1
		Next f
		
		fct = 0
		
        sa.AppendLine(vbCrLf & "when not matched then insert")
        sa.Append("(")
		
		For	Each f In flist
            i = f
			
			If fct > 0 Then
                sa.Append(", ")
			End If
			
			If (fct Mod 5) = 0 Then
                sa.Append(vbCrLf & vbTab)
				lct = lct + 1
			End If
			
            sa.Append(dt & "." & i)
			
			fct = fct + 1
		Next f
		
        sa.AppendLine(vbCrLf & ")")
        sa.AppendLine("values")
        sa.Append("(")
		
		fct = 0
		
		For	Each f In flist
            i = f
			
			If fct > 0 Then
                sa.Append(", ")
			End If
			
			If (fct Mod 5) = 0 Then
                sa.Append(vbCrLf & vbTab)
				lct = lct + 1
			End If
			
            sa.Append(st & "." & i)
			
			fct = fct + 1
		Next f
		
        sa.AppendLine(vbCrLf & ");" & vbCrLf)
		
		My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(sa.ToString())
		
		ClipZapMain.Status.Text = "SQL Merge Generated: " & lct & " lines"
		
		SMergeDone_Click(SMergeDone, New System.EventArgs())
		
	End Sub
End Class