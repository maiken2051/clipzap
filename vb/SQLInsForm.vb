Option Strict Off
Option Explicit On
Imports System.Text

Friend Class SQLInsForm
    Inherits System.Windows.Forms.Form
    '
    ' Convert tabbed columns to SQL Insert
    '

    Private Sub Done_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Done.Click
        '
        ' Done
        '

        Me.Close()

    End Sub
    Private Sub DoIt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles DoIt.Click
        '
        ' Do the change...
        '

        Dim src As String

        src = My.Computer.Clipboard.GetText()

        If src = "" Then
            Beep()
            Exit Sub
        End If

        Dim sa As New StringBuilder()
        Dim chunk As String

        Dim prefix As String

        prefix = "insert into " & TblName.Text & "(" & FNList.Text & ") values("

        Dim lnct As Short, col As String, wrk As String, isFirst As Boolean

        lnct = 0

        For Each chunk In Split(src, vbCrLf)

            sa.Append(prefix)

            isFirst = True

            For Each col In chunk.Split(vbTab)
                wrk = col.Trim()

                If isFirst Then
                    isFirst = False
                Else
                    sa.Append(", ")
                End If

                If String.IsNullOrEmpty(wrk) Then
                    sa.Append("null")
                ElseIf IsNumeric(wrk) Then
                    If wrk.Length = 5 Then
                        sa.Append("'").Append(wrk).Append("'")      ' Possible cost center, quote it *CRUFT*
                    Else
                        sa.Append(wrk)
                    End If
                Else
                    sa.Append("'").Append(wrk.Replace("'", "''")).Append("'")
                End If

            Next

            sa.AppendLine(");")

            lnct = lnct + 1

        Next chunk

        Status.Text = lnct & " rows processed"

        If lnct > 0 Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sa.ToString())
        End If

    End Sub

    Private Shared Function IsNumeric(ByVal src As String) As Boolean
        '
        ' Does a string only contain numeric characters?
        '

        Dim c As Char

        For Each c In src
            If Not Char.IsNumber(c) Then
                Return False
            End If
        Next

        Return True

    End Function


End Class