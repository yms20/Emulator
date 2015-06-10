<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIGetriebe
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.tbTranslation = New System.Windows.Forms.TextBox()
    Me.SuspendLayout
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
    Me.Label1.Location = New System.Drawing.Point(0, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(59, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Translation"
    '
    'tbTranslation
    '
    Me.tbTranslation.Dock = System.Windows.Forms.DockStyle.Fill
    Me.tbTranslation.Location = New System.Drawing.Point(59, 0)
    Me.tbTranslation.Name = "tbTranslation"
    Me.tbTranslation.Size = New System.Drawing.Size(92, 20)
    Me.tbTranslation.TabIndex = 1
    '
    'UIGetriebe
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.tbTranslation)
    Me.Controls.Add(Me.Label1)
    Me.Name = "UIGetriebe"
    Me.Size = New System.Drawing.Size(151, 20)
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbTranslation As System.Windows.Forms.TextBox

End Class
