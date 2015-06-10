<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUIServerMainWindow
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
    Me.components = New System.ComponentModel.Container()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.TimerRightSideCommands = New System.Windows.Forms.Timer(Me.components)
    Me.TimerLeftSideCommands = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout
    '
    'TextBox1
    '
    Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.TextBox1.Location = New System.Drawing.Point(0, 502)
    Me.TextBox1.Multiline = true
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.TextBox1.Size = New System.Drawing.Size(1171, 78)
    Me.TextBox1.TabIndex = 0
    '
    'TextBox2
    '
    Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Top
    Me.TextBox2.Location = New System.Drawing.Point(0, 0)
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.Size = New System.Drawing.Size(1171, 20)
    Me.TextBox2.TabIndex = 1
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'TimerRightSideCommands
    '
    Me.TimerRightSideCommands.Enabled = true
    '
    'TimerLeftSideCommands
    '
    Me.TimerLeftSideCommands.Enabled = true
    '
    'GUIServerMainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1171, 580)
    Me.Controls.Add(Me.TextBox2)
    Me.Controls.Add(Me.TextBox1)
    Me.Name = "GUIServerMainWindow"
    Me.Text = "Form1"
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TimerRightSideCommands As System.Windows.Forms.Timer
    Friend WithEvents TimerLeftSideCommands As System.Windows.Forms.Timer

End Class
