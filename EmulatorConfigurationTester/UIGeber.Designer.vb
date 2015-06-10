<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIGeber
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
    Me.lbLoc = New System.Windows.Forms.Label()
    Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
    Me.lbMin = New System.Windows.Forms.Label()
    Me.lbMax = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'lbLoc
    '
    Me.lbLoc.AutoSize = true
    Me.lbLoc.Location = New System.Drawing.Point(5, 4)
    Me.lbLoc.Name = "lbLoc"
    Me.lbLoc.Size = New System.Drawing.Size(48, 13)
    Me.lbLoc.TabIndex = 0
    Me.lbLoc.Text = "Location"
    '
    'Timer1
    '
    Me.Timer1.Enabled = true
    '
    'lbMin
    '
    Me.lbMin.AutoSize = true
    Me.lbMin.Location = New System.Drawing.Point(5, 30)
    Me.lbMin.Name = "lbMin"
    Me.lbMin.Size = New System.Drawing.Size(48, 13)
    Me.lbMin.TabIndex = 2
    Me.lbMin.Text = "Minimum"
    '
    'lbMax
    '
    Me.lbMax.AutoSize = true
    Me.lbMax.Location = New System.Drawing.Point(5, 17)
    Me.lbMax.Name = "lbMax"
    Me.lbMax.Size = New System.Drawing.Size(51, 13)
    Me.lbMax.TabIndex = 1
    Me.lbMax.Text = "Maximum"
    '
    'UIGeber
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.lbMin)
    Me.Controls.Add(Me.lbMax)
    Me.Controls.Add(Me.lbLoc)
    Me.Name = "UIGeber"
    Me.Size = New System.Drawing.Size(63, 46)
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents lbLoc As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbMin As System.Windows.Forms.Label
    Friend WithEvents lbMax As System.Windows.Forms.Label

End Class
