Option Explicit On

Imports System.IO
Imports Manoli.Utils.CSharpFormat

Public Class CodeFormatForm

    Private Sub OpenFileBtn_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileBtn.Click
        '
        ' Set the file name
        '

        If OpenCodeFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CodeFormatFN.Text = OpenCodeFile.FileName
        End If

    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        '
        ' Close the box
        '

        Close()

    End Sub


    Private Sub FormatIt_Click(sender As System.Object, e As System.EventArgs) Handles FormatIt.Click
        '
        ' Try to format the file
        '

        Dim fn As String = CodeFormatFN.Text

        If fn Is Nothing Then
            fn = String.Empty
        Else
            fn = fn.Trim()
        End If

        If fn.Length < 2 Then
            FormatSta.Text = "No filename set"
        Else
            Dim fi As FileInfo = New FileInfo(fn)

            If Not fi.Exists Then
                FormatSta.Text = "File does not exist"
            Else
                Dim fmtr As SourceFormat

                Select Case fi.Extension.Substring(1).ToLower()
                    Case "aspx", "htm", "html"
                        fmtr = New HtmlFormat()

                    Case "cs"
                        fmtr = New CSharpFormat()

                    Case "js"
                        fmtr = New JavaScriptFormat()

                    Case "sql"
                        fmtr = New TsqlFormat()

                    Case "vb"
                        fmtr = New VisualBasicFormat()

                    Case Else
                        fmtr = Nothing

                End Select

                If fmtr Is Nothing Then
                    FormatSta.Text = "No matching formatter found"
                Else
                    Dim src As String

                    Using rs As StreamReader = fi.OpenText()
                        src = rs.ReadToEnd
                    End Using

                    My.Computer.Clipboard.Clear()
                    My.Computer.Clipboard.SetText(fmtr.FormatCode(src))

                    FormatSta.Text = src.Length & " chars processed : " & fmtr.GetType().Name
                End If
            End If
        End If

    End Sub
End Class