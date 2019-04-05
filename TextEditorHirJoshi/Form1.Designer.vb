<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTextEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTextEditor))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FileOption = New System.Windows.Forms.ToolStripDropDownButton()
        Me.HelpOption = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EditOption = New System.Windows.Forms.ToolStripDropDownButton()
        Me.NewOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutOption = New System.Windows.Forms.ToolStripMenuItem()
        Me.rchTextbox = New System.Windows.Forms.RichTextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileOption, Me.EditOption, Me.HelpOption})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'FileOption
        '
        Me.FileOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileOption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewOption, Me.OpenOption, Me.SaveOption, Me.SaveAsOption, Me.CloseOption, Me.ExitOption})
        Me.FileOption.Image = CType(resources.GetObject("FileOption.Image"), System.Drawing.Image)
        Me.FileOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.FileOption.Name = "FileOption"
        Me.FileOption.Size = New System.Drawing.Size(56, 29)
        Me.FileOption.Text = "&File"
        '
        'HelpOption
        '
        Me.HelpOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpOption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutOption})
        Me.HelpOption.Image = CType(resources.GetObject("HelpOption.Image"), System.Drawing.Image)
        Me.HelpOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HelpOption.Name = "HelpOption"
        Me.HelpOption.Size = New System.Drawing.Size(67, 29)
        Me.HelpOption.Text = "&Help"
        '
        'EditOption
        '
        Me.EditOption.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditOption.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyOption, Me.CutOption, Me.PasteOption})
        Me.EditOption.Image = CType(resources.GetObject("EditOption.Image"), System.Drawing.Image)
        Me.EditOption.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditOption.Name = "EditOption"
        Me.EditOption.Size = New System.Drawing.Size(60, 29)
        Me.EditOption.Text = "E&dit"
        '
        'NewOption
        '
        Me.NewOption.Name = "NewOption"
        Me.NewOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewOption.Size = New System.Drawing.Size(252, 30)
        Me.NewOption.Text = "&New"
        Me.NewOption.ToolTipText = "This is used for creating new file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'OpenOption
        '
        Me.OpenOption.Name = "OpenOption"
        Me.OpenOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenOption.Size = New System.Drawing.Size(252, 30)
        Me.OpenOption.Text = "&Open"
        Me.OpenOption.ToolTipText = "Opening a new file."
        '
        'SaveOption
        '
        Me.SaveOption.Name = "SaveOption"
        Me.SaveOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveOption.Size = New System.Drawing.Size(252, 30)
        Me.SaveOption.Text = "&Save"
        Me.SaveOption.ToolTipText = "Saving a new file."
        '
        'SaveAsOption
        '
        Me.SaveAsOption.Name = "SaveAsOption"
        Me.SaveAsOption.Size = New System.Drawing.Size(252, 30)
        Me.SaveAsOption.Text = "Save &As"
        Me.SaveAsOption.ToolTipText = "SaveAs a new file."
        '
        'CloseOption
        '
        Me.CloseOption.Name = "CloseOption"
        Me.CloseOption.Size = New System.Drawing.Size(252, 30)
        Me.CloseOption.Text = "&Close"
        Me.CloseOption.ToolTipText = "Close the file."
        '
        'ExitOption
        '
        Me.ExitOption.Name = "ExitOption"
        Me.ExitOption.Size = New System.Drawing.Size(252, 30)
        Me.ExitOption.Text = "E&xit"
        Me.ExitOption.ToolTipText = "Existing the file."
        '
        'CopyOption
        '
        Me.CopyOption.Name = "CopyOption"
        Me.CopyOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyOption.Size = New System.Drawing.Size(252, 30)
        Me.CopyOption.Text = "&Copy"
        Me.CopyOption.ToolTipText = "Copying the file."
        '
        'CutOption
        '
        Me.CutOption.Name = "CutOption"
        Me.CutOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.CutOption.Size = New System.Drawing.Size(252, 30)
        Me.CutOption.Text = "Cu&t"
        Me.CutOption.ToolTipText = "Cutting the file."
        '
        'PasteOption
        '
        Me.PasteOption.Name = "PasteOption"
        Me.PasteOption.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PasteOption.Size = New System.Drawing.Size(252, 30)
        Me.PasteOption.Text = "&Paste"
        Me.PasteOption.ToolTipText = "Paste the file."
        '
        'AboutOption
        '
        Me.AboutOption.Name = "AboutOption"
        Me.AboutOption.Size = New System.Drawing.Size(252, 30)
        Me.AboutOption.Text = "&About"
        Me.AboutOption.ToolTipText = "About the file."
        '
        'rchTextbox
        '
        Me.rchTextbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rchTextbox.Location = New System.Drawing.Point(0, 32)
        Me.rchTextbox.Name = "rchTextbox"
        Me.rchTextbox.Size = New System.Drawing.Size(800, 418)
        Me.rchTextbox.TabIndex = 1
        Me.rchTextbox.Text = ""
        '
        'FrmTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rchTextbox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.ToolTip1.SetToolTip(Me, "ToolTip")
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileOption As ToolStripDropDownButton
    Friend WithEvents NewOption As ToolStripMenuItem
    Friend WithEvents OpenOption As ToolStripMenuItem
    Friend WithEvents SaveOption As ToolStripMenuItem
    Friend WithEvents SaveAsOption As ToolStripMenuItem
    Friend WithEvents CloseOption As ToolStripMenuItem
    Friend WithEvents ExitOption As ToolStripMenuItem
    Friend WithEvents EditOption As ToolStripDropDownButton
    Friend WithEvents CopyOption As ToolStripMenuItem
    Friend WithEvents CutOption As ToolStripMenuItem
    Friend WithEvents PasteOption As ToolStripMenuItem
    Friend WithEvents HelpOption As ToolStripDropDownButton
    Friend WithEvents AboutOption As ToolStripMenuItem
    Friend WithEvents rchTextbox As RichTextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
