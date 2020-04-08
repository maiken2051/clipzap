Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports System.Text
Imports System.Text.RegularExpressions
Imports Manoli.Utils.CSharpFormat
Imports System.Web
Imports System.IO

Friend Class ClipZapMain
    Inherits System.Windows.Forms.Form
    '
    ' Clipboard reformatter
    '

    Private Const AppName As String = "ClipZap"
    Private Const SecName As String = "Settings"

    '
    ' ASP table formatting
    '

    Private Shared ASPTAB_REPL() As String = { _
        "table", "asp:Table", _
        "tr", "asp:TableRow", _
        "td", "asp:TableCell", _
        "th", "asp:TableHeaderCell" _
        }

    Private Shared ASPTAB_ATTR() As String = { _
        "class", "CssClass", _
        "colspan", "ColumnSpan", _
        "rowspan", "RowSpan", _
        "id", "ID" _
        }

    '
    ' Delegates
    '

    Private Delegate Function CBFormat(ByVal src As String) As String

    '
    '
    '

    Private Sub ClearAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ClearAll.Click
        '
        ' Clear all the stuff
        '

        PrefixString.Text = ""
        SuffixString.Text = ""

        AddCRLF.CheckState = System.Windows.Forms.CheckState.Unchecked
        QTBackslash.CheckState = System.Windows.Forms.CheckState.Unchecked
        DoubleSingle.CheckState = System.Windows.Forms.CheckState.Unchecked

    End Sub

    Public Sub CommonJava_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommonJava.Click
        '
        ' Common settings, Java
        '

        PrefixString.Text = Chr(34)

        SuffixString.Text = " "" + "

        AddCRLF.CheckState = System.Windows.Forms.CheckState.Unchecked

    End Sub

    Public Sub CommonJavaScript_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommonJavaScript.Click
        '
        ' Common settings, JavaScript
        '

        PrefixString.Text = Chr(34)

        SuffixString.Text = "\r\n"" +"

    End Sub


    Public Sub CommonVB_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommonVB.Click
        '
        ' Common settings, VB/ASP
        '

        PrefixString.Text = Chr(34)

        SuffixString.Text = " "" & _ "

    End Sub

    Private Sub Done_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Done.Click
        '
        ' All finished
        '

        Me.Close()

    End Sub


    Public Sub FileExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FileExit.Click
        '
        ' All finished
        '

        Done_Click(Done, New System.EventArgs())

    End Sub

    Public Sub FileInsert_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FileInsert.Click
        '
        ' Show the Insert generation
        '

        SQLInsForm.ShowDialog()

    End Sub

    Public Sub FileMerge_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles FileMerge.Click
        '
        ' Do the funky SQL merge generation
        '

        SQLMergeForm.ShowDialog()

    End Sub

    Private Sub ClipZapMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        '
        ' Pull in settings
        '

        PrefixString.Text = GetSetting(AppName, SecName, "Prefix")
        SuffixString.Text = GetSetting(AppName, SecName, "Suffix")

        AddCRLF.CheckState = CShort(GetSetting(AppName, SecName, "VBCrLf", "0"))
        QTBackslash.CheckState = CShort(GetSetting(AppName, SecName, "Backslash", "0"))
        DoubleSingle.CheckState = CShort(GetSetting(AppName, SecName, "DoubleSingle", "0"))

    End Sub

    Private Sub ClipZapMain_FormClosing(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim Cancel As Boolean = eventArgs.Cancel
        Dim UnloadMode As System.Windows.Forms.CloseReason = eventArgs.CloseReason
        '
        ' Save settings
        '

        SaveSetting(AppName, SecName, "Prefix", PrefixString.Text)
        SaveSetting(AppName, SecName, "Suffix", SuffixString.Text)

        SaveSetting(AppName, SecName, "VBCrLf", CStr(AddCRLF.CheckState))
        SaveSetting(AppName, SecName, "Backslash", CStr(QTBackslash.CheckState))
        SaveSetting(AppName, SecName, "DoubleSingle", CStr(DoubleSingle.CheckState))

        eventArgs.Cancel = Cancel
    End Sub

    Private Sub WriteFmt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles WriteFmt.Click
        '
        ' Process the whole clipboard...
        '
        Dim src As String

        src = My.Computer.Clipboard.GetText()

        If src = "" Then
            Beep()
            Exit Sub
        End If

        Dim pfx, sfx As String
        Dim qt As String
        Dim lct As Short

        Dim sa As New StringBuilder()

        qt = Chr(34)

        pfx = Replace(PrefixString.Text, "^t", vbTab)
        sfx = SuffixString.Text

        Dim bq, addnl, dq As Boolean
        Dim i As String

        addnl = AddCRLF.CheckState
        bq = QTBackslash.CheckState
        dq = DoubleSingle.CheckState

        Dim chunk As String

        For Each chunk In Split(src, vbCrLf)

            i = chunk

            If bq Then
                i = Replace(i, qt, "\""")
            End If

            If dq Then
                i = Replace(i, "'", "''")
            End If

            If Len(pfx) > 0 Then
                sa.Append(pfx)
            End If

            sa.Append(i)

            sa.AppendLine(sfx)

            lct = lct + 1

        Next chunk

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(sa.ToString())

        Status.Text = lct & " lines processed."

    End Sub

    Private Sub UnZap_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles UnZap.Click
        '
        ' Remove leading and trailing junk
        '
        Dim src As String

        Const prefixJunk As String = " """ & vbTab
        Const suffixJunk As String = vbTab & " &+_"""

        src = My.Computer.Clipboard.GetText()

        If src = "" Then
            Beep()
            Exit Sub
        End If

        Dim chunk As String

        Dim sa As New StringBuilder()

        Dim en, st, strlen As Short
        Dim i As String
        Dim lct As Short
        Dim sli As String

        lct = 0

        For Each chunk In Split(src, vbCrLf)

            i = chunk

            strlen = Len(i)

            st = 1
            en = strlen

            Do While st < strlen
                sli = Mid(i, st, 1)
                If InStr(prefixJunk, sli) > 0 Then
                    st = st + 1

                    If Asc(sli) = 34 Then
                        Exit Do
                    End If
                Else
                    Exit Do
                End If
            Loop

            Do While en > 1
                If InStr(suffixJunk, Mid(i, en, 1)) > 0 Then
                    en = en - 1
                Else
                    Exit Do
                End If
            Loop

            If en > st Then
                sa.AppendLine(Replace(Mid(i, st, en - st + 1), "&", ""))
                lct = lct + 1
            End If

        Next chunk

        If lct > 0 Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sa.ToString())
        End If

        Status.Text = lct & " lines processed."

    End Sub


    Public Sub CommonJSPImport_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CommonJSPImport.Click
        '
        ' Dezap a JSP Import block
        '
        Dim src As String

        src = My.Computer.Clipboard.GetText()

        If src = "" Then
            Beep()
            Exit Sub
        End If

        Dim chunk As String

        Dim sa As New StringBuilder()

        Dim i As String
        Dim lct, posn As Short

        Dim delim As String

        If InStr(src, "%><%") > 0 Then
            delim = "%><%"
        Else
            delim = vbCrLf
        End If

        lct = 0

        For Each chunk In Split(src, delim)

            i = Trim(chunk)

            posn = InStrRev(i, """")

            If posn > 0 Then
                i = VB.Left(i, posn - 1)

                If lct = 0 Then
                    sa.Append(i)
                Else
                    posn = InStr(i, """")

                    If posn > 0 Then
                        sa.Append("," & vbCrLf & vbTab & Mid(i, posn + 1))
                    End If
                End If
            End If

            lct = lct + 1
        Next chunk

        sa.AppendLine(""" %>")

        If lct > 0 Then
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sa.ToString())
        End If

        Status.Text = lct & " lines processed."

    End Sub

    Private Sub QuotesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuotesToolStripMenuItem.Click
        '
        ' Convert MS quotes to plain quotes
        '
        Dim src As String

        src = QuoteFilter(My.Computer.Clipboard.GetText())

        ' MsgBox "First char: " & Asc(src), vbOKOnly, "Char detect"

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(src)

        Status.Text = Len(src) & " chars processed"
    End Sub

    Private Function QuoteFilter(ByVal src As String) As String
        '
        ' Convert "smart quotes"
        '

        src = Replace(src, Chr(147), Chr(34))
        src = Replace(src, Chr(148), Chr(34))

        src = Replace(src, Chr(145), "'")
        QuoteFilter = Replace(src, Chr(146), "'")

    End Function

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        '
        ' Sql "IN"
        '

        PrefixString.Text = "'"

        SuffixString.Text = "',"

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        ' BCStatic
        '
        Dim src As String, cbline As String, frags() As String, wrk As String
        Dim posn As Integer, flen As Integer

        src = My.Computer.Clipboard.GetText()

        Dim sb As New System.Text.StringBuilder

        For Each cbline In src.Split(vbCrLf)
            frags = cbline.Trim().Replace(";", String.Empty).Split(","c, "("c, ")"c)

            flen = frags.Length

            If flen >= 2 Then
                wrk = frags(0)

                posn = wrk.IndexOf("Add")

                If posn > 0 Then

                    sb.Append(vbTab)
                    sb.Append("<bcn:BCS")
                    sb.Append(wrk.Substring(posn + 3))
                    sb.Append(" Text=")
                    sb.Append(frags(1))

                    If flen >= 3 Then
                        wrk = frags(2).Trim()

                        If wrk.Length > 0 Then
                            sb.Append(" URL=")
                            sb.Append(wrk)
                        End If

                        If flen >= 4 Then
                            wrk = frags(3).Trim()

                            If wrk.Length > 0 Then
                                sb.Append(" ToolTip=")
                                sb.Append(wrk)
                            End If
                        End If
                    End If

                    sb.AppendLine(" />")
                End If
            End If

        Next

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(sb.ToString())

        Status.Text = Len(src) & " chars processed"
    End Sub

    Private Sub DataTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        ' Turn Create Table into a DataTable
        '

        Dim tParse As New Regex("^\s*(\w+)\s+(\w+)(?:\((\d+)\))?\s")

        Dim m As Match, i As String, src As String = My.Computer.Clipboard.GetText()

        Dim sb As New StringBuilder( _
            "DataTable dt = new DataTable();" & _
                vbCrLf & vbCrLf & _
            "DataColumnCollection dcc = dt.Columns;" & _
                vbCrLf & vbCrLf & _
            "DataColumn dc; " & _
                vbCrLf & vbCrLf)

        Dim vt As String, grp As Group, fld As Integer = 0

        For Each i In src.Split(vbCrLf)
            m = tParse.Match(i)

            If m.Success Then
                sb.Append("dc = dcc.Add(""")
                sb.Append(m.Groups(1).Value)
                sb.Append(""", typeof(")

                vt = m.Groups(2).Value.ToLowerInvariant()

                Select Case vt
                    Case "int", "double"
                        sb.Append(vt)

                    Case "char", "varchar"
                        sb.Append("string")

                    Case "bit"
                        sb.Append("bool")

                    Case "datetime", "smalldatetime"
                        sb.Append("DateTime")

                    Case Else
                        sb.Append(vt)       ' Hope for the best...

                End Select

                sb.AppendLine("));" & vbTab & vbTab & "// " & fld)

                fld = fld + 1

                sb.Append("dc.AllowDBNull = ")

                If i.ToLower().Contains("not null") Then
                    sb.AppendLine("false;")
                Else
                    sb.AppendLine("true;")
                End If

                If m.Groups.Count > 2 Then
                    grp = m.Groups(3)

                    If grp.Success Then
                        sb.Append("dc.MaxLength = ")
                        sb.Append(grp.Value)
                        sb.AppendLine(";")
                    End If

                End If

                sb.AppendLine()

            End If

        Next i

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(sb.ToString())

        Status.Text = Len(src) & " chars processed"

    End Sub

    Private Sub SQLTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SQLTableToolStripMenuItem.Click
        '
        ' Remove brackets, collate, etc.
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        src = src.Replace("[", String.Empty).Replace("]", String.Empty) _
            .Replace("COLLATE SQL_Latin1_General_CP1_CI_AS ", String.Empty) _
            .Replace("NOT NULL", "not null") _
            .Replace("NULL", "null")

        Dim sb As New StringBuilder(src.Length), i As String

        For Each i In src.Split(vbCrLf)
            sb.AppendLine(i.Trim())
        Next

        src = sb.ToString().Replace("  ", " ")

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(src)

        Status.Text = src.Length & " chars processed"

    End Sub

    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLToolStripMenuItem.Click
        '
        ' Quick HTML encode
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            src = System.Web.HttpUtility.HtmlEncode(QuoteFilter(src.Trim()))

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub HTMLParaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLParaToolStripMenuItem.Click
        '
        ' Quick HTML encode - Para mode
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            src = "<p>" + System.Web.HttpUtility.HtmlEncode(QuoteFilter(src.Trim())).Replace(vbCrLf + vbCrLf, _
                "</p>" + vbCrLf + vbCrLf + "<p>") + "</p>"

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub ToNetTableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '
        ' Change plain HTML table to ASP.Net table
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim n As Integer, nMax As Integer = ASPTAB_REPL.Length - 1
            Dim frm As String, muto As String

            For n = 0 To nMax Step 2
                frm = ASPTAB_REPL(n)
                muto = ASPTAB_REPL(n + 1)

                src = src.Replace("<" + frm, "<" + muto)
                src = src.Replace("</" + frm, "</" + muto)
            Next n

            nMax = ASPTAB_ATTR.Length - 1

            For n = 0 To nMax Step 2
                src = src.Replace(" " + ASPTAB_ATTR(n) + "=", " " + ASPTAB_ATTR(n + 1) + "=")
            Next n

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If
    End Sub

    Private Sub FiddlerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        '
        ' Replace localhost with ipv4.fiddler
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            src = src.Replace("localhost", "ipv4.fiddler")

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub UnHTMLToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UnHTMLToolStripMenuItem.Click
        '
        ' Quick HTML decode
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            src = System.Web.HttpUtility.HtmlDecode(src.Trim())

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub SlashesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SlashesToolStripMenuItem.Click
        '
        ' Backslashes to forward slashes
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            src = src.Trim().Replace("\"c, "/"c)

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(src)

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub CommaSepToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CommaSepToolStripMenuItem.Click
        '
        ' Whitespace list to comma sep list
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim sb As New StringBuilder(), tok As String, isFirst As Boolean, lastCR As Integer

            isFirst = True

            lastCR = 0

            For Each tok In src.Replace("`", String.Empty).Split(vbCr, vbTab, " "c, vbLf, ","c)

                If Not String.IsNullOrWhiteSpace(tok) Then
                    If isFirst Then
                        isFirst = False
                    Else
                        sb.Append(", ")

                        If sb.Length - lastCR + tok.Length > 60 Then
                            sb.AppendLine()
                            lastCR = sb.Length
                        End If
                    End If

                    sb.Append(tok)
                End If

            Next

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sb.ToString())

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub SQLUpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SQLUpdateToolStripMenuItem.Click
        '
        ' List of fields to update format
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim sb As New StringBuilder(), tok As String, isFirst As Boolean

            isFirst = True

            For Each tok In src.Split(vbCr, vbTab, " "c, vbLf, ","c)

                If Not String.IsNullOrWhiteSpace(tok) Then
                    If isFirst Then
                        isFirst = False
                    Else
                        sb.AppendLine(", ")
                    End If

                    sb.Append(tok).Append(" = u.").Append(tok)
                End If

            Next

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sb.ToString())

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub DDLFieldsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DDLFieldsToolStripMenuItem.Click
        '
        ' Extract field names as comma sep from DDL
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim sb As New StringBuilder(), tok As String, isFirst As Boolean, lFrag As String, lastCR As Integer

            isFirst = True

            lastCR = 0

            For Each tok In src.Split(","c)

                lFrag = tok.Trim().Split(" "c)(0).Trim().Replace("[", String.Empty).Replace("]", String.Empty)

                If Not String.IsNullOrEmpty(lFrag) Then
                    If isFirst Then
                        isFirst = False
                    Else
                        sb.Append(", ")

                        If sb.Length - lastCR + lFrag.Length > 60 Then
                            sb.AppendLine()
                            lastCR = sb.Length
                        End If
                    End If

                    sb.Append(lFrag)
                End If

            Next

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sb.ToString())

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub DDLFieldListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DDLFieldListToolStripMenuItem.Click
        '
        ' Extract field names as pure list
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim sb As New StringBuilder(), tok As String, isFirst As Boolean, lFrag As String

            isFirst = True

            For Each tok In src.Split(","c)

                lFrag = tok.Trim().Split(" "c)(0).Trim().Replace("[", String.Empty).Replace("]", String.Empty)

                If Not String.IsNullOrEmpty(lFrag) Then
                    If isFirst Then
                        isFirst = False
                    Else
                        sb.AppendLine()
                    End If
                End If

                sb.Append(lFrag)
            Next

            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sb.ToString())

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub GenericCBFormat(ByVal fmtHandler As CBFormat)
        '
        ' Do the standard Clipboard Format
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            Dim fv As String = fmtHandler(src)

            My.Computer.Clipboard.Clear()

            If Not String.IsNullOrEmpty(fv) Then
                My.Computer.Clipboard.SetText(fv)
            End If

            Status.Text = src.Length & " chars processed"
        End If
    End Sub

    Private Sub CodeCSharp_Click(sender As System.Object, e As System.EventArgs) Handles CodeCSharp.Click
        '
        ' Clipboard C# format
        '

        GenericCodeFormat(New CSharpFormat())

    End Sub

    Private Sub GenericCodeFormat(sfo As SourceFormat)
        '
        ' Handle the code formats from the clipboard
        '

        Dim src As String = My.Computer.Clipboard.GetText()

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            My.Computer.Clipboard.Clear()
            My.Computer.Clipboard.SetText(sfo.FormatCode(src))

            Status.Text = src.Length & " chars processed"
        End If

    End Sub

    Private Sub CodeSQL_Click(sender As System.Object, e As System.EventArgs) Handles CodeSQL.Click
        '
        ' Clipboard SQL format
        '

        GenericCodeFormat(New TsqlFormat())

    End Sub

    Private Sub CodeVB_Click(sender As System.Object, e As System.EventArgs) Handles CodeVB.Click
        '
        ' Clipboard VB format
        '

        GenericCodeFormat(New VisualBasicFormat())

    End Sub

    Private Sub CodeFormatJScript_Click(sender As System.Object, e As System.EventArgs) Handles CodeFormatJScript.Click
        '
        ' Clipboard JS format
        '

        GenericCodeFormat(New JavaScriptFormat())

    End Sub

    Private Sub CodeFromFile_Click(sender As System.Object, e As System.EventArgs) Handles CodeFromFile.Click
        '
        ' Format from file
        '

        CodeFormatForm.Show(Me)

    End Sub

    Private Sub UnURL_Click(sender As System.Object, e As System.EventArgs) Handles UnURL.Click
        '
        ' Convert from URL
        '

        GenericCBFormat(Function(src) HttpUtility.UrlDecode(src))

    End Sub

    Private Sub ToURL_Click(sender As System.Object, e As System.EventArgs) Handles ToURL.Click
        '
        ' Convert to URL
        '

        GenericCBFormat(Function(src) HttpUtility.UrlEncode(src))

    End Sub

    Private Function MarkDownTable(src As String) As String
        '
        ' Convert a Markdown table header to the corresponding dashes row
        '

        Dim sl As Integer = src.Length, ci As Integer

        Dim db(sl) As Char

        sl = sl - 1

        For ci = 0 To sl
            If src(ci) = "|"c Then
                db(ci) = "|"c
            Else
                db(ci) = "-"c
            End If
        Next

        MarkDownTable = New String(db)

    End Function

    Private Sub MarkdownTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkdownTableToolStripMenuItem.Click
        GenericCBFormat(AddressOf MarkDownTable)
    End Sub

    Private Function QuotedPrintable(ByVal src As String) As String
        Dim acc As New StringBuilder(), l As String

        Using sr As New StringReader(src)

            l = sr.ReadLine()

            While Not IsNothing(l)

                l = l.Trim()

                If l.EndsWith("=20") Then
                    acc.Append(l.Substring(0, l.Length - 3))
                    acc.Append(" ")
                ElseIf l.EndsWith("=") Then
                    acc.Append(l.Substring(0, l.Length - 1))
                Else
                    acc.AppendLine(l)
                End If

                l = sr.ReadLine()

            End While

        End Using

        QuotedPrintable = acc.ToString()

    End Function

    Private Sub QPrintableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QPrintableToolStripMenuItem.Click
        GenericCBFormat(AddressOf QuotedPrintable)
    End Sub

    Private Sub Standard_Process_Lines(handler As CBFormat)
        '
        ' The normal process but per CRLF line
        '
        Dim src As String = My.Computer.Clipboard.GetText()
        Dim acc As New StringBuilder, iLine As String, rv As String

        If String.IsNullOrEmpty(src) Then
            Status.Text = "Clipboard Empty"
        Else
            For Each iLine In src.Split(CChar(vbCr), CChar(vbLf))
                iLine = iLine.Trim()

                If iLine.Length > 0 Then
                    rv = handler(iLine)

                    If rv.Length > 0 Then
                        acc.AppendLine(rv)
                    End If
                End If

            Next

            src = acc.ToString()
        End If

        My.Computer.Clipboard.Clear()
        My.Computer.Clipboard.SetText(src)

        Status.Text = src.Length & " chars processed"
    End Sub

    Private Sub MySQLColAddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySQLColAddToolStripMenuItem.Click
        '
        ' Convert MySQL DDL to "add column"
        '

        Dim tblName As String

        tblName = InputBox("MySQL table name", "MySQL Column Add")

        If tblName.Length = 0 Then
            Exit Sub
        End If

        Standard_Process_Lines(Function(x As String)
                                   Return "alter table " + tblName + " add column " + x.Trim(" "c, ","c) + ";"
                               End Function)
    End Sub

    Private Sub TicksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TicksToolStripMenuItem.Click
        '
        ' Wipe out backticks
        '

        Standard_Process_Lines(Function(x As String)
                                   Return x.Replace("`", "")
                               End Function)

    End Sub

    Private Sub MySQLChecksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MySQLChecksToolStripMenuItem.Click
        GenericCBFormat(AddressOf CheckConstraints)
    End Sub

    Private Function CheckConstraints(ByVal text As String) As String
        '
        ' Calculate Check constraints
        '

        Dim tblName As String, match As Match, flags As MatchCollection, output As New StringBuilder, fieldName As String

        match = New Regex("CREATE TABLE `(\w+)`", RegexOptions.IgnoreCase).Match(text)

        If Not match.Success Then
            CheckConstraints = text
            Exit Function
        End If

        tblName = match.Groups(1).Value

        flags = New Regex("`(\w+)`\s+TINYINT(?:\(\d+\))? NOT NULL DEFAULT", RegexOptions.IgnoreCase).Matches(text)

        For Each match In flags

            output.Append("alter table ")

            output.Append(tblName)

            fieldName = match.Groups(1).Value

            output.Append(" add constraint if not exists chk_")

            output.Append(fieldName)

            output.Append(" check(").Append(fieldName).Append(" = 0 or ").Append(fieldName).AppendLine(" = 1);")

            output.AppendLine()

        Next

        CheckConstraints = output.ToString()

    End Function


End Class
