''Name: Hir Joshi
''program: Text Editor
''Date:April 4,2019
''Subject: Net development

Option Strict On
Imports System.IO

Public Class FrmTextEditor

    Dim filelocate As String
    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs) Handles HelpOption.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewOption.Click
        filelocate = String.Empty   '' giving the null to the file we made 
        rchTextbox.Enabled = True   '' this is used to enable the rchTextbox
        rchTextbox.Clear()          '' this helps in clering the text box

    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenOption.Click
        Dim fileOpen As New OpenFileDialog
        fileOpen.ShowDialog()
        filelocate = fileOpen.FileName

        If Not (String.IsNullOrEmpty(filelocate)) Then
            Dim fs As New FileStream(filelocate, FileMode.Open, FileAccess.Read)
            Dim rdStream As New StreamReader(fs)
            rchTextbox.Text = rdStream.ReadToEnd()
            rdStream.Close()
            fs.Close()
        End If
        rchTextbox.Enabled = True
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveOption.Click
        If String.IsNullOrEmpty(filelocate) Then
            Dim dlgSave As New SaveFileDialog
            dlgSave.ShowDialog()
            filelocate = dlgSave.FileName

            If Not (String.IsNullOrEmpty(filelocate)) Then
                Dim wrStream As New StreamWriter(filelocate)
                wrStream.Write(rchTextbox.Text)
                rchTextbox.Enabled = True
                wrStream.Close()
            End If

        Else

            Dim wrStream As New StreamWriter(filelocate)
            wrStream.Write(rchTextbox.Text)
            wrStream.Close()
            rchTextbox.Enabled = True

        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsOption.Click
        Dim dlgSave As New SaveFileDialog
        dlgSave.ShowDialog()
        filelocate = dlgSave.FileName

        If Not (String.IsNullOrEmpty(filelocate)) Then
            Dim wrStream As New StreamWriter(filelocate)
            wrStream.Write(rchTextbox.Text)
            wrStream.Close()
            rchTextbox.Enabled = True
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseOption.Click
        rchTextbox.Clear()
        filelocate = String.Empty
        rchTextbox.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitOption.Click
        Me.Close()
    End Sub

    Private Sub CoptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyOption.Click
        If Not (String.IsNullOrEmpty(rchTextbox.SelectedText)) Then
            My.Computer.Clipboard.SetText(rchTextbox.SelectedText)
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutOption.Click
        rchTextbox.SelectedText = ""
        If Not (String.IsNullOrEmpty(rchTextbox.SelectedText)) Then
            My.Computer.Clipboard.SetText(rchTextbox.SelectedText)
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteOption.Click
        If Not (String.IsNullOrEmpty(My.Computer.Clipboard.GetText)) Then
            rchTextbox.SelectedText = My.Computer.Clipboard.GetText
        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutOption.Click
        Dim msgBox As String = "Netdevelopment" & vbCrLf & "Lab #5" & vbCrLf & "Hii This Is Hir Joshi"
        MessageBox.Show(msgBox)
    End Sub
End Class
