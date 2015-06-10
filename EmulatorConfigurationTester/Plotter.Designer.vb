<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plotter
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
    Me.components = New System.ComponentModel.Container()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.lbAchse = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'Timer1
    '
    '
    'lbAchse
    '
    Me.lbAchse.AutoSize = true
    Me.lbAchse.Location = New System.Drawing.Point(-3, 0)
    Me.lbAchse.Name = "lbAchse"
    Me.lbAchse.Size = New System.Drawing.Size(69, 13)
    Me.lbAchse.TabIndex = 1
    Me.lbAchse.Text = "Achsenname"
    '
    'Plotter
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lbAchse)
    Me.Name = "Plotter"
    Me.Size = New System.Drawing.Size(150, 39)
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbAchse As System.Windows.Forms.Label

End Class
