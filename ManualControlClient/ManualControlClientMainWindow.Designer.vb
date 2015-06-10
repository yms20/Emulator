<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManualControlClientMainWindow
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManualControlClientMainWindow))
    Me.ButtonConnect = New System.Windows.Forms.Button()
    Me.XytTupleInputRight = New ManualControlClient.XYTTupleInput()
    Me.XytTupleInputLeft = New ManualControlClient.XYTTupleInput()
    Me.ButtonSendLeft = New System.Windows.Forms.Button()
    Me.ButtonSendRight = New System.Windows.Forms.Button()
    Me.SuspendLayout
    '
    'ButtonConnect
    '
    Me.ButtonConnect.Location = New System.Drawing.Point(0, 0)
    Me.ButtonConnect.Name = "ButtonConnect"
    Me.ButtonConnect.Size = New System.Drawing.Size(75, 23)
    Me.ButtonConnect.TabIndex = 0
    Me.ButtonConnect.Text = "Connect"
    Me.ButtonConnect.UseVisualStyleBackColor = true
    '
    'XytTupleInputRight
    '
    Me.XytTupleInputRight.Enabled = false
    Me.XytTupleInputRight.Location = New System.Drawing.Point(277, 29)
    Me.XytTupleInputRight.Name = "XytTupleInputRight"
    Me.XytTupleInputRight.Side = ManualControlClient.XYTTupleInput.automatenseite.right
    Me.XytTupleInputRight.Size = New System.Drawing.Size(259, 106)
    Me.XytTupleInputRight.TabIndex = 1
    Me.XytTupleInputRight.Value = CType(resources.GetObject("XytTupleInputRight.Value"),EmulatorAPI.XYTCoord)
    '
    'XytTupleInputLeft
    '
    Me.XytTupleInputLeft.Enabled = false
    Me.XytTupleInputLeft.Location = New System.Drawing.Point(12, 29)
    Me.XytTupleInputLeft.Name = "XytTupleInputLeft"
    Me.XytTupleInputLeft.Side = ManualControlClient.XYTTupleInput.automatenseite.left
    Me.XytTupleInputLeft.Size = New System.Drawing.Size(259, 106)
    Me.XytTupleInputLeft.TabIndex = 2
    Me.XytTupleInputLeft.Value = CType(resources.GetObject("XytTupleInputLeft.Value"),EmulatorAPI.XYTCoord)
    '
    'ButtonSendLeft
    '
    Me.ButtonSendLeft.Enabled = false
    Me.ButtonSendLeft.Location = New System.Drawing.Point(12, 141)
    Me.ButtonSendLeft.Name = "ButtonSendLeft"
    Me.ButtonSendLeft.Size = New System.Drawing.Size(75, 23)
    Me.ButtonSendLeft.TabIndex = 3
    Me.ButtonSendLeft.Text = "Go Links"
    Me.ButtonSendLeft.UseVisualStyleBackColor = true
    '
    'ButtonSendRight
    '
    Me.ButtonSendRight.Enabled = false
    Me.ButtonSendRight.Location = New System.Drawing.Point(277, 141)
    Me.ButtonSendRight.Name = "ButtonSendRight"
    Me.ButtonSendRight.Size = New System.Drawing.Size(75, 23)
    Me.ButtonSendRight.TabIndex = 3
    Me.ButtonSendRight.Text = "Go Rechts"
    Me.ButtonSendRight.UseVisualStyleBackColor = true
    '
    'ManualControlClientMainWindow
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(541, 176)
    Me.Controls.Add(Me.ButtonSendRight)
    Me.Controls.Add(Me.ButtonSendLeft)
    Me.Controls.Add(Me.XytTupleInputLeft)
    Me.Controls.Add(Me.XytTupleInputRight)
    Me.Controls.Add(Me.ButtonConnect)
    Me.Name = "ManualControlClientMainWindow"
    Me.Text = "Form1"
    Me.ResumeLayout(false)

End Sub
    Friend WithEvents ButtonConnect As System.Windows.Forms.Button
    Friend WithEvents XytTupleInputRight As ManualControlClient.XYTTupleInput
    Friend WithEvents XytTupleInputLeft As ManualControlClient.XYTTupleInput
    Friend WithEvents ButtonSendLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonSendRight As System.Windows.Forms.Button

End Class
