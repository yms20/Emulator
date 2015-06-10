<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XYTTupleInput
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
    Me.NumericUpDownX = New System.Windows.Forms.NumericUpDown()
    Me.NumericUpDownY = New System.Windows.Forms.NumericUpDown()
    Me.NumericUpDownTurn = New System.Windows.Forms.NumericUpDown()
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    CType(Me.NumericUpDownX,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.NumericUpDownY,System.ComponentModel.ISupportInitialize).BeginInit
    CType(Me.NumericUpDownTurn,System.ComponentModel.ISupportInitialize).BeginInit
    Me.GroupBox1.SuspendLayout
    Me.SuspendLayout
    '
    'NumericUpDownX
    '
    Me.NumericUpDownX.Increment = New Decimal(New Integer() {100, 0, 0, 0})
    Me.NumericUpDownX.Location = New System.Drawing.Point(131, 14)
    Me.NumericUpDownX.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
    Me.NumericUpDownX.Name = "NumericUpDownX"
    Me.NumericUpDownX.Size = New System.Drawing.Size(117, 20)
    Me.NumericUpDownX.TabIndex = 0
    '
    'NumericUpDownY
    '
    Me.NumericUpDownY.Increment = New Decimal(New Integer() {100, 0, 0, 0})
    Me.NumericUpDownY.Location = New System.Drawing.Point(131, 40)
    Me.NumericUpDownY.Maximum = New Decimal(New Integer() {50000, 0, 0, 0})
    Me.NumericUpDownY.Name = "NumericUpDownY"
    Me.NumericUpDownY.Size = New System.Drawing.Size(117, 20)
    Me.NumericUpDownY.TabIndex = 1
    '
    'NumericUpDownTurn
    '
    Me.NumericUpDownTurn.Location = New System.Drawing.Point(169, 66)
    Me.NumericUpDownTurn.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
    Me.NumericUpDownTurn.Name = "NumericUpDownTurn"
    Me.NumericUpDownTurn.Size = New System.Drawing.Size(79, 20)
    Me.NumericUpDownTurn.TabIndex = 2
    '
    'Label1
    '
    Me.Label1.AutoSize = true
    Me.Label1.Location = New System.Drawing.Point(6, 16)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(68, 13)
    Me.Label1.TabIndex = 3
    Me.Label1.Text = "X Coordinate"
    '
    'Label2
    '
    Me.Label2.AutoSize = true
    Me.Label2.Location = New System.Drawing.Point(6, 40)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(68, 13)
    Me.Label2.TabIndex = 3
    Me.Label2.Text = "Y Coordinate"
    '
    'Label3
    '
    Me.Label3.AutoSize = true
    Me.Label3.Location = New System.Drawing.Point(6, 66)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(48, 13)
    Me.Label3.TabIndex = 3
    Me.Label3.Text = "TurnUnit"
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(69, 66)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(33, 23)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Left"
    Me.Button1.UseVisualStyleBackColor = true
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(108, 66)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(44, 23)
    Me.Button2.TabIndex = 4
    Me.Button2.Text = "Right"
    Me.Button2.UseVisualStyleBackColor = true
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.NumericUpDownTurn)
    Me.GroupBox1.Controls.Add(Me.Button2)
    Me.GroupBox1.Controls.Add(Me.NumericUpDownX)
    Me.GroupBox1.Controls.Add(Me.Button1)
    Me.GroupBox1.Controls.Add(Me.NumericUpDownY)
    Me.GroupBox1.Controls.Add(Me.Label3)
    Me.GroupBox1.Controls.Add(Me.Label1)
    Me.GroupBox1.Controls.Add(Me.Label2)
    Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(259, 106)
    Me.GroupBox1.TabIndex = 5
    Me.GroupBox1.TabStop = false
    Me.GroupBox1.Text = "GroupBox1"
    '
    'XYTTupleInput
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.Controls.Add(Me.GroupBox1)
    Me.Name = "XYTTupleInput"
    Me.Size = New System.Drawing.Size(259, 106)
    CType(Me.NumericUpDownX,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.NumericUpDownY,System.ComponentModel.ISupportInitialize).EndInit
    CType(Me.NumericUpDownTurn,System.ComponentModel.ISupportInitialize).EndInit
    Me.GroupBox1.ResumeLayout(false)
    Me.GroupBox1.PerformLayout
    Me.ResumeLayout(false)

End Sub
    Friend WithEvents NumericUpDownX As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownY As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownTurn As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
