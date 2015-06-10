<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIMotor
    Inherits System.Windows.Forms.UserControl

    'UserControl überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Me.btStart = New System.Windows.Forms.Button()
    Me.timer = New System.Windows.Forms.Timer(Me.components)
    Me.btStop = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.SuspendLayout
    '
    'btStart
    '
    Me.btStart.AutoSize = true
    Me.btStart.Dock = System.Windows.Forms.DockStyle.Left
    Me.btStart.Location = New System.Drawing.Point(0, 0)
    Me.btStart.Name = "btStart"
    Me.btStart.Size = New System.Drawing.Size(39, 21)
    Me.btStart.TabIndex = 0
    Me.btStart.Text = "Start"
    Me.btStart.UseVisualStyleBackColor = true
    '
    'timer
    '
    Me.timer.Enabled = true
    '
    'btStop
    '
    Me.btStop.AutoSize = true
    Me.btStop.Dock = System.Windows.Forms.DockStyle.Right
    Me.btStop.Location = New System.Drawing.Point(137, 0)
    Me.btStop.Name = "btStop"
    Me.btStop.Size = New System.Drawing.Size(39, 21)
    Me.btStop.TabIndex = 3
    Me.btStop.Text = "Stop"
    Me.btStop.UseVisualStyleBackColor = true
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.Label1.Location = New System.Drawing.Point(39, 0)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(39, 13)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "Label1"
    '
    'UIMotor
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.btStop)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.btStart)
    Me.Name = "UIMotor"
    Me.Size = New System.Drawing.Size(176, 21)
    Me.ResumeLayout(false)
    Me.PerformLayout

End Sub
    Friend WithEvents btStart As System.Windows.Forms.Button
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents btStop As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
